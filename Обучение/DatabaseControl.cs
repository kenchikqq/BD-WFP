using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обучение
{
        public static class DatabaseControl
        {
            public static List<Employee> GetEmployeesList()
            {
            using (DbAppContext context = new DbAppContext())
            {
                return context.Employee.ToList();
            }
            
        }
    }
}
