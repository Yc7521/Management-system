using System;
namespace 管理系统.Models
{
    public class BuyMerchandise_Merchandise
    {
        [Key]
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "商品编码")]
        public string CommodityCode{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "商品名称")]
        public string CommodityName{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "单位")]
        public string Unit{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "订货数")]
        public int OrderNum{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "入库数")]
        public int InboundNum{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [Range(0, int.MaxValue, ErrorMessage = "请输入有效的整数")]
        [Display(Name = "余数")]
        public int Remainder{ get; set;}

        
    }
}
