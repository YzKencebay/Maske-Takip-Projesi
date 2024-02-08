using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IApplicantService
{
    List<Person> GetList();

    void ApplyForMask(Person person);

    bool CheckPerson(Person person);
    
}
