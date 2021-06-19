﻿using System;
using System.Collections.Generic;

namespace Blogs.Core.Model
{
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<AuthToken> Tokens { get; set; }


    }
}
