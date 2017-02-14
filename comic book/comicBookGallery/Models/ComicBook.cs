using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comicBookGallery.Models
{
    public class ComicBook
    {
        public int id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }

        public string DescriptionHtml { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }

        }

        //Series-title-issuenumber.jpg
        //billede til den fejl der vises
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + ".jpg";
            }
        } 
    }
}