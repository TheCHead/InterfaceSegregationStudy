﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryID { get; set; }
        public string Title { get; set; }

        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckoutDurationInDays { get; set; }


        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }


        public void CheckIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueTime()
        {
            return BorrowDate.AddDays(CheckoutDurationInDays);
        }
    }
}
