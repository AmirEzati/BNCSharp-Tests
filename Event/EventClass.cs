using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNCSharp_Tests
{
    class EventClass
    {
        public EventClass()
        {
            Console.WriteLine("Welcome to the Test Events. Enter a key to continue");
            Console.WriteLine("Enter 1)s ");
            new Subscriber();
        }

    }
}


public class Publisher: System.Collections.ArrayList
{
    public delegate void EventHandler(object sender, System.EventArgs e);
    public delegate char RemovingEventHandler(object sender, System.EventArgs e);

    public event EventHandler RemovedAt;
    protected   virtual void OnRemovedAt(System.EventArgs e)
    {
        if (RemovedAt != null)
        {
            RemovedAt(this, e);
        }
    }

    public event RemovingEventHandler RemovingAt;
    protected virtual char OnRemovingAt(System.EventArgs e)
    {
        if (RemovingAt!=null)
        {
           return RemovingAt(this, e);
        }
        return '0';
    }
    public Publisher()
    {
        //new Subscriber();
    }

    public override void RemoveAt(int index)
    {
        var returnedValue=OnRemovingAt(System.EventArgs.Empty);

        if (returnedValue=='1')
        {
            base.RemoveAt(index);

        }
        OnRemovedAt(System.EventArgs.Empty); //this is where we raise the event

    }
  
    public void Display()
    {
        foreach (var item in this)
        {
            Console.WriteLine("* "+ item.ToString());
        }
    }
}

public class Subscriber
{
    public Subscriber()
    {
        UsePublisher();
    }

    public void UsePublisher()
    {
        var p = new Publisher();
        p.RemovedAt += RemovedAtEventHandler; 
        p.RemovingAt += RemovingAtEventHandler; 

        p.Add("sdfsdfsdfsdf");
        p.Add("sdfsdfsdfsdfsdfsdfdf");
        Console.WriteLine("Before Removing: ");

        p.Display();

        p.RemoveAt(1);
        Console.WriteLine("After Removing: ");

        p.Display();
    }

    public void RemovedAtEventHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Did you remove that item??");
        
    }

    public char RemovingAtEventHandler(object sender, EventArgs e)
    {
        Console.WriteLine("Are you sure you want to remove ?  1)yes  2)No");
      return  Console.ReadKey().KeyChar;
    }
}
