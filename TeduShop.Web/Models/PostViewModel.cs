using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        
        public int CategoryID { get; set; }

        public string Image { get; set; }
        
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlg { get; set; }

        public bool? HotFlg { get; set; }

        public int? Viewcount { get; set; }
        
        public virtual PostCategoryViewModel PostCategory { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { get; set; }

        public string CreateBy { set; get; }

        public DateTime? CreateDate { set; get; }

        public string UpdateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}