using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        int GetGuideCount();
        void TChangeToActive(int id);
        void TChangeToPassive(int id);
    }
}
