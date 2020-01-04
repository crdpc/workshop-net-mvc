using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Display(Name = "Nome")][Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O {0} deve possuir no mínimo 3 e no máximo 60 caracteres" )]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Entre com um endereço de E-mail válido")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salário Base")] [Required(ErrorMessage = "{0} é obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} Deve iniciar em {1} para no máximo {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Departments Departament { get; set; }
        public int DepartmentsId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departments departament)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);

        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
