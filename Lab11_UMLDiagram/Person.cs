using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UMLDiagram
{
    class Person
    {
        private string Name;
        private string Address;

        #region properties
        public string PName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }

        }

        public string PAddress
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }
        #endregion

        #region constructor

        public Person ()
        {
            Name = "";
            Address = "";
        }


        public Person(string nameInput,
            string addressInput)
        {
            Name = nameInput;
            Address = addressInput;
        }


        #endregion

        #region method override

        public override string ToString()
        {
            return (PName + ", " + PAddress);
        }

        #endregion
    }
}
