﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchShop.Models.ViewModels
{
    public class EditProductView : CreateProductView
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
    }
}
