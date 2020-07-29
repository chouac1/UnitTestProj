using Microsoft.Data.Tools.Schema.Sql.Dac.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
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
        
        public void Add(T value)
        {
            //create a temp array
            //loop values back into the array bc they are null

                        
                if (count == Capacity)
                {

                               
                    T[] items2 = new T[Capacity + Capacity];
                
                    for (int i = 0; i < count; i++)
                    {

                            items2[i] = items[i];
                                                        
                        
                    }

                items = items2;
     
                
                }

                items[count] = value;
                count++;
                      
        }

        public void Remove(T value)
        {
            //create a temp array
            //loop values back into the array bc they are null


            if (count == Capacity)
            {


                T[] items2 = new T[Capacity + Capacity];

                for (int i = 0; i < count; i++)
                {

                    items2[i] = items[i];


                }

                items = items2;


            }

            items[count] = value;
            count--;

        }


    }
}
