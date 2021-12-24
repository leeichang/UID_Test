
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using UID_Test.Model.UID;
using UID_Test.Model;
namespace UID_Test.ViewModel.UID.MasterVMs
{
    public partial class MasterSearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._Master._Imp_lno")]
        public string Imp_lno { get; set; }
        [Display(Name = "_Model._Master._Vendorid")]
        public string Vendorid { get; set; }
        [Display(Name = "_Model._Master._Card_No")]
        public string Card_No { get; set; }
        [Display(Name = "_Model._Master._Cust_PartNo")]
        public string Cust_PartNo { get; set; }
        [Display(Name = "_Model._Master._CreateTime")]
        public DateRange CreateTime { get; set; }
        [Display(Name = "_Model._Master._UpdateTime")]
        public DateRange UpdateTime { get; set; }
        [Display(Name = "_Model._Master._CreateBy")]
        public string CreateBy { get; set; }
        [Display(Name = "_Model._Master._UpdateBy")]
        public string UpdateBy { get; set; }

        protected override void InitVM()
        {
            
        }
    }

}