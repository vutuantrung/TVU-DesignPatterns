using EntitesCL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesCL
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID( int id )
        {
            return new Institution
            {
                InstitutionID = id,
                Name = "Demo Institution",
                Address = "Demo Address",
                Telephone = "0123456789"
            };
        }
    }
}
