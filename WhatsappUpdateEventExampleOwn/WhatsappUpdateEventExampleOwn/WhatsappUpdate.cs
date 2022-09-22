using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappUpdateEventExampleOwn
{
    public delegate void Notify();

    public class WhatsappUpdate   //Publisher
    {
        public event Notify Clicking;   //Creating Event
        public void AfterDevelopmentProcessOver()   //Event will Raise After this Process 
        {
            Console.WriteLine("Development Over so we can give Update to Android and Ios");
            Clicking();


        }
        //public void OnClicking()  //Raising Event 
        //{
        //    Clicking.Invoke();
        //}

    }
}
