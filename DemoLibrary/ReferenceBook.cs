﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class ReferenceBook : IBook
    {
        public string Author { get; set; }
        public string LibraryID { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }

    }
}
