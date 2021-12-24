
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
    public partial class DetailMasterDetailListVM2 : BasePagedListVM<Detail, DetailDetailSearcher2>
    {
        
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
            };
        }
 
        protected override IEnumerable<IGridColumn<Detail>> InitGridHeader()
        {
            return new List<GridColumn<Detail>>{
                
                this.MakeGridHeader(x => x.Seq).SetTitle(Localizer["Page.序號"].Value),
                this.MakeGridHeader(x => x.If_Repeated).SetTitle(Localizer["Page.是否重複"].Value),
                this.MakeGridHeader(x => x.Repeate_No).SetTitle(Localizer["Page.重複次數"].Value),
                this.MakeGridHeader(x => x.CreateTime).SetTitle(Localizer["_Admin.CreateTime"].Value),
                this.MakeGridHeader(x => x.UpdateTime).SetTitle(Localizer["_Admin.UpdateTime"].Value),
                this.MakeGridHeader(x => x.CreateBy).SetTitle(Localizer["_Admin.CreateBy"].Value),
                this.MakeGridHeader(x => x.UpdateBy).SetTitle(Localizer["_Admin.UpdateBy"].Value),

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

    public partial class DetailDetailSearcher2 : BaseSearcher
    {
        
        [Display(Name = "_Model._Detail._Master")]
        public string MasterId { get; set; }
    }

}