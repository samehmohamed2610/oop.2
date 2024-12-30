using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop._2.Properties
{
    internal class Employee
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public Permissions Security_Level { get; set; }
        //public int Salary { get; set; }
        //public Gender Gender { get; set; }
        //public int Day { get; set; }
        //public int Month { get; set; }
        //public int Year { get; set; }

        private int id;
        private string name;
        private Permissions security_Level;
        private int salary;
        private Gender gender;
        private int day;
        private int month;
        private int year;

        public Employee(int id, string name, Permissions security_Level, int salary, Gender gender, int day, int month, int year)
        {
            this.id = id;
            this.name = name;
            this.security_Level = security_Level;
            this.salary = salary;
            this.gender = gender;
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Permissions Security_Level
        {
            get { return security_Level; }
            set { security_Level = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }



        public override string ToString()
        {
            return ($"Id : {id} | Name : {name} | Security_Level : {security_Level}  | Salary :{Salary:c} | Gender : {(gender.ToString() == Gender.m.ToString() ? " Male " : " Female ")} | Date :{day}/{month}/{year}").ToString();
        }
    }
    public enum Gender
    {
        m,
        f,
    }

    [Flags]
    public enum Permissions : byte
    {
        guest = 1, developer = 2, secretary = 4, dba = 8
    }
}

