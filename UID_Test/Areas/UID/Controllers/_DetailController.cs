using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using WalkingTec.Mvvm.Core.Extensions;
using System.Linq;
using System.Collections.Generic;
using UID_Test.Model.UID;
using UID_Test.ViewModel.UID.DetailVMs;
using UID_Test.Model;

namespace UID_Test.UID.Controllers
{
    [AuthorizeJwtWithCookie]
    [ActionDescription("_Model.Detail")]
    [ApiController]
    [Route("/api/UID/Detail/")]
    public partial class DetailController : BaseApiController
    {
        [ActionDescription("Sys.Get")]
        [HttpGet("{id}")]
        public DetailVM Get(string id)
        {
            var vm = Wtm.CreateVM<DetailVM>(id);
            return vm;
        }

        [ActionDescription("Sys.Create")]
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(DetailVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                await vm.DoAddAsync();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }

        }

        [ActionDescription("Sys.Edit")]
        [HttpPut("[action]")]
        public async Task<IActionResult> Edit(DetailVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                await vm.DoEditAsync(false);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }
        }

        [HttpPost("BatchEdit")]
        [ActionDescription("Sys.BatchEdit")]
        public ActionResult BatchEdit(DetailBatchVM vm)
        {
            if (!ModelState.IsValid || !vm.DoBatchEdit())
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                return Ok(vm.Ids.Count());
            }
        }

		[HttpPost("BatchDelete")]
        [ActionDescription("Sys.Delete")]
        public IActionResult BatchDelete(string[] ids)
        {
            var vm = Wtm.CreateVM<DetailBatchVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = ids;
            }
            else
            {
                return Ok();
            }
            if (!ModelState.IsValid || !vm.DoBatchDelete())
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                return Ok(ids.Count());
            }
        }

        [ActionDescription("Sys.DownloadTemplate")]
        [HttpGet("GetExcelTemplate")]
        public IActionResult GetExcelTemplate()
        {
            var vm = Wtm.CreateVM<DetailImportVM>();
            var qs = new Dictionary<string, string>();
            foreach (var item in Request.Query.Keys)
            {
                qs.Add(item, Request.Query[item]);
            }
            vm.SetParms(qs);
            var data = vm.GenerateTemplate(out string fileName);
            return File(data, "application/vnd.ms-excel", fileName);
        }

        [ActionDescription("Sys.Import")]
        [HttpPost("Import")]
        public ActionResult Import(DetailImportVM vm)
        {

            if (vm.ErrorListVM.EntityList.Count > 0 || !vm.BatchSaveData())
            {
                return BadRequest(vm.GetErrorJson());
            }
            else
            {
                return Ok(vm.EntityList.Count);
            }
        }

        
        [HttpGet("GetMasters")]
        public ActionResult GetMasters()
        {
            return Ok(DC.Set<Master>().GetSelectListItems(Wtm, x => x.Imp_lno));
        }
        [HttpPost("[action]")]
        public ActionResult Select_GetDetailByMaster(List<string> id)
        {
            var rv = DC.Set<Detail>().CheckIDs(id, x => x.MasterId).GetSelectListItems(Wtm,x=>x.ID.ToString());
            return Ok(rv);
        }

        [HttpPost("[action]")]
        public ActionResult Select_GetMasterByMasterId(List<string> id)
        {
            var rv = DC.Set<Master>().CheckIDs(id).GetSelectListItems(Wtm, x => x.Imp_lno);
            return Ok(rv);
        }


    }
}