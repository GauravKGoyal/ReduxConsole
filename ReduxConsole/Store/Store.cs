using System;
using System.Collections.Generic;

namespace ReduxConsole
{
    public abstract class Store<TState> : IObservable<TState>, IDisposable where TState : class
    {
        public TState State;
        private List<IObserver<TState>> observers = new List<IObserver<TState>>();

        public Store()
        {
            InitialiseState();
        }

        protected abstract void InitialiseState();

        protected abstract void ProcessDispatchMessage(IStoreMessage message);

        public IDisposable Subscribe(IObserver<TState> observer)
        {
            observers.Add(observer);
            observer.OnNext(State);
            return this;
        }

        public void Dispatch(IStoreMessage message)
        {
            ProcessDispatchMessage(message);
            foreach (var observer in observers)
            {
                observer.OnNext(State);
            }
        }

        public void Dispose()
        {
            if (observers != null)
            {
                observers.Clear();
            }
        }
    }
}
