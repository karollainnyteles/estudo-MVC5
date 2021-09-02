using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProjetoTesteMVC5.Models
{
    public class Aluno
    {
        //[Key]  dizendo que esse campo é a chave primária,
        //mas por convencao o entity entende qu quando tem um campo chamado id ele é  chave
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage ="O campo {0} é requerido")]
        [MaxLength(100, ErrorMessage ="No máximo 100 caracteres")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [EmailAddress(ErrorMessage =("E-mail em formato inválido"))]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string CPF { get; set; }

        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }
    }
}