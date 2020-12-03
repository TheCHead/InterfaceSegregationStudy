using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    interface ILibraryItem
    {
        string Author { get; set; }
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckoutDurationInDays { get; set; }
        string LibraryID { get; set; }
        int Pages { get; set; }
        string Title { get; set; }

        void CheckIn();

        void CheckOut(string borrower);

        DateTime GetDueTime();
    }
}
