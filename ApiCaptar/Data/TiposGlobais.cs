using System.ComponentModel.DataAnnotations;

namespace apiCaptar.Data;

public enum ExemploEnum
{
    [Display(Name = "Não")] Não = 1,
    [Display(Name = "Sim")] Sim = 2
}