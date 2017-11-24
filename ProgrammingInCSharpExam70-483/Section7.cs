using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public static class Section7
    {
        public static void Do()
        {
            var client = new BasicEventClient();
            client.Main();
        }
    }

    #region Basic Event Example

    public class BasicEventClient
    {
        public void Main()
        {
            var publisher = new Publisher();

            var subscriber = new Subscriber();

            //No use of Ms EventHandler
            publisher.MyEvent += subscriber.HandleTheEvent;
            publisher.EventRaiser(100);

            //????? You can implement it event without events. So, Why do we need events?!!!!
            publisher.NoEvent += subscriber.HandleTheEvent;
            publisher.NoEventRaiser(100);

            //Use of MS EventHandler
            publisher.EvHandler += subscriber.HandleMsEvent;
            publisher.MsRaiser(150);

            //Use of Ms Custom Event args
            publisher.MyEventHandler += subscriber.HandleMsEventArgs;
            publisher.MsEventArgRaiser(400);
        }
    }

    /// <summary>
    /// publisher has event, raiser(when should be raised)
    /// </summary>
    public class Publisher
    {
        #region NoEvent
        public MyDel NoEvent { get; set; }
        public void NoEventRaiser(int x)
        {
            if (x > 10)
            {
                NoEvent("your data is more than 10");
            }
        }

        #endregion

        #region BasicEvent
        public delegate void MyDel(string x);
        public event MyDel MyEvent;

        public void EventRaiser(int x)
        {
            if (x > 10)
            {
                MyEvent("your data is more than 10");
            }
        }

        #endregion

        #region MsEventHandler

        public EventHandler EvHandler;

        public void MsRaiser(int x)
        {
            if (x > 100)
                EvHandler(this, EventArgs.Empty);
        }


        #endregion

        #region MsEventHandlerGeneric

        public EventHandler<CustomEventArg> MyEventHandler;

        public void MsEventArgRaiser(int x)
        {
            if (x > 100)
            {
                var eventArgs = new CustomEventArg("More than 100");
                MyEventHandler(this, eventArgs);
            }
        }


        #endregion
    }

    public class CustomEventArg : EventArgs
    {
        public CustomEventArg(string x)
        {
            Message = x;
        }

        public string Message { get; private set; }
    }

    public class Subscriber
    {
        public void HandleTheEvent(string x)
        {
            Console.WriteLine(x);
        }

        public void HandleMsEvent(object sender, EventArgs args)
        {
            Console.WriteLine(sender + " says it is more that 100");
        }

        public void HandleMsEventArgs(object sender, CustomEventArg args)
        {
            Console.WriteLine(args.Message + " says it is more that 100");
        }
    }

    #endregion

}
