﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApp.Data
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
