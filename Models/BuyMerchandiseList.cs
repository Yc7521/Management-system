using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace 管理系统.Models
{
    [Display(Name = "入库单")]
    public class BuyMerchandiseList
    {
        [Key]
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "订单编号")]
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Date)]
        [Display(Name = "开单日期")]
        public DateTime BillingDate { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "库房")]
        public string Storehouse { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "往来单位")]
        public string ExchangeCompany { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "经办人")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "确认")]
        public bool Confirm { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Date)]
        [Display(Name = "确认时间")]
        public DateTime ConfirmDate { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Date)]
        [Display(Name = "到货日期")]
        public DateTime ArrivalDate { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Currency)]
        [Display(Name = "合同金额")]
        public decimal Contract { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Currency)]
        [Display(Name = "预付金额")]
        public decimal Prepaid { get; set; }

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "操作员")]
        public string Operator { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "说明")]
        public string Explain { get; set; }

        [Display(Name = "商品明细")]
        public List<BuyMerchandise> CommodityDetails { get; set; }
    }
}
