using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{
    [SugarTable("Ship", TableDescription = "配送方式表")]
    public partial class Ship
    {
        [Display(Name = "序列")]
        [SugarColumn(ColumnDescription = "序列", IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "請輸入{0}")]
        public System.Int32 Id { get; set; }

        [Display(Name = "訂單編號")]
        [SugarColumn(ColumnDescription = "訂單編號")]
        [Required(ErrorMessage = "請輸入{0}")]
        public System.Int32 OrderId { get; set; }

        [Display(Name = "配送方式名稱")]
        [SugarColumn(ColumnDescription = "配送方式名稱")]
        [Required(ErrorMessage = "請輸入{0}")]
        [StringLength(50, ErrorMessage = "【{0}】不能超過{1}字符長度")]
        public System.String Name { get; set; }

        // 其他屬性根據需要自行調整...

        [Display(Name = "地址")]
        [SugarColumn(ColumnDescription = "地址")]
        public System.String Address { get; set; }

        [Display(Name = "城市")]
        [SugarColumn(ColumnDescription = "城市")]
        public System.String City { get; set; }

        [Display(Name = "州")]
        [SugarColumn(ColumnDescription = "州")]
        public System.String State { get; set; }

        [Display(Name = "國家")]
        [SugarColumn(ColumnDescription = "國家")]
        public System.String Country { get; set; }

        [Display(Name = "郵遞區號")]
        [SugarColumn(ColumnDescription = "郵遞區號")]
        public System.String Zip { get; set; }

        [Display(Name = "電話")]
        [SugarColumn(ColumnDescription = "電話")]
        public System.String Phone { get; set; }

        [Display(Name = "電子郵件")]
        [SugarColumn(ColumnDescription = "電子郵件")]
        public System.String Email { get; set; }

        [Display(Name = "配送方式")]
        [SugarColumn(ColumnDescription = "配送方式")]
        public System.String ShippingMethod { get; set; }

        [Display(Name = "配送狀態")]
        [SugarColumn(ColumnDescription = "配送狀態")]
        public System.String ShippingStatus { get; set; }

        [Display(Name = "追蹤號碼")]
        [SugarColumn(ColumnDescription = "追蹤號碼")]
        public System.String TrackingNumber { get; set; }
    }
}
