﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação!")]
        [Display(Name = "Ano de fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano do modelo!")]
        [Display(Name = "Ano do modelo")]

        public int AnoModelo { get; set; }
    }
}
