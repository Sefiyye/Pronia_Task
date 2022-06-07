using System.Collections.Generic;

namespace Pronia_start.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterLogo { get; set; }
        public string Phone { get; set; }
        public string SearchIcon { get; set; }
        public string UserIcon { get; set; }
        public string LikeIcon { get; set; }
        public string BasketIcon { get; set; }
        public string AdImage { get; set; }
        public string ImageTitle { get; set; }
        public string ImageSubtitle { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }


    }
}
