using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage ="Пожалуйста, введите свое имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите свой Email")]
        [RegularExpression (".+\\@.+\\..+", ErrorMessage ="Пожалуйста введите валидный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Пожалуйста, введите свой номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, укажите примети ли участие")]
        public bool? WillAttend { get; set; }

    }
}
