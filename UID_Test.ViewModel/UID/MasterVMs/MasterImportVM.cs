
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using UID_Test.Model.UID;
using UID_Test.Model;

namespace UID_Test.ViewModel.UID.MasterVMs
{
    public partial class MasterTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._Master._Imp_lno")]
        public ExcelPropety Imp_lno_Excel = ExcelPropety.CreateProperty<Master>(x => x.Imp_lno);
        [Display(Name = "_Model._Master._Vendorid")]
        public ExcelPropety Vendorid_Excel = ExcelPropety.CreateProperty<Master>(x => x.Vendorid);
        [Display(Name = "_Model._Master._Card_No")]
        public ExcelPropety Card_No_Excel = ExcelPropety.CreateProperty<Master>(x => x.Card_No);
        [Display(Name = "_Model._Master._Cust_PartNo")]
        public ExcelPropety Cust_PartNo_Excel = ExcelPropety.CreateProperty<Master>(x => x.Cust_PartNo);
        [Display(Name = "_Model._Master._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<Master>(x => x.CreateTime, true);
        [Display(Name = "_Model._Master._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<Master>(x => x.UpdateTime, true);
        [Display(Name = "_Model._Master._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<Master>(x => x.CreateBy);
        [Display(Name = "_Model._Master._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<Master>(x => x.UpdateBy);
        [Display(Name = "_Model._Master._IsValid")]
        public ExcelPropety IsValid_Excel = ExcelPropety.CreateProperty<Master>(x => x.IsValid);

	    protected override void InitVM()
        {
            
        }

    }

    public class MasterImportVM : BaseImportVM<MasterTemplateVM, Master>
    {
        //import

    }

}