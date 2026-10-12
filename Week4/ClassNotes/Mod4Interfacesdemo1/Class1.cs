using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo1
{
    //model class
    internal class Employee
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    interface ICRUD
    {
        void Create(Employee obj);
        List<Employee> Read();
        void Update(int id, Employee emp);
        void Delete(int id);

    }
    //implementor

    class TempCRUD : ICRUD
    {
        private static List<Employee> list = new List<Employee>();
        public void Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee emp)
        {
            throw new NotImplementedException();
        }
    }

    //production
    class DBCRUD : ICRUD
    {
        //db
        public void Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
