using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class DVD : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string AvailableCopies { get; set; }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public void Return()
        {
            throw new NotImplementedException();
        }
    }
}
