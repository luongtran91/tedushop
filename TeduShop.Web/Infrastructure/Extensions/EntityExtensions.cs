using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory,PostCategoryViewModel postCategoryVM)
        {
            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.Description = postCategoryVM.Description;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.Image = postCategoryVM.Image;
            postCategory.HomeFlg = postCategoryVM.HomeFlg;

            postCategory.CreateDate = postCategoryVM.CreateDate;
            postCategory.CreateBy = postCategoryVM.CreateBy;
            postCategory.UpdateDate = postCategoryVM.UpdateDate;
            postCategory.UpdateBy = postCategoryVM.UpdateBy;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.Status = postCategoryVM.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.Description = postVM.Description;
            post.CategoryID = postVM.CategoryID;
            post.Content = postVM.Content;
            post.Image = postVM.Image;
            post.HomeFlg = postVM.HomeFlg;
            post.Viewcount = postVM.Viewcount;

            post.CreateDate = postVM.CreateDate;
            post.CreateBy = postVM.CreateBy;
            post.UpdateDate = postVM.UpdateDate;
            post.UpdateBy = postVM.UpdateBy;
            post.MetaDescription = postVM.MetaDescription;
            post.MetaKeyword = postVM.MetaKeyword;
            post.Status = postVM.Status;
        }
    }
}