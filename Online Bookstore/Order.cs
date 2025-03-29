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
        private Book book;
        private Reader reader;
        private OrderType type;
        private DateTime date;

        public Order(Book book, Reader reader, OrderType type, DateTime date)
        {
            this.book = book;
            this.reader = reader;
            this.type = type;
            this.date = date;
        }


        public char GetOrderType()
        {
            bool isPurchase = type == OrderType.Purchase;
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


 