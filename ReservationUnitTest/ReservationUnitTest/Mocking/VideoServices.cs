using System;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SharpDX.Direct3D11;

namespace ReservationUnitTest.Mocking
{
    public class VideoService
    {
        //Dependancy Injection Using Methods

        //public string ReadVideoTitle(IfileReader fileReader)
        //{
        //    var str = fileReader.Read("video.txt");
        //    var video = JsonConvert.DeserializeObject<Video>(str);
        //    if (video == null)
        //        return "Error parsing the video.";
        //    return video.Title;
        //}

        //Dependency Inject Using Constructor.
        private IfileReader _fileReader;
        public VideoService(IfileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();

        }

        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        ////public string GetUnprocessedVideosAsCsv() 
        ////{
        ////    var videoIds = new List<int>();

        ////    using (var context = new VideoContext())
        ////    {
        ////        var videos =
        ////            (from video in context.Videos
        ////             where !video.IsProcessed
        ////             select video).ToList();

        ////        foreach (var v in videos)
        ////            videoIds.Add(v.Id);

        ////        return String.Join(",", videoIds);
        ////    }
        ////}
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    //public class VideoContext : DbContext
    //{
    //    public DbSet<Video> Videos { get; set; }
    //}
}
