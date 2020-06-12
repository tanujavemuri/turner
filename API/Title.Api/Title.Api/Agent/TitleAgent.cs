using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Title.Api.DB;
using Title.Api.Models;

namespace Title.Api.Agent
{
    public class TitleAgent
    {
        private readonly TitlesEntities titlesEntities;
        private Mappers.Mappers map = null; 
        public TitleAgent()
        {
            map = new Mappers.Mappers();
            titlesEntities = new TitlesEntities();
        }

        public TitleModel GetTitleByname(string TitleName)
        {
            var titles = titlesEntities.Title.Where(x => x.TitleName.Contains(TitleName)).FirstOrDefault();
            if(titles==null)
            {
                return null;
            }
            var title = map.DBtoAPI(titles);
            foreach (var awardItem in titles.Award)
            {
                var award = map.DBtoAPI(awardItem);
                title.Award.Add(award);
            }
            foreach (var oName in titles.OtherName)
            {
                var name = map.DBtoAPI(oName);
                title.OtherName.Add(name);
            }
            foreach (var story in titles.StoryLine)
            {
                var storymodel = map.DBtoAPI(story);
                title.StoryLine.Add(storymodel);
            }

            foreach (var titleGenre in titles.TitleGenre)
            {
                var model = map.DBtoAPI(titleGenre);
                title.TitleGenre.Add(model);
            }
            foreach (var titleParticipant in titles.TitleParticipant)
            {
                var model = map.DBtoAPI(titleParticipant);
                title.TitleParticipant.Add(model);
            }
            return title;
        }

        public List<TitleModel> GetTitlesByname(string TitleName)
        {
            var titles = titlesEntities.Title.Where(x => x.TitleName.Contains(TitleName)).ToList();
            if (titles == null)
            {
                return null;
            }
            var titlesModel = new List<TitleModel>();
            foreach (var item in titles)
            {
                titlesModel.Add(map.DBtoAPI(item));
            }
            return titlesModel;
        }
    }
}