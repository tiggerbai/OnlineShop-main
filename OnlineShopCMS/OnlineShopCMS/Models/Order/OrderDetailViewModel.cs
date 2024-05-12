using System.Collections.Generic;
using System;

namespace OnlineShopCMS.Models
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }        //訂單建立時間

        public string UserId { get; set; }             //付款者ID
        public string UserName { get; set; }           //付款者帳號

        public string ReceiverName { get; set; }       //收貨者姓名
        public string ReceiverAddress { get; set; }     //收貨者地址
        public string ReceiverPhone { get; set; }      //收貨者電話

        public int Total { get; set; }                 //訂單總額
        public List<OrderItem> OrderItem { get; set; } //訂單內容
        public bool IsPaid { get; set; }            //付款狀態
        public bool IsShipped { get; internal set; }
        public DateTime ShippingDate { get; set; }
        public List<OrderItem> OrderItems { get; internal set; }
    }
}
