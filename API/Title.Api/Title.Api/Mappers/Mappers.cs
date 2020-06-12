using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Title.Api.DB;
using Title.Api.Models;
using db = Title.Api.DB;
namespace Title.Api.Mappers
{
    public class Mappers
    {
        public TitleModel DBtoAPI(db.Title dbEntity)
        {
            return new TitleModel
            {
                TitleId = dbEntity.TitleId,
                ProcessedDateTimeUTC = dbEntity.ProcessedDateTimeUTC,
                ReleaseYear = dbEntity.ReleaseYear,
                TitleName = dbEntity.TitleName,
                TitleTypeId = dbEntity.TitleTypeId,
                TitleNameSortable = dbEntity.TitleNameSortable                ,
            };
        }

        public OtherNameModel DBtoAPI(db.OtherName dbEntity)
        {
            return new OtherNameModel
            {
                Id = dbEntity.Id,
                TitleId = dbEntity.TitleId,
                TitleName = dbEntity.TitleName,
                TitleNameLanguage = dbEntity.TitleNameLanguage,
                TitleNameSortable = dbEntity.TitleNameSortable,
                TitleNameType = dbEntity.TitleNameType
               
            };
        }
        public TitleGenreModel DBtoAPI(db.TitleGenre dbEntity)
        {
            return new TitleGenreModel
            {
                TitleId = dbEntity.TitleId,
                GenreId = dbEntity.GenreId,
                Id = dbEntity.Id
            };
        }
        public TitleParticipantModel DBtoAPI(db.TitleParticipant dbEntity)
        {
            return new TitleParticipantModel
            {
                Id = dbEntity.Id,
                TitleId = dbEntity.TitleId,
                IsKey = dbEntity.IsKey,
                IsOnScreen = dbEntity.IsOnScreen,
                ParticipantId = dbEntity.ParticipantId,
                RoleType = dbEntity.RoleType
            };
        }
        public StoryLineModel DBtoAPI(db.StoryLine dbEntity)
        {
            return new StoryLineModel
            {
                Id = dbEntity.Id,
                Description = dbEntity.Description,
                Language = dbEntity.Language,
                TitleId = dbEntity.TitleId,
                Type = dbEntity.Type
            };
        }

        public GenreModel DBtoAPI(db.Genre dbEntity)
        {
            return new GenreModel
            {
                Id = dbEntity.Id,
                Name = dbEntity.Name
            };
        }

        public AwardModel DBtoAPI(db.Award dbEntity)
        {
            return new AwardModel
            {
                AwardCompany = dbEntity.AwardCompany,
                AwardWon = dbEntity.AwardWon,
                AwardYear = dbEntity.AwardYear,
                Id = dbEntity.Id,
                TitleId = dbEntity.TitleId,
                Award1 = dbEntity.Award1
            };
        }
    }
}