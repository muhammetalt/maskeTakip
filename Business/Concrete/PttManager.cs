using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    private IApplicantService _applicantService;//dependency Injection


    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }



    public void GiveMask(Person person)
    {
       
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirsName + " için maske verildi");
        }
        else
        {
            Console.WriteLine("Maske verilemedi");
        }
    }
}
