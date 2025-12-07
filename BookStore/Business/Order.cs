using static BookStore.Data.Repository;
using BookStore.Entities;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;

namespace BookStore.Business
{
    public class Order
    {
        public static readonly decimal taxPer = 0.05m;

        private readonly string _storeId;

        public long OrdNum { get; init; }
        public string PayTerms { get; set; }
        public BindingList<OrderItem> Cart { get; init; }

        public Order(string storeId)
        {
            OrdNum = GetOrderNum(storeId);

            _storeId = storeId;
            Cart = new BindingList<OrderItem>();
            PayTerms = "";
        }

        public void AddItem(OrderItem item)
        {
            int index = FindEntry(item);

            if (index == -1)
            {
                Cart.Add(item);
            }
            else
            {
                short newQty = (short)(item.Qty + Cart[index].Qty); //should check for integer overflow TODO
                UpdateItemQuantity(item, newQty);
            }
        }

        public void AddTitleSummary(object rawData, short qty)
        {
            TitleSummary titleSummary = (TitleSummary)rawData;
            OrderItem item = new OrderItem(titleSummary.TitleId
                , titleSummary.Title
                , titleSummary.Price
                , qty
                , titleSummary.AuName
                , titleSummary.PubName
                , titleSummary.PubDate);

            AddItem(item);
        }

        public void UpdateItem(OrderItem item)
        {
            int index = FindEntry(item);
            Cart[index] = item;
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

        public void RemoveItem(object rawData)
        {
            OrderItem item = (OrderItem)rawData;
            int index = FindEntry(item);
            Cart.RemoveAt(index);
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0.00m;
            foreach (OrderItem item in Cart)
            {
                subtotal += Convert.ToDecimal(item.Price) * item.Qty;
            }
            return subtotal;
        }

        public decimal GetTax()
        {
            return GetSubtotal() * taxPer;
        }

        public decimal GetTotal()
        {
            decimal subtotal = GetSubtotal();
            return subtotal + (subtotal * taxPer);
        }

        public static List<TitleSummary> GetSearchResults(string partialTitle)
        {
            return GetTitlesByPartialTitle(partialTitle);
        }

        public void PlaceOrder()
        {
            if (Cart.IsNullOrEmpty() || string.IsNullOrWhiteSpace(PayTerms)) return;

            foreach (OrderItem item in Cart)
            {
                Sales sale = ToSale(item);
                InsertSale(sale);
            }
        }

        private int FindEntry(OrderItem key)
        {
            foreach (OrderItem item in Cart)
            {
                if (item.TitleId == key.TitleId) return Cart.IndexOf(item);
            }
            return -1;
        }

        private Sales ToSale(OrderItem item)
        {
            Sales sale = new Sales(_storeId
                , OrdNum
                , DateTime.Today
                , item.Qty
                , PayTerms
                , item.TitleId);

            return sale;
        }
    }
}
