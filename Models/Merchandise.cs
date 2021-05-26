using System;
using System.ComponentModel.DataAnnotations;

namespace 管理系统.Models
{
    [Display(Name = "商品")]
    public class Merchandise
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
        public string Company { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "库存总数")]
        public int StockNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "财务库存")]
        public int FinancialStock { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "领料数")]
        public int PickingNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "订货数")]
        public int OrderNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "可销数")]
        public int PinableNum { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Currency)]
        [Display(Name = "成本价")]
        public decimal CostPrice { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Currency)]
        [Display(Name = "库存金额")]
        public decimal StockAmount { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "件数")]
        public int Total { get; set; }
    }
}
