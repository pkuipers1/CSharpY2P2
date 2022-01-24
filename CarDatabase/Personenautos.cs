using System;
using System.Collections.Generic;
using System.Text;

namespace CarDatabase
{
    public class Personenautos : Car
    {
        private string type = "personenauto";

        public Personenautos(string aBrand, string aModel, string aYear) : base(aBrand, aModel, aYear)
        {
            this.brand = aBrand;
            this.model = aModel;
            this.year = aYear;
        }

        public override string GetInformation()
        {
            information = "Type: " +  type + ", Brand: " + brand + ", Model: " + model + ", Year: " + year;
            return information;
        }
    }
}
