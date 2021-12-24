
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using UID_Test.Model.UID;
using UID_Test.Model;
namespace UID_Test.ViewModel.UID.DetailVMs
{
    public partial class DetailMasterDetailListVM1 : BasePagedListVM<Detail, DetailDetailSearcher1>
    {
        
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Detail", GridActionStandardTypesEnum.AddRow, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Detail", GridActionStandardTypesEnum.RemoveRow, "删除","", dialogWidth: 800),
            };
        }
 
        protected override IEnumerable<IGridColumn<Detail>> InitGridHeader()
        {
            return new List<GridColumn<Detail>>{
                
                this.MakeGridHeader(x => x.Seq).SetEditType(EditTypeEnum.TextBox).SetTitle(Localizer["Page.序號"].Value),
                this.MakeGridHeader(x => x.If_Repeated).SetEditType(EditTypeEnum.ComboBox,Utils.GetBoolCombo(BoolComboTypes.YesNo, selectText:Wtm.Localizer?["Sys.PleaseSelect"])).SetTitle(Localizer["Page.是否重複"].Value),
                this.MakeGridHeader(x => x.Repeate_No).SetEditType(EditTypeEnum.TextBox).SetTitle(Localizer["Page.重複次數"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Detail> GetSearchQuery()
        {
                
            var id = (Guid?)Searcher.MasterId.ConvertValue(typeof(Guid?));
            if (id == null)
                return new List<Detail>().AsQueryable().OrderBy(x => x.ID);
            var query = DC.Set<Detail>()
                .Where(x => id == x.MasterId)

                .OrderBy(x => x.ID);
            return query;
        }

    }

    public partial class DetailDetailSearcher1 : BaseSearcher
    {
        
        [Display(Name = "_Model._Detail._Master")]
        public string MasterId { get; set; }
    }

}