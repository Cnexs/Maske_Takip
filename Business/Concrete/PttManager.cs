using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        // interface ler referans tutucudurlar
        //interface ler  new lenemez
        // bu yapıya constructor diyoruz ve Constructor new yaptığımızda çalışır
        {
            _applicantService = applicantService;

        }

        public void GiveMask(Person person)
        {
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");

            }
            else
            {
                Console.WriteLine(person.FirstName +  " için maske verilemedi ");



            }

        }
    }
}


// tasarım deseni dediğimz şey biz ptt manager olarak başka bir sınıfa ihtiyaç duyuyoruz
// ve ihtiyaç duyduğumz sınıfı new lemek yerine onun interface sini yazıyorum
//
            
            

        


    

