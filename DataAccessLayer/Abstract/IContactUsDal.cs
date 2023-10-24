using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactUsDal : IGenericDal<ContactUs>
    {
        List<ContactUs> GetActivesListFromContactUs();
        List<ContactUs> GetPassivesListFromContactUs();
        void ChangeToPassive(int id);
        void ChangeToActive(int id);
    }
}
