using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class TitleModel
    {
        public TitleModel()
        {
            this.Award = new HashSet<AwardModel>();
            this.OtherName = new HashSet<OtherNameModel>();
            this.StoryLine = new HashSet<StoryLineModel>();
            this.TitleGenre = new HashSet<TitleGenreModel>();
            this.TitleParticipant = new HashSet<TitleParticipantModel>();
        }
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public Nullable<int> TitleTypeId { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public Nullable<System.DateTime> ProcessedDateTimeUTC { get; set; }

        public  ICollection<AwardModel> Award { get; set; }
        public  ICollection<OtherNameModel> OtherName { get; set; }
        public  ICollection<StoryLineModel> StoryLine { get; set; }
        public  ICollection<TitleGenreModel> TitleGenre { get; set; }
        public  ICollection<TitleParticipantModel> TitleParticipant { get; set; }
    }
}