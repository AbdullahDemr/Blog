﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Blog;

namespace TigrisTech.Entities.Concrete.UserTable
{
    public class User : IdentityUser<int>
    {
        public string Picture { get; set; }
        public string About { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDentist { get; set; }
        public string Color { get; set; }
        public string YoutubeLink { get; set; }
        public string TwitterLink { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string GitHubLink { get; set; }
        public string WebsiteLink { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
