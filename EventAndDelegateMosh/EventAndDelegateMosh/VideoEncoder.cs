using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegateMosh
{
    public class VideoEventArgs : EventArgs
    {
        public Video video
        {
            get;set;
        }
    }
    internal class VideoEncoder //publisher
    {
        // STEPS to implement an event where at the end we notify anyone interested in this event

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise or 'publish' the event

        //public delegate void videoEncoderHandler(object source, VideoEventArgs args);
        //public event videoEncoderHandler videoEncoded; //Event

        //Instead of uisng the Above Delegate Format we can use the below also

        public EventHandler<VideoEventArgs> videoEncoded; // For having extra arguement
        //public EventHandler videoEncoded;  //For Empty Arguement


        public VideoEncoder() { }

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            Thread.Sleep(2000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)  //Gives signal to subscriber ,It is Handling the event 
        {
            if (videoEncoded!=null)  //videoencoded have the list of Subscriber checking whether subscriber is there or not 
            {
                videoEncoded(this,new VideoEventArgs { video=video} ); //calling all the subscriber using publisher class and empty extra arguement

            }

        }
    }
}
