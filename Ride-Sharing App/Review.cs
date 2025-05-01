using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Review
    {  
        public int Id;
        public String ReviewText { get; set; }
         public DateTime ReviewDate { get; set; }
         public Passenger Reviewer { get; set; }  
        public Passenger Reviewed { get; set; }

        public Review(int id, String reviewtext,  DateTime reviewdate, Passenger reviewer, Passenger reviewed)
        {
            Id = id;
            ReviewText = reviewtext;
             ReviewDate = reviewdate;
            Reviewer = reviewer;
            Reviewed = reviewed;
        }
    }
    }

 