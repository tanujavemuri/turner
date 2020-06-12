using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class StoryLineModel
    {
        public int TitleId { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}