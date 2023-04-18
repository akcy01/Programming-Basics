using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.SingleResponsibilityPrinciple
{
    public class PersonService
    {
        public List<Person> getPersons()
        {
            return new()
            {
                new(){Name = "Oğuz", Age = 23}
            };
        }
    }
}
