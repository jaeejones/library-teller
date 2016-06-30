using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD: Media // to connect Dvd to it's parent Media

    {
        public override int RentalLength
        {
            get
            {
                return 7;
            }
            /// dummy set method- doesn't do anything
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void PrintMediaDetails()
        {
            throw new NotImplementedException();
        }

        public override DateTime ReturnDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
