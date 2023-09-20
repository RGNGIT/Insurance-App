using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_App.Models
{
    public enum EInsuranceBillingPeriod 
    {
        Monthly,
        Quarterly,
        Annualy,
        Undefined
    }

    public abstract class InsuranceDocument
    {
        public string Id { get; set; }

        public EInsuranceBillingPeriod BillingPeriod { get; set; }
        public DateTime ValidUntil { get; set; }
        public float MaxSum { get; set; }
        public float Franchise { get; set; }

        public InsuranceDocument() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
