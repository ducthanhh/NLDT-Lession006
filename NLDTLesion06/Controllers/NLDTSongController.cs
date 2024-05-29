using NLDTLesion06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace NLDTLesion06.Controllers
{
    public class NLDTSongController : Controller
    { 
        private static List<NLDTSong> NLDTSongs = new List<NLDTSong>()
        {
        new NLDTSong{Id=2210065,NLDTTitle="nguyen le duc thanh",NLDTAuthor="K22CNT3",NLDTArtist="NTU",NLDTYearRelease=2020},
        new NLDTSong{Id=1,NLDTTitle="nguyen le duc ",NLDTAuthor="K22CNT3",NLDTArtist="NTU",NLDTYearRelease=2020}

        };

        // GET: NLDTSong
        /// <sammary>
        /// hien thi danh sach bai hat
        /// author : nguyen le duc thanh
        /// <sammary>
        /// <return>
        public ActionResult NLDTIndex()
        {
            return View(NLDTSongs);
        }
        // GET: NLDTCreate
        /// <sammary>
        /// form them moi bai hat 
        /// author : nguyen le duc thanh
        /// <sammary>
        /// <return>
        public ActionResult NLDTCreate()
        {
            var NLDTSong = new NLDTSong();
            return View(NLDTSong);
    }
}
}