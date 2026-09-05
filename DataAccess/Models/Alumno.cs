using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(500)")]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(500)")]
        public string SurName { get; set; }

        [Column(TypeName = "INT")]
        public int Dni { get; set; }

        [Column(TypeName = "VARCHAR(500)")]
        public string Career { get; set; }

        [Column(TypeName = "REAL")]
        public decimal Average { get; set; }

        public Alumno()
        {
           

        }

        public Alumno(string name, string surName, int dni, string career, decimal average)
        {
            Name = name;
            SurName = surName;
            Dni = dni;
            Career = career;
            Average = average;
        }
    }
}
