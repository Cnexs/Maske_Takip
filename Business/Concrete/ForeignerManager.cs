using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
//İnterface ler belli metod imzalarını barındırırlar. Birbirinin alternatifi olan sistemlerin 
//farklı implementasyon yapmalarını sağlarlar
// tek sınıfta yönetmeye çalışırsak buna sapgetti kod diyoruz 