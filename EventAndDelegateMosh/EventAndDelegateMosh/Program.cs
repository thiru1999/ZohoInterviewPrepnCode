using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegateMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title="video1"};
            VideoEncoder videoEncoder = new VideoEncoder(); //Publisher
            EmailService mail = new EmailService(); //Subscriber
            MessageService msg = new MessageService();//Subscriber
            videoEncoder.videoEncoded += mail.OnVideoEncoded;
            videoEncoder.videoEncoded += msg.OnVideoEncodedeee;
            videoEncoder.Encode(video);


        }
    }
}
