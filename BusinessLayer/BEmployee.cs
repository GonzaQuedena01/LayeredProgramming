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
