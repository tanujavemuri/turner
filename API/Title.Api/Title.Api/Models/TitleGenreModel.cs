using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class TitleGenreModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int GenreId { get; set; }
    }
}