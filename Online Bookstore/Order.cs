using Online_Bookstore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Online_Bookstore
{
    public class Order
    {
        public Book Book { get; private set; }
        public Reader Reader { get; private set; }
        public OrderType Type { get; private set; }
        public DateTime Date { get; private set; }

        public Order(Book book, Reader reader, OrderType type, DateTime date)
        {
            this.Book = book;
            this.Reader = reader;
            this.Type = type;
            this.Date = date;
        }


        public char GetOrderType()
        {
            bool isPurchase = Type == OrderType.Purchase;
            if (isPurchase)
            {
                return 'P';
            }
            else
            {
                return 'R';
            }
        }



        public enum OrderType
        {
            Purchase,
            Rent
        }
    }
}


 