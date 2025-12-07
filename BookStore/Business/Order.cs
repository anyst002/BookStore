using BookStore.Data;
using BookStore.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.ComponentModel;

namespace BookStore.Business
{
    public class Order
    {
        public static readonly decimal taxPer = 0.05m;

        public long ordNum { get; init; }
        private readonly string storeId;
        private readonly OrderRepository repo;
        public BindingList<OrderItem> cart {  get; init; }
        public string payTerms { get; set; }

        public Order(string storeId)
        {
            repo = new OrderRepository();
            ordNum = repo.GetOrderNum(storeId);
            this.storeId = storeId;
            cart = new BindingList<OrderItem>();
            payTerms = "";
        }

        public void AddItem(OrderItem item)
        {
            int index = FindEntry(item);

            if (index == -1)
            {
                cart.Add(item);
            }
            else
            {
                short newQty = (short)(item.Qty + cart[index].Qty); //should check for integer overflow TODO
                UpdateItemQuantity(item, newQty);
            }
        }

        public void UpdateItem(OrderItem item)
        {
            int index = FindEntry(item);
            cart[index] = item;
        }

        public void UpdateItemQuantity(OrderItem item, short qty)
        {
            OrderItem newItem = new OrderItem(item.TitleId
                    , item.Title
                    , item.Price
                    , qty
                    , item.AuName
                    , item.PubName
                    , item.PubDate);
            UpdateItem(newItem);
        }

        public void RemoveItem(OrderItem item)
        {
            int index = FindEntry(item);
            cart.RemoveAt(index);
        }

        private int FindEntry(OrderItem key)
        {
            foreach (OrderItem item in cart)
            {
                if (item.TitleId == key.TitleId) return cart.IndexOf(item);
            }
            return -1;
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0.00m;
            foreach (OrderItem item in cart)
            {
                subtotal += Convert.ToDecimal(item.Price) * item.Qty;
            }
            return subtotal;
        }

        public void PlaceOrder()
        {
            if (cart.IsNullOrEmpty() || string.IsNullOrWhiteSpace(payTerms)) return;

            foreach (OrderItem item in cart)
            {
                Sales sale = ToSale(item);
                repo.InsertSale(sale);
            }
        }

        private Sales ToSale(OrderItem item)
        {
            Sales sale = new Sales(storeId
                , ordNum
                , DateTime.Today
                , item.Qty
                , payTerms
                , item.TitleId);

            return sale;
        }
    }
}
