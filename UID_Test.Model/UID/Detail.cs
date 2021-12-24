using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;
using UID_Test.Model;
using UID_Test.Model.UID;

namespace UID_Test.Model.UID
{
    /// <summary>
    /// 明細
    /// </summary>
	[Table("Details")]
    [Display(Name = "_Model.Detail")]
    public class Detail : BasePoco,IPersistPoco
    {
        [Display(Name = "_Model._Detail._Master")]
        public Master Master { get; set; }
        [Display(Name = "_Model._Detail._Master")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public Guid? MasterId { get; set; }
        [Display(Name = "_Model._Detail._Seq")]
        [Range(1,20,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? Seq { get; set; }
        [Display(Name = "_Model._Detail._If_Repeated")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public bool? If_Repeated { get; set; }
        [Display(Name = "_Model._Detail._Repeate_No")]
        [Range(0,5000,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? Repeate_No { get; set; }
        [Display(Name = "_Model._Detail._IsValid")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public bool IsValid { get; set; } = true;
	}

}
