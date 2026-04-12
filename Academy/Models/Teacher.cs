using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    internal class Teacher: Human
    {
        internal double salary;
        Teacher(int id, string last_name, string first_name, 
            string middle_name, string birth_date, string email, 
            string phone, Image photo, double salary) : 
            base(id, last_name, first_name, middle_name, birth_date, email, 
                phone, photo)  
        {
            this.salary = salary;
        }
    }
}
