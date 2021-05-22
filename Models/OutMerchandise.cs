using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace 管理系统.Models
{
    public class OutMerchandise
    {
        
        [Key]
        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "出库单编号")]
        public string OutboundOrder{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "客户")]
        public string Client{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "经办")]
        public string Handle{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "发货方式")]
        public string DeliveryMethod{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "日期")]
        public DateTime Date{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "类型")]
        public string Type{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "经手人")]
        public string HandleMan{ get; set;}

        [Required(ErrorMessage = "{0} 不能为空")]
        [DataType(DataType.Text)]
        [Display(Name = "说明")]
        public string Explain{ get; set;}

        [Display(Name = "商品明细")]
        public List<OutMerchandise_Merchandise> CommodityDetails{ get; set;}

        
    }
}
