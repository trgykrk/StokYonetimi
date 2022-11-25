using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StokYonetimi.Class
{
    public class TraffickHandler : IObservable<Object>
    {
        private static List<IObserver<Object>> observers;
        private static Queue<Object> objectList;


        public TraffickHandler()
        {
            observers = new List<IObserver<Object>>();
            objectList = new Queue<Object>();
        }
        public IDisposable Subscribe(IObserver<object> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new UnSubscriber<Object>(observers, observer);
        }

        public void AddToQueue(Object obj)
        {
            objectList.Enqueue(obj);
        }

        public void InitializationComplate()
        {
            Thread publishDataThread = new Thread(() => PublishData());
            publishDataThread.Start();
        }
        public void PublishData()
        {
            while (true)
            {
                while(objectList.Count == 0)
                {
                    Thread.Sleep(1);
                }
                if(objectList.Count > 0)
                {
                    Object _obj = objectList.Dequeue();
                    foreach(var observer in observers)
                    {
                        observer.OnNext(_obj);
                    }
                }
            }
        }
    }

    internal class UnSubscriber<Object> : IDisposable
    {
       private List<IObserver<Object>> _observers;
       private IObserver<Object> _observer;
       internal UnSubscriber(List<IObserver<Object>> observers, IObserver<Object> observer)
       {
           this._observers = observers;
           this._observer = observer;
       }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                 _observers.Remove(_observer);
            }
        }
    }
   
}
