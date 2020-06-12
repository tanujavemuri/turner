using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Title.Api.Models
{
    public class TitleParticipantModel
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public int ParticipantId { get; set; }
        public bool IsKey { get; set; }
        public string RoleType { get; set; }
        public bool IsOnScreen { get; set; }
    }
}