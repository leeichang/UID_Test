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
    public partial class MasterListVM : BasePagedListVM<Master_View, MasterSearcher>
    {
        
        protected override IEnumerable<IGridColumn<Master_View>> InitGridHeader()
        {
            return new List<GridColumn<Master_View>>{
                
                this.MakeGridHeader(x => x.Imp_lno),
                this.MakeGridHeader(x => x.Vendorid),
                this.MakeGridHeader(x => x.Card_No),
                this.MakeGridHeader(x => x.Cust_PartNo),
                this.MakeGridHeader(x => x.CreateTime),
                this.MakeGridHeader(x => x.UpdateTime),
                this.MakeGridHeader(x => x.CreateBy),
                this.MakeGridHeader(x => x.UpdateBy),
                this.MakeGridHeader(x => x.IsValid),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Master_View> GetSearchQuery()
        {
            var query = DC.Set<Master>()
                
                .CheckContain(Searcher.Imp_lno, x=>x.Imp_lno)
                .CheckContain(Searcher.Vendorid, x=>x.Vendorid)
                .CheckContain(Searcher.Card_No, x=>x.Card_No)
                .CheckContain(Searcher.Cust_PartNo, x=>x.Cust_PartNo)
                .CheckBetween(Searcher.CreateTime?.GetStartTime(), Searcher.CreateTime?.GetEndTime(), x => x.CreateTime, includeMax: false)
                .CheckBetween(Searcher.UpdateTime?.GetStartTime(), Searcher.UpdateTime?.GetEndTime(), x => x.UpdateTime, includeMax: false)
                .CheckContain(Searcher.CreateBy, x=>x.CreateBy)
                .CheckContain(Searcher.UpdateBy, x=>x.UpdateBy)

                .Select(x => new Master_View
                {
				    ID = x.ID,
                    
                    Imp_lno = x.Imp_lno,
                    Vendorid = x.Vendorid,
                    Card_No = x.Card_No,
                    Cust_PartNo = x.Cust_PartNo,
                    CreateTime = x.CreateTime,
                    UpdateTime = x.UpdateTime,
                    CreateBy = x.CreateBy,
                    UpdateBy = x.UpdateBy,
                    IsValid = x.IsValid,

                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Master_View: Master
    {
        

    }

}