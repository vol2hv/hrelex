using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace hrelex.Models
{
    // Отделы
    public class Department
    {
        [Key]
        [Display(Name = "Отдел")]
        public string DepartmentName { get; set; }
        [Display(Name = "Местоположение")]
        [Required]
        public string Location { get; set; }
        // список сотрудников
        public List<Employee> Employees { get; set; }
    }

    // Сотрудники
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name = "Имя")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Фамилия")]
        [Required]
        public string LastName { get; set; }

        // Ссылка на отдел 
        public string DepartmentName { get; set; }
        [ForeignKey("DepartmentName")]
        public Department Department { get; set; }
 
        //// список проектов
        //public List<Project> Projects { get; set; }
        //public int? ProjectId { get; set; }


    }

    //// Проекты
    //public class Project
    //{
    //    public int ProjectId { get; set; }
    //    [Display(Name = "Имя")]
    //    [Required]
    //    public string ProjectName { get; set; }
    //    [Display(Name = "Бюджет")]
    //    [Required]
    //    public decimal? Budget { get; set; }

    //    // список сотрудников
    //    public List<Employee> Employees { get; set; }
    //    public int? EmployeeId { get; set; }
    //}
    public class HrelexContext : DbContext
    {
        public HrelexContext() : base("DefaultConnection") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
       // public DbSet<Project> Projects { get; set; }

    }

}
