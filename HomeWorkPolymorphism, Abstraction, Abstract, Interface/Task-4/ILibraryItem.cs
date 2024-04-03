using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal interface ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string AvailableCopies { get; set; }

        public void CheckOut();
        public void Return();
    }
}
