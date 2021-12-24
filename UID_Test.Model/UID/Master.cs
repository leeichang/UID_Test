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
    /// 主檔
    /// </summary>
	[Table("Masters")]
    [Display(Name = "_Model.Master")]
    public class Master : BasePoco,IPersistPoco
    {
        [Display(Name = "_Model._Master._Imp_lno")]
        [StringLength(20, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public string Imp_lno { get; set; }
        [Display(Name = "_Model._Master._Vendorid")]
        [StringLength(10, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public string Vendorid { get; set; }
        [Display(Name = "_Model._Master._Card_No")]
        [StringLength(20, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Card_No { get; set; }
        [Display(Name = "_Model._Master._Cust_PartNo")]
        [StringLength(40, ErrorMessage = "Validate.{0}stringmax{1}")]
        public string Cust_PartNo { get; set; }
        [Display(Name = "明細")]
        [InverseProperty("Master")]
        public List<Detail> Detail_Master { get; set; }
        [Display(Name = "_Model._Master._IsValid")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public bool IsValid { get; set; } = true;
	}

}
