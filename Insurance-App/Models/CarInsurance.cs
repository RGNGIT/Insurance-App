using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_App.Models
{
    public class CarInsurance : InsuranceDocument
    {
        public string CarMark { get; set; }

        public CarInsurance(string CarMark)
        {
            this.CarMark = CarMark;
        }

    }
}
