using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using UID_Test.Model;

namespace UID_Test.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserListVM : BasePagedListVM<FrameworkUser_View, FrameworkUserSearcher>
    {
        
        protected override IEnumerable<IGridColumn<FrameworkUser_View>> InitGridHeader()
        {
            return new List<GridColumn<FrameworkUser_View>>{
                
                this.MakeGridHeader(x => x.ITCode),
                this.MakeGridHeader(x => x.Name),
                this.MakeGridHeader(x => x.Gender),
                this.MakeGridHeader(x => x.CellPhone),
                this.MakeGridHeader(x => x.FrameworkRoleFrameworkUser_MT_WtmName_view),
                this.MakeGridHeader(x => x.FrameworkGroupFrameworkUser_MT_WtmName_view),
                this.MakeGridHeader(x => x.IsValid),
                this.MakeGridHeader(x => x.PhotoId),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<FrameworkUser_View> GetSearchQuery()
        {
            var query = DC.Set<FrameworkUser>()
                
                .CheckContain(Searcher.ITCode, x=>x.ITCode)
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckEqual(Searcher.IsValid, x=>x.IsValid)

                .Select(x => new FrameworkUser_View
                {
				    ID = x.ID,
                    
                    ITCode = x.ITCode,
                    Name = x.Name,
                    Gender = x.Gender,
                    CellPhone = x.CellPhone,
                    FrameworkRoleFrameworkUser_MT_WtmName_view = DC.Set<FrameworkUserRole>().Where(y => y.UserCode == x.ITCode)
                        .Join(DC.Set<FrameworkRole>(), ur => ur.RoleCode, role => role.RoleCode, (ur, role) => role.RoleName).ToSepratedString(null, ","),
                    FrameworkGroupFrameworkUser_MT_WtmName_view = DC.Set<FrameworkUserGroup>().Where(y => y.UserCode == x.ITCode)
                        .Join(DC.Set<FrameworkGroup>(), ug => ug.GroupCode, group => group.GroupCode, (ug, group) => group.GroupName).ToSepratedString(null, ","),
                    IsValid = x.IsValid,
                    PhotoId = x.PhotoId,

                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class FrameworkUser_View: FrameworkUser
    {
        
        [Display(Name = "_Model.FrameworkRole")]
        public string FrameworkRoleFrameworkUser_MT_WtmName_view { get; set; }
        [Display(Name = "_Model.FrameworkGroup")]
        public string FrameworkGroupFrameworkUser_MT_WtmName_view { get; set; }

    }

}