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
    public partial class DetailListVM : BasePagedListVM<Detail_View, DetailSearcher>
    {
        
        protected override IEnumerable<IGridColumn<Detail_View>> InitGridHeader()
        {
            return new List<GridColumn<Detail_View>>{
                
                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Detail_View> GetSearchQuery()
        {
            var query = DC.Set<Detail>()
                
                .Select(x => new Detail_View
                {
				    ID = x.ID,
                    
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Detail_View: Detail
    {
        
    }

}