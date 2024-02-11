using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

class Program
{
    private ISupplierService _supplierService;

    
    static void Main(string[] args)
    {
        
         Person person1 = new Person();
        person1.FirsName = "ENGİN";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 1234;
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
     



     
    }

    
}


