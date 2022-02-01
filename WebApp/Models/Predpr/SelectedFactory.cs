using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Predpr
{
    public class SelectedFactory
    {
        [Required(ErrorMessage = "Не выбрано предприятие")]
        [RegularExpression(@"^[А-Яа-я]+$", ErrorMessage = "Некорректный ввод")]
        public string Vnaim { get; set; }
    }
}
