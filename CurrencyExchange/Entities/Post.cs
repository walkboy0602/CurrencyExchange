using CurrencyExchange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CurrencyExchange.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string currencyFrom { get; set; }
        public string currenyTo { get; set; }
        public int Amount { get; set; }
        public double Rate { get; set; }
        public string Location { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}