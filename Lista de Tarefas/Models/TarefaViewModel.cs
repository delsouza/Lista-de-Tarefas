using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace Lista_de_Tarefas.Models
{
    public class TarefaViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha a data de vencimento!")]
        public DateTime? Vencimento { get; set; }
        [Required(ErrorMessage = "Selecione uma categoria!")]
        public string CategoriaId { get; set; }

        [ValidateNever]
        public CategoriaViewModel Categoria { get; set; }
        [Required(ErrorMessage = "Selecione um status!")]
        public string StatusId { get; set; }
        [ValidateNever]
        public StatusViewModel Status { get; set; }
        public bool Atrasado => StatusId == "aberto" && Vencimento < DateTime.Today;
    }
}
