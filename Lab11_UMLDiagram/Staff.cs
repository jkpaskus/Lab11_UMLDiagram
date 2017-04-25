using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UMLDiagram
{
    class Staff: Person
    {
        #region fields

        private string School;
        private double Pay;

        #endregion

        #region properties
        public string StSchool
        {
            get
            {
                return School;
            }

            set
            {
                School = value;
            }
        }

        public double StPay
        {
            get
            {
                return Pay;
            }

            set
            {
                Pay = value;
            }
        }

        #endregion

        #region constructors

        public Staff()
        {
            PName = "";
            PAddress = "";
            School = "";
            Pay = 0;
        }

        public Staff(string nameInput, string addressInput, string schoolInput, double payInput)
        {
            PName = nameInput;
            PAddress = addressInput;
            School = schoolInput;
            Pay = payInput;
        }
        #endregion

        #region method override

        public override string ToString()
        {
            return (PName + ", " + PAddress + "," + StSchool + "," + StPay);
        }

        #endregion
    }
}
