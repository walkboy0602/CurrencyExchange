using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CurrencyExchange.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        [Required]
        public string currencyFrom { get; set; }
        [Required]
        public string currenyTo { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string Location { get; set; }
    }
}