using Microsoft.Data.Tools.Schema.Sql.Dac.Data;
using System;
using System.CodeDom;
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

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        //Member Methods

        public void Add(T value)
        {
            
                if (count == Capacity)
                {
                Capacity = Capacity * 2;           
                T[] items2 = new T[Capacity];
                
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
            T[] items2 = new T[Capacity];
            bool hasFound = false;
            int originalCount = count;

            for (int i = 0; i < originalCount; i++)                  
            {
                if (items[i].Equals(value) && hasFound == false)
                {
                    hasFound = true;
                    count--;
                }
                else 
                {
                    if(hasFound == true)
                    {
                        items2[i-1] = items[i];
                    }
                    else
                    {
                        items2[i] = items[i];
                    }
                }

            }
            items = items2;
        }

        public override string ToString()
        {
            string[] tempString = new string[count];
            string[] intToString = items.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < count; i++)
            {
                tempString[i] = intToString[i];
            }
            string newString = string.Join("", tempString);
            return newString;
        }

    }
}
