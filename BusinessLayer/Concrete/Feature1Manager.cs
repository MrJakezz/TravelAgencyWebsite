using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Feature1Manager : IFeature1Service
    {
        private readonly IFeature1Dal _feature1Dal;

        public Feature1Manager(IFeature1Dal feature1Dal)
        {
            _feature1Dal = feature1Dal;
        }

        public void TAdd(Feature1 t)
        {
            _feature1Dal.Insert(t);
        }

        public void TDelete(Feature1 t)
        {
            _feature1Dal.Delete(t);
        }

        public Feature1 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature1> TGetDestinationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature1> TGetList()
        {
            return _feature1Dal.GetList();
        }

        public void TUpdate(Feature1 t)
        {
            _feature1Dal.Update(t);
        }
    }
}
