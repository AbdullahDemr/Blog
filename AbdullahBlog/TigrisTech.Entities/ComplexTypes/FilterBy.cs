﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Entities.ComplexTypes
{
    public enum FilterBy
    {
        [Display(Name = "Kategori")]
        Category = 0, //GetAlllByUserInOnData(Filter=FilterBy.Category, int categoryId)
        [Display(Name = "Tarih")]
        Date = 1,
        [Display(Name = "Okunma Sayısı")]
        ViewCount = 2,
        [Display(Name = "Yorum Sayısı")]
        CommentCount = 3
    }
}
