using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using UID_Test.Model;
using UID_Test.ViewModel.UID.DetailVMs;
using UID_Test.Model.UID;


namespace UID_Test.UID.Controllers
{
    [AuthorizeJwtWithCookie]
    public partial class DetailController : BaseApiController
    {
            
    }
}


