using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GRM_APP.Models
{
    public class GeneralManager : IDisposable
    {
        GRMEntities context;
        public GeneralManager()
        {
            context = new GRMEntities();
            context.Database.Connection.Open();
          
        }
        public void Dispose()
        {
            context.Database.Connection.Close();
            context.Dispose();
        }
        public List<User> GetAllUsers()
        {
            return context.User.ToList();
        }

        public List<Company> GetAllCompanies()
        {
            return context.Company.ToList();
        }

        public List<Company> TopNineCompanies()
        {
           return context.Company.OrderByDescending(x => x.popularity).Take(9).ToList();
            
        }

        public void AddCompany(string Name, string About, string Logo, string Adrress, string Phone)
        {
            Company company = new Company();
            company.name = Name; company.about = About; company.logo = Logo; company.address = Adrress;
            company.phone = Phone;
            context.Company.Add(company);
            try
            {
                context.SaveChanges();
            }
            catch { }
        }

        public Company returnCompany(int companyId)
        {
            return context.Company.SingleOrDefault(x => x.id == companyId);
        }

        public void IncreasePopularity(Company company)
        {
            company.popularity++;
            try
            {
                context.SaveChanges();
            }
            catch { }

            
        }
    }
}