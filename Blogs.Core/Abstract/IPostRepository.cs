﻿using Blogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Core.Abstract
{
    public interface IPostRepository
    {
        /// <summary>
        /// Get all posts by writer
        /// </summary>
        /// <param name="writerId"></param>
        /// <returns></returns>
        Task<List<Post>> GetPostsByWriterId(Guid writerId);

        /// <summary>
        /// Get posts by status
        /// </summary>
        /// <returns></returns>
        Task<List<Post>> GetPendingPostsByStatus(PostStatus status);

        /// <summary>
        /// Create new post
        /// </summary>
        /// <param name="text"></param>
        /// <param name="writerId"></param>
        /// <returns></returns>
        Task SavePost(string text, Guid writerId);

        /// <summary>
        /// Apply update to a post
        /// </summary>
        /// <param name="updatedPost"></param>
        /// <returns></returns>
        Task UpdatePost(Post updatedPost);

        /// <summary>
        /// Soft delete a post by Id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task SoftDeletePost(Guid postId);

    }
}
