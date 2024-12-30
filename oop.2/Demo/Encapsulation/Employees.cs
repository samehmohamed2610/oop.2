using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Encapsulation
{
    internal struct Employees
    {

        #region Attributes
        private int id;
        private string? name;
        private decimal salary;
        private decimal deduction; //Derived Attribute 
        #endregion

        #region Geeter&Seeter
        // Geeter
        public int GetId()
        {
            return id;
        }
        //Seeter
        public void SetId(int value)
        {
            id = value > 1 && value <= 30 ? value : 1; // Data Validation
        }
        #endregion 

        #region  Full Property
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value?.Length <= 10 ? value : value?.Substring(0, 10); // Data validation
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value >= 20_000 && value < 80_000 ? value : 50_000;
            }
        }
        public decimal Deduction // raed only property
        {
            get
            {
                return salary * 0.2M;
            }
            //set
            //{
            //    deduction = value;
            //}
        }
        #endregion

        #region Code snippet For Property
        // propfull is : acode snippet for [Full Property]

        //private string address;
        //
        //public string MyProperty
        //{
        //    get { return address; }
        //    set { address = value; }
        //}

        // prop is : acode snippet for [Automatic Property]

        /// public int MyProperty { get; set; }
        #endregion

        #region AutoMatic Property
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Employees(int _id, string? _name, decimal _salary, int _age)
        {
            id = _id;
            name = _name;
            salary = _salary;
            Age = _age;
        }
        #endregion 

        #region Methods
        public override string ToString()
        {
            return $"Id = {id} \nName = {name} \nAge ={Age} \nSalary = {salary:c}";
        }
        #endregion

    }

}
