﻿using System.ComponentModel.DataAnnotations;

namespace TestMediateur.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
    }
}
