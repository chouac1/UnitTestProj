using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {

        //Member Variables

        private int count;
        public int Capacity { get; set; }

        public int Count 
        { 
            get
            {
                return count;
            } 
        }

        private T[] items;

        //Constructor
        public CustomList()
        {
            count = 0;
            Capacity = 4;
            items = new T[Capacity];

        }

        //Member Methods
        
        //build add method
    }
}
