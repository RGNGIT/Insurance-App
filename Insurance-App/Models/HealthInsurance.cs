using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_App.Models
{
    public class HealthInsurance : InsuranceDocument
    {
        public string SNILS { get; set; }

        public override string ShortDefinition { get; } = "случай со здоровьем";

        public HealthInsurance(string SNILS)
        {
            this.SNILS = SNILS;
        }
    }
}
