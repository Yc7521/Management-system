using System;
public class Stock
{
    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "商品编码")]
    public string Commodity_code{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "商品名称")]
    public string Commodity_name{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "单位")]
    public string company{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "库存总数")]
    public int Stock_num{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "财务库存")]
    public int Financial_stock{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "领料数")]
    public int Picking_num{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "订货数")]
    public int Order_num{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "可销数")]
    public int Pinable_num{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "成本价")]
    public decimal Cost_price{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "库存金额")]
    public decimal Stock_amount{ get; set;}

    [Required(ErrorMessage = "{0} 不能为空")]
    [DataType(DateType.Text)]
    [Display(Name = "件数")]
    public int Total{ get; set;}
    
}

