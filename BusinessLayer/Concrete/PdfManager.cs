using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PdfManager : IPdfService
    {
        public byte[] PdfList<T>(List<T> values) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
