using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Magazine: Media
    {
        public override int RentalLength
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void PrintMediaDetails()
        {
            Console.WriteLine("Magazine {0} ({1})", Title, Length);

            +Console.WriteLine("Rented on: {0}", RentedDate);

            +Console.WriteLine("Due on {0}", ReturnDueDate());

           // throw new NotImplementedException();
        }

        public override DateTime ReturnDueDate()
        {
            return RentedDate.AddDays(RentalLength);
            //throw new NotImplementedException();
        }
    }
}
