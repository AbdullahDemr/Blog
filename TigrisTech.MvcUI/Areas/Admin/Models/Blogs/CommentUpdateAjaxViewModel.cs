﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigrisTech.Entities.Dtos.Blog;

namespace TigrisTech.MvcUI.Areas.Admin.Models
{
    public class CommentUpdateAjaxViewModel
    {
        public CommentUpdateDto CommentUpdateDto { get; set; }
        public string CommentUpdatePartial { get; set; }
        public CommentDto CommentDto { get; set; }
    }
}
