using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal : IGenericDal<Guide>
    {
        int GetGuideCount();
        void ChangeToActive(int id);
        void ChangeToPassive(int id);
    }
}
