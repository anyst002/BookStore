using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Order
    {
        public static readonly decimal tax = 0.05m;

        private readonly long ordNum;
        private readonly string storeId;
        private readonly OrderRepository repo;
        public List<(TitleSearchResult, short)> cart {  get; init; }
        public string payTerms { get; set; }

        public Order(string storeId)
        {
            repo = new OrderRepository();
            ordNum = repo.GetOrderNum(storeId);
            this.storeId = storeId;
            cart = new List<(TitleSearchResult, short)>();
            payTerms = "";
        }

        public void AddItem(TitleSearchResult title, short qty)
        {
            int index = FindEntry(title);

            if (index == -1)
            {
                cart.Add((title, qty));
            }
            else
            {
                qty += cart[index].Item2;
                UpdateItem(title, qty);
            }
        }

        public void UpdateItem(TitleSearchResult title, short qty)
        {
            int index = FindEntry(title);
            cart[index] = (title, qty);
        }

        public void RemoveItem(TitleSearchResult title)
        {
            int index = FindEntry(title);
            cart.RemoveAt(index);
        }

        private int FindEntry(TitleSearchResult title)
        {
            foreach ((TitleSearchResult, short) entry in cart)
            {
                if (entry.Item1.TitleId == title.TitleId) return cart.IndexOf(entry);
            }
            return -1;
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0.00m;
            foreach ((TitleSearchResult, short) entry in cart)
            {
                subtotal += Convert.ToDecimal(entry.Item1.Price) * entry.Item2;
            }
            return subtotal;
        }

        public void PlaceOrder()
        {
            if (cart.IsNullOrEmpty() || String.IsNullOrWhiteSpace(payTerms)) return;

            foreach ((TitleSearchResult, short) entry in cart)
            {
                Sales sale = ToSale(entry);
                repo.InsertSale(sale);
            }
        }

        private Sales ToSale((TitleSearchResult, short) entry)
        {
            Sales sale = new Sales(storeId
                , ordNum
                , DateTime.Today
                , entry.Item2
                , payTerms
                , entry.Item1.TitleId);

            return sale;
        }
    }
}
