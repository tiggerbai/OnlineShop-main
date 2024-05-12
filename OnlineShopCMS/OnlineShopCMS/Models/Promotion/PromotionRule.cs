using System.ComponentModel.DataAnnotations;

namespace OnlineShopCMS.Models
{
    public class PromotionRule
    {
        [Key]
        public int Id { get; set; }

        public int PromotionId { get; set; }
        public Promotion Promotion { get; set; }

        public string RuleType { get; set; }

        // 用於 BuyXGetY，表示買X的產品ID和送Y的產品ID

        public int ProductIdForX { get; set; }
        public int ProductIdForY { get; set; }

        // 用於 BuyXGetY 和 BuyOneGetOneFree，表示購買的數量X和贈送的數量Y
        public int X { get; set; }
        public int Y { get; set; }
        public int ProductForXId { get; set; }
        public int ProductForYId { get; set; }


        // 指向產品的導航屬性，僅在需要時填入

        public Product ProductForX { get; set; }
        public Product ProductForY { get; set; }

        public decimal Threshold { get; set; }



    }

}
