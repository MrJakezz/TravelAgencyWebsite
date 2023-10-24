using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ChangeToActive(int id)
        {
            throw new NotImplementedException();
        }

        public void ChangeToPassive(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetActivesListFromContactUs()
        {
            using (var context = new Context())
            {
                var values = context.ContactUss.Where(x => x.ContactUsStatus == true).ToList();

                return values;
            }
        }

        public List<ContactUs> GetPassivesListFromContactUs()
        {
            using (var context = new Context())
            {
                var values = context.ContactUss.Where(x => x.ContactUsStatus == false).ToList();

                return values;
            }
        }
    }
}
