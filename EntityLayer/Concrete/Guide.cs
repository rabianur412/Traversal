using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideDescription { get; set; }
        public string GuideImage { get; set; }
        public string GuideTwitter { get; set; }
        public string GuideInstagram { get; set; }
        public bool GuideStatus { get; set; }
    }
}
