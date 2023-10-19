using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public int GetGuideCount()
        {
            return _guideDal.GetGuideCount();
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetDestinationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
