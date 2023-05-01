using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.cs
{
    // The ProductA1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularBike Product Belongs to the Bike product family
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }
}
