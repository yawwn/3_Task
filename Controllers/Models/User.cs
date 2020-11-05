using System;
using System.ComponentModel.DataAnnotations;

namespace Week2Project.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Возраст должен быть в промежутке от 18 до 100")]
        [Required(ErrorMessage = "Укажите возраст пользователя")]
        public int Age { get; set; }
    }
}
