using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_App.Models
{
    public class AssetInsurance : InsuranceDocument
    {
        public string Address { get; set; }

        public AssetInsurance(string Address) 
        {
            this.Address = Address;
        }

    }
}
