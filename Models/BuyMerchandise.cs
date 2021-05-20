using System;
namespace 管理系统.Models
{
    public class BuyMerchandise
    {
        [Key]
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "订单编号")]
        public string Purchase_order{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "开单日期")]
        public DataTime Billing_date{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "库房")]
        public string Storehouse{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "往来单位")]
        public string Exchange_company{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "经办人")]
        public string Operator{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "确认")]
        public bool Confirm{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "确认时间")]
        public DataTime Confirm_date{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "到货日期")]
        public DataTime Arrival_date{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "合同金额")]
        public decimal Contract_value{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "预付金额")]
        public decimal Prepaid_amount{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "操作员")]
        public string Operator{ get; set;}
        
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DateType.Text)]
        [Display(Name = "说明")]
        public string Explain{ get; set;}
    }
}
