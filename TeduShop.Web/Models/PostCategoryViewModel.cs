using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        
        public string Description { get; set; }

        public int? ParentID { get; set; }
        
        public string Image { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? HomeFlg { get; set; }

        public virtual IEnumerable<PostViewModel> Posts { get; set; }

        public string CreateBy { set; get; }

        public DateTime? CreateDate { set; get; }

        public string UpdateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}