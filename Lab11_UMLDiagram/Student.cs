using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UMLDiagram
{
    class Student: Person
    {
        #region fields

        private string Program;
        private int Year;
        private double Fee;

        #endregion

        #region properties
        public string SProgram
        {
            get
            {
                return Program;
            }

            set
            {
                Program = value;
            }
        }

        public int SYear
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }

        public double SFee
        {
            get
            {
                return Fee;
            }

            set
            {
                Fee = value;
            }
        }

        #endregion

        #region constructors

        public Student()
        {
            PName = "";
            PAddress = "";
            Program = "";
            Year = 0;
            Fee = 0.00;
        }

        public Student(string nameInput, string addressInput, string programInput, int yearInput, double feeInput)
        {
            PName = nameInput;
            PAddress = addressInput;
            Program = programInput;
            Year = yearInput;
            Fee = feeInput;
        }
        #endregion

        #region method override

        public override string ToString()
        {
            return (PName + ", " + PAddress + "," + SProgram + "," + SYear + "," + SFee);
        }
        #endregion

    }
}
