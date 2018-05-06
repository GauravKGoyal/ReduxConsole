using System;
using System.Collections.Generic;
using System.Linq;

namespace ReduxConsole
{
    public class ToDoController : IObserver<ToDosState>
    {
        public ToDoStore ToDoStore { get; set; }
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }

        public ToDoController()
        {
            ToDoStore = new ToDoStore();
            ToDoStore.Subscribe(this);
        }

        public List<ToDoProp> ToDos { get; set; }

        public void AddToDos(ToDoProp todo)
        {
            var message = new AddToDoMessage() { Description = todo.Description, Done = todo.Done };
            ToDoStore.Dispatch(message);
        }

        //public void UpdateToDo(ToDoProp toDo, bool done)
        //{

        //}

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ToDosState value)
        {
            ToDos = value.ToDos.Select(x => new ToDoProp { Description = x.Description, Done = x.Done }).ToList();
        }
    }
}
