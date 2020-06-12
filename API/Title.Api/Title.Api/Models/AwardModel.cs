using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class AwardModel
    {
        public int TitleId { get; set; }
        public Nullable<bool> AwardWon { get; set; }
        public Nullable<int> AwardYear { get; set; }
        public string Award1 { get; set; }
        public string AwardCompany { get; set; }
        public int Id { get; set; }
    }
}