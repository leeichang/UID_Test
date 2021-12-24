
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using UID_Test.Model.UID;
using UID_Test.Model;

namespace UID_Test.ViewModel.UID.DetailVMs
{
    public partial class DetailBatchVM : BaseBatchVM<Detail, Detail_BatchEdit>
    {
        public DetailBatchVM()
        {
            ListVM = new DetailListVM();
            LinkedVM = new Detail_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Detail_BatchEdit : BaseVM
    {

        
        protected override void InitVM()
        {
           
        }
    }

}