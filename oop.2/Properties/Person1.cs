using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2.properties
{
    internal struct Person1
    {
        #region Attribute 
        private string?[] names;
        private int?[] ages;
        private int size;
        #endregion

        #region Constructor
        public Person1(int _size)
        {
            size = _size;
            names = new string[size];
            ages = new int?[size];
        }
        #endregion

        #region Property
        public int Size
        { get { return size; } }

        public string this[int index]
        {
            get
            {
                return $"Position: {index + 1} , Name = {names[index]} , Age = {ages[index]}";
            }
        }

        #endregion

        #region Methods
        public void Addperson(int position, string? name, int? age)
        {
            if (name is not null && age is not null && position < size)
            {
                names[position] = name;
                ages[position] = age ;
            }

        }

        #endregion


    }
}
