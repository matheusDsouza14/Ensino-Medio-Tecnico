﻿using System.ComponentModel.DataAnnotations;
namespace LojaInfo.Models { 
    public class ModelClientes {
       [Key]
       public int Id { get; set; }
       [Required]
       public string Nome { get; set; }
       [Required]
       public string Cpf { get; set; }
       [Required]
       public string Email { get; set; }
       [Required]
       public string Endereco { get; set; } }

}

