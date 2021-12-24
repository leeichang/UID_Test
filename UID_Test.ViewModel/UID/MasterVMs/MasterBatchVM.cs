
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

namespace UID_Test.ViewModel.UID.MasterVMs
{
    public partial class MasterBatchVM : BaseBatchVM<Master, Master_BatchEdit>
    {
        public MasterBatchVM()
        {
            ListVM = new MasterListVM();
            LinkedVM = new Master_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Master_BatchEdit : BaseVM
    {

        
        [Display(Name = "_Model._Master._Imp_lno")]
        public string Imp_lno { get; set; }
        [Display(Name = "_Model._Master._Vendorid")]
        public string Vendorid { get; set; }
        [Display(Name = "_Model._Master._Card_No")]
        public string Card_No { get; set; }
        [Display(Name = "_Model._Master._Cust_PartNo")]
        public string Cust_PartNo { get; set; }

        protected override void InitVM()
        {
           
        }
    }

}