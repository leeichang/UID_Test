using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using UID_Test.Model;
using UID_Test.ViewModel.UID.MasterVMs;


namespace UID_Test.UID.Controllers
{
    [AuthorizeJwtWithCookie]
    public partial class MasterController : BaseApiController
    {
                                                
        [ActionDescription("Sys.Search")]
        [HttpPost("[action]")]
        public IActionResult SearchMaster(UID_Test.ViewModel.UID.MasterVMs.MasterSearcher searcher)
        {
            if (ModelState.IsValid)
            {
                var vm = Wtm.CreateVM<UID_Test.ViewModel.UID.MasterVMs.MasterListVM>();
                vm.Searcher = searcher;
                return Content(vm.GetJson());
            }
            else
            {
                return BadRequest(ModelState.GetErrorJson());
            }
        }

        [ActionDescription("Sys.Export")]
        [HttpPost("[action]")]
        public IActionResult MasterExportExcel(UID_Test.ViewModel.UID.MasterVMs.MasterSearcher searcher)
        {
            var vm = Wtm.CreateVM<UID_Test.ViewModel.UID.MasterVMs.MasterListVM>();
            vm.Searcher = searcher;
            vm.SearcherMode = ListVMSearchModeEnum.Export;
            return vm.GetExportData();
        }

        [ActionDescription("Sys.CheckExport")]
        [HttpPost("[action]")]
        public IActionResult MasterExportExcelByIds(string[] ids)
        {
            var vm = Wtm.CreateVM<UID_Test.ViewModel.UID.MasterVMs.MasterListVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = new List<string>(ids);
                vm.SearcherMode = ListVMSearchModeEnum.CheckExport;
            }
            return vm.GetExportData();
        }
    
    }
}


