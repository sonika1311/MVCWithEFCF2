using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWithEFCF2.Models
{
    public class CompanyDBInitialiser : DropCreateDatabaseIfModelChanges<CompanyDBContext>
    {
    }
}