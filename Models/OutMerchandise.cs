using System;
using System.ComponentModel.DataAnnotations;

namespace 管理系统.Models
{
    [Display(Name = "出库")]
    public class OutMerchandise
    {
        [Key]
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "商品编码")]
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "商品名称")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "单位")]
        public string Unit { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "出库数")]
        public int OrderNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "领料")]
        public int PickingNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "SN")]
        public string SN { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "商品条码")]
        public string BarCode { get; set; }


    }
}
