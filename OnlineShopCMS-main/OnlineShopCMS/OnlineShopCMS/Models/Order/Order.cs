using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlineShopCMS.Areas.Identity.Data;

namespace OnlineShopCMS.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }        //訂單建立時間

        public string UserId { get; set; }             //付款者ID
        public string UserName { get; set; }
        public OnlineShopUser User { get; set; }             // 付款者導航屬性

        public string ReceiverName { get; set; }       //收貨者姓名
        public string ReceiverAddress { get; set; }     //收貨者地址
        public string ReceiverPhone { get; set; }      //收貨者電話

        public int Total { get; set; }                 //訂單總額
        public List<OrderItem> OrderItems { get; set; } //訂單內容
        public bool IsPaid { get; set; }               //付款狀態
        public bool IsShipped { get; set; }            //出貨狀態
        public DateTime? ShippingDate { get; set; }
        public OrderStatus OrderStatus { get; set; }        //訂單狀態



    }


    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public int SubTotal { get; set; }



    }

    public class CartItem : OrderItem
    {
        public CartItem() { }
        public CartItem(OrderItem order)
        {
            this.OrderId = order.OrderId;
            this.ProductId = order.ProductId;
            this.Amount = order.Amount;
            this.SubTotal = order.SubTotal;
        }

        public Product product { get; set; }
        public string ImageSrc { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Paid,
        Shipped,
        Completed,
        Cancelled
    }
}
