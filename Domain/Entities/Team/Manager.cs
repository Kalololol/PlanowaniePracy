using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Team
{
    public class Manager : Employee
    {
        public int IdManager { get; set; }

        public Manager(){ }        
        public Manager(int idManager)
        {
            IdManager = idManager;
        }
    }
}
