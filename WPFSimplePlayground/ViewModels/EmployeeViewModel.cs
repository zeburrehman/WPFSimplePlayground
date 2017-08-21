using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFSimplePlayground.Infrastructure;
using WPFSimplePlayground.Models;

namespace WPFSimplePlayground.ViewModels
{
    public class EmployeeViewModel : BasePropertyChanged
    {
        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
        }

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { SetProperty(ref _selectedEmployee, value); }
        }

        private ICommand _refreshCommand;
        public ICommand RefreshCommand
        {
            get { return _refreshCommand; }
            set { SetProperty(ref _refreshCommand, value); }
        }


        public EmployeeViewModel()
        {
            RefreshCommand = new RelayCommand(CanRefreshData, RefreshData);
            GenerateEmployeesData();
        }

        private bool CanRefreshData(object obj)
        {
            return true;
        }

        private void RefreshData(object obj)
        {
            var name = SelectedEmployee.Name;
            GenerateEmployeesData();
            SelectedEmployee = Employees.FirstOrDefault(e => e.Name == name);
        }

        private void GenerateEmployeesData()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee{ Name = "Zeb ur Rehman", Email = "zeburrehman@gmail.com", Salary  = 10000 },
                new Employee{ Name = "Shahrukh Afridi", Email = "shahafridi@gmail.com", Salary  = 20000 },
                new Employee{ Name = "Waqas Rehman", Email = "waqas@gmail.com", Salary  = 30000 },
                new Employee{ Name = "Asia Bibi", Email = "asiabibi@gmail.com", Salary  = 40000 },
                new Employee{ Name = "Abdurrehman", Email = "abdurrehman@gmail.com", Salary  = 50000 },
                new Employee{ Name = "Maria Junajo", Email = "mariajunajo@gmail.com", Salary  = 60000 },
                new Employee{ Name = "Shafi ur Rehman", Email = "shafiurrehman@gmail.com", Salary  = 70000 },
                new Employee{ Name = "Nowsher Khan", Email = "nowsherkhan@gmail.com", Salary  = 80000 }
            };
        }
    }
}
