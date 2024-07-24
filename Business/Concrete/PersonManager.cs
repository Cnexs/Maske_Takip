using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Mernis.ServiceReference;




namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {

        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;

        }
        public bool CheckPerson(Person person)

        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;

        }

    }


}

// kişinin adı doğum tarihi vs  parantez içine yazabilirdim fakat 
                                                //  buraya doğum yılı da gelseydi kodlar hata verirdi ve biz bunları bir class içinde yazabiliyorsak 
                                                // buna encapsulation diyoruz ve biz bunu person isimli  nesnenin içine attık

        // mesela gidip person kısmında get set kısmında ben baba adı ekledim sonradan kod bana kızmaz çünkü
        // encapsulation dediğimiz olayı yaptık