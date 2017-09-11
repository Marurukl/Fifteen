using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public  Book(string name , int salary,string authorName , int year)
        {
            Name = name;Salary = salary;AuthorName = authorName;Year = year;
        }
    }
}
