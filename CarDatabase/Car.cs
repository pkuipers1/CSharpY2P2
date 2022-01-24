using System;
using System.Collections.Generic;
using System.Text;

namespace CarDatabase
{
    public abstract class Car
    {
        protected string brand;
        protected string model;
        protected string year;

        protected string information;

        protected Car(string aBrand, string aModel, string aYear)
        {
            brand = aBrand;
            model = aModel;
            year = aYear;
        }

        public abstract string GetInformation();
    }
}
