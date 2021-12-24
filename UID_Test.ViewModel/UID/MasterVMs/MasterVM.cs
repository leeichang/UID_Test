using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;

using UID_Test.ViewModel.UID.DetailVMs;
using UID_Test.Model.UID;
using UID_Test.Model;
namespace UID_Test.ViewModel.UID.MasterVMs
{
    public partial class MasterVM : BaseCRUDVM<Master>
    {
        

        public MasterVM()
        {
            
            SetInclude(x => x.Detail_Master);

        }

        protected override void InitVM()
        {
            

        }

        public override DuplicatedInfo<Master> SetDuplicatedCheck()
        {
            return null;

        }

        public override async Task DoAddAsync()        
        {
            
            await base.DoAddAsync();

        }

        public override async Task DoEditAsync(bool updateAllFields = false)
        {
            
            await base.DoEditAsync();

        }

        public override async Task DoDeleteAsync()
        {
            await base.DoDeleteAsync();

        }
    }
}
