using System;
using System.Collections.Generic;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int state;

        public int GetState()
        {
            return this.state;
        }

        public void SetState(int state)
        {
            this.state = state;
            this.notifyAllObserver();
        }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        private void notifyAllObserver()
        {
            foreach (var item in this.observers)
            {
                item.Update();
            }
        }
    }
}