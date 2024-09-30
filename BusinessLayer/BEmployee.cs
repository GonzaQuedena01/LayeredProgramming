using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using EntityLayer;
using System.Data;

namespace BusinessLayer
{
    public class BEmployee
    {
        DEmployee DataObject = new DEmployee();

        public DataTable ListEmployees()
        {
            return DataObject.List();
        }

    }
}
