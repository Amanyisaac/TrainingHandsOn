    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Net.Mime.MediaTypeNames;

    namespace Online_Food_Delivery_App
    {
        public class Menu
        {
        public int Id { get; set; }                     
        public String Description { get; set; }
             public double Price { get; set; }
             public String Category { get; set; }
             public int Quantity { get; set; }
             public byte[] ImagesOfFoods { get; set; }           
             public Menu( int id,String description, double price, String category, byte [] imagesOfFoods, int quantity)
            {

            Id = id;
            Description = description;
                Price = price;
                Category = category;
                ImagesOfFoods = imagesOfFoods;
                Quantity = quantity;
             }
        }
    }
