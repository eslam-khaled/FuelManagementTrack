using FuelManagementTrack.Business;
using FuelManagementTrack.DTO.BusinessDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuelManagementTrack.Controllers
{
    public class CompanyController : Controller
    {
        CompanyBusiness companyBusiness;
        public CompanyController()
        {
            companyBusiness = new CompanyBusiness();
        }

        public CompanyDTO CreateCompany(CompanyDTO companyDTO)
        {
            return companyBusiness.CreateCompany(companyDTO);
        }

    }
}
