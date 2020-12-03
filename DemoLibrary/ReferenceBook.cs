using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class ReferenceBook : ILibraryItem
    {
        public string Author { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckoutDurationInDays { get; set; }
        public string LibraryID { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }



        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueTime()
        {
            throw new NotImplementedException();
        }
    }
}
