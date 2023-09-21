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

        public override string ShortDefinition { get; } = "случай с автомобилем";

        public CarInsurance(string CarMark)
        {
            this.CarMark = CarMark;
        }

    }
}
