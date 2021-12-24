﻿using Microsoft.AspNetCore.Mvc.Rendering;
using ParfumeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.ViewModels
{
    public class ParfumeVM
    {
        public Parfume Parfume { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
