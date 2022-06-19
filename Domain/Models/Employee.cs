using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "varchar(15)")]
        public string Code { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,4)")]
        public double Salary { get; set; } = 0;

        public int Age { get; set; }
    }
}
