﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.model
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
         
        List<User> Users { get; } = [];
 

    }
}
