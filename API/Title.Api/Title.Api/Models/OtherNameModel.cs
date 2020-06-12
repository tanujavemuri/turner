using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class OtherNameModel
    {
        public Nullable<int> TitleId { get; set; }
        public string TitleNameLanguage { get; set; }
        public string TitleNameType { get; set; }
        public string TitleNameSortable { get; set; }
        public string TitleName { get; set; }
        public int Id { get; set; }

    }
}