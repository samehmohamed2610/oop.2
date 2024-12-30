using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attribute
        private string?[] names;
        private long[] numbers;
        private int size;
        #endregion

        //Getter
        public long GetNumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                        return (long)numbers[i];
                }
            }
            return -1;
        }
        //seeter 
        public void SetNumber(string name, long value)
        {
            if (names is not null && numbers is not null)
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value;
                        return;
                    }

                }
        }


        #region Properities
        public int Size
        { get { return size; } }

        public long this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])

                            return (long)numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            return;
                        }

                    }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"Position: {index + 1} , Name = {names[index]},Number = {numbers[index]}";
            }
        }

        #endregion

        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];

        }
        #endregion

        #region Methods
        public void Addperson(int position, string name, long number)
        {
            if (names is not null && numbers is not null && position < size)
            {
                names[position] = name;
                numbers[position] = number;
            }

        }
        #endregion

    }
}
