using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace AUCTION2.Models
{
    public class Auctionproducts
    { 
        
        
        public string Id { get; set; } 
        public string Title { get; set; }
            public string Description { get; set; }
             public string ImageUrl { get; set; }
             public DateTime StartTime { get; set; }
             public DateTime EndTime { get; set; }
             public decimal StartPrice { get; set; }
             public decimal? CurrentPrice { get; set; }
             
    }
}