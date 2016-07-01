using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Media
    {
        public virtual string Title { get;  set; }
        public virtual string Length { get;  set; }
        public abstract int RentalLength { get; set; }
        protected DateTime RentedDate { get;  set; }
    
        
        public Media()
        {
            RentedDate = DateTime.Today;
        }
        
        public abstract void PrintMediaDetails()
        {
            Console.WriteLine("DVD {0}", tittle, lenght); // length is a method. 

            Console.WriteLine("Rented on: {0}",RentedDate);

            Console.WriteLine("Due on:{0}",ReturnDueDate())//what is Return Date called? A method
        }

        public abstract DateTime ReturnDueDate();

        public virtual void  SetRentedDate()
        {
            RentedDate = DateTime.Today; // This gets the current date and sticks it into the Rented Date policy
        }
    }
}
