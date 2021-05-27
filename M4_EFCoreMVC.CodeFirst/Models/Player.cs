﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M4_EFCoreMVC.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° Camiseta")]
        [Range(1, 30, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Dorsal { get; set; }
        [Column(TypeName = "Date")]
        [Display(Name = "Fec.Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
    }
}
