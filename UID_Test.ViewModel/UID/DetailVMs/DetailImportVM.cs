
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using UID_Test.Model.UID;
using UID_Test.Model;

namespace UID_Test.ViewModel.UID.DetailVMs
{
    public partial class DetailTemplateVM : BaseTemplateVM
    {
        
	    protected override void InitVM()
        {
            
        }

    }

    public class DetailImportVM : BaseImportVM<DetailTemplateVM, Detail>
    {
        //import

    }

}