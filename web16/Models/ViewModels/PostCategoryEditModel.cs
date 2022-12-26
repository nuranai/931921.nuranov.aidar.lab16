﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web16.Models.ViewModels
{
    public class PostCategoryEditModel
    {
        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
