using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSimplePlayground.Infrastructure;

namespace WPFSimplePlayground.Models
{
    public class Employee : BasePropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set { SetProperty(ref _salary, value); }
        }
    }
}
