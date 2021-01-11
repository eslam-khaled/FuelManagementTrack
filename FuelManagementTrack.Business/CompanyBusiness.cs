using FuelManagementTrack.DAL.BaseRepositories;
using FuelManagementTrack.DAL.Models;
using FuelManagementTrack.DTO.BusinessDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelManagementTrack.Business
{
    public class CompanyBusiness
    {
        BaseRepository<CompanyModel> BaseRepo;
        public CompanyBusiness()
        {
            BaseRepo = new BaseRepository<CompanyModel>();
        }

        public CompanyDTO CreateCompany(CompanyDTO companyDTO)
        {
            CompanyModel company = new CompanyModel()
            {
                id = companyDTO.id,
                CompanyName = companyDTO.CompanyName
            };

            company = BaseRepo.AddNew(company);

            companyDTO.CompanyName = company.CompanyName;
            companyDTO.id = company.id;

            return companyDTO;
        }
    }
}
