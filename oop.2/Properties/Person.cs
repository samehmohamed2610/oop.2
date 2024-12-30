using oop._2.properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2.Properties
{
    #region MyRegion
    //internal struct Person2
    //{
    //    private string? name;
    //    private int? age;

    //    public Person2(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }


    //    public override string ToString()
    //    {
    //        return $"Name = {name} \n Age ={age}";
    //    }
    //}
    #endregion
    public struct Person
    {
        // Attribute 

        private string[] names;
        private int[] ages;
        private int size;

        // Constructor
        public Person(int size)
        {
            this.size = size;
            names = new string[size];
            ages = new int[size];
        }

        // Indexer 
        public (string Name, int Age) this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return (names[index], ages[index]);
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    names[index] = value.Name;
                    ages[index] = value.Age;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        // Method to find the oldest person
        public (string Name, int Age) FindOldest()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("No persons to evaluate.");
            }

            int maxAge = ages[0];
            string oldestName = names[0];

            for (int i = 1; i < size; i++)
            {
                if (ages[i] > maxAge)
                {
                    maxAge = ages[i];
                    oldestName = names[i];
                }
            }

            return (oldestName, maxAge);
        }
    }

}
