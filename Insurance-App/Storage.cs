using Insurance_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_App
{
    static class Storage
    {
        public static List<InsuranceDocument> InsuranceDocuments = new();
        public static List<InsuranceDocument> ExpiredDocuments = new();
    }
}
