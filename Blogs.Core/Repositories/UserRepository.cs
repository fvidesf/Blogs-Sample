﻿using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    internal class UserRepository : BaseRepository<BlogsContext>, IUserRepository
    {
        public UserRepository(BlogsContext blogsContext) : base(blogsContext)
        {

        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await Db.Users.Include(user => user.Roles)
                .FirstOrDefaultAsync(user => user.Email == email);
            return user;
        }
    }
}
