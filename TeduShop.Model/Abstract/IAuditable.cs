using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}