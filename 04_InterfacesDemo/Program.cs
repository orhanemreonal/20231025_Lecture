using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }
    
    interface ISalary
    {
        void GetSalary();
    }

    class Managers : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Android : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }


}
