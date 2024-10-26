using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.AddressBook
{
      public class Contact
      {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String address { get; set; }
            public String city { get; set; }
            public String state { get; set; }
            public String zip { get; set; }
            public String phonenumber { get; set; }
            public String email { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Contact otherContact)
            {
                return firstName.Equals(otherContact.firstName, StringComparison.OrdinalIgnoreCase) &&
                       lastName.Equals(otherContact.lastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

      }
}

