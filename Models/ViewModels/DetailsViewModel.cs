﻿using System;

namespace ShopM4.Models.ViewModels
{
    public class DetailsViewModel
    {
        public Product Product { get; set; }
        public bool IsInCart { get; set; }


        // может быть конструктор и инициализация данных
        public DetailsViewModel()
        {
            Product = new Product();
        }
    }
}

