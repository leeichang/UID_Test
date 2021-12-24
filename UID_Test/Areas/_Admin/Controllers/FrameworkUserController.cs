using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using UID_Test.Model;
using UID_Test.ViewModel._Admin.FrameworkUserVMs;


namespace UID_Test._Admin.Controllers
{
    [AuthorizeJwtWithCookie]
    public partial class FrameworkUserController : BaseApiController
    {
                                                        
        [ActionDescription("Sys.Search")]
        [HttpPost("[action]")]
        public IActionResult SearchFrameworkUser(UID_Test.ViewModel._Admin.FrameworkUserVMs.FrameworkUserSearcher searcher)
        {
            if (ModelState.IsValid)
            {
                var vm = Wtm.CreateVM<UID_Test.ViewModel._Admin.FrameworkUserVMs.FrameworkUserListVM>();
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
        public IActionResult FrameworkUserExportExcel(UID_Test.ViewModel._Admin.FrameworkUserVMs.FrameworkUserSearcher searcher)
        {
            var vm = Wtm.CreateVM<UID_Test.ViewModel._Admin.FrameworkUserVMs.FrameworkUserListVM>();
            vm.Searcher = searcher;
            vm.SearcherMode = ListVMSearchModeEnum.Export;
            return vm.GetExportData();
        }

        [ActionDescription("Sys.CheckExport")]
        [HttpPost("[action]")]
        public IActionResult FrameworkUserExportExcelByIds(string[] ids)
        {
            var vm = Wtm.CreateVM<UID_Test.ViewModel._Admin.FrameworkUserVMs.FrameworkUserListVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = new List<string>(ids);
                vm.SearcherMode = ListVMSearchModeEnum.CheckExport;
            }
            return vm.GetExportData();
        }
    
    }
}


