﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Entities.Dtos.Editor.Emails
{
    public class PasswordResetDto
    {
        [Display(Name = "Email adresiniz")]
        [Required(ErrorMessage = "Email alanı gereklidir")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Yeni şifreniz")]
        [Required(ErrorMessage = "Şifre alanı gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "şifreniz en az 4 karakterli olmalıdır.")]
        public string PasswordNew { get; set; }
    }
}
