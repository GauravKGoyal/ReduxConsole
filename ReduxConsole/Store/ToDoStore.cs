namespace ReduxConsole
{

    public class ToDoStore : Store<ToDosState>
    {
        protected override void InitialiseState()
        {
            State = new ToDosState();
            State.AddToDo(new ToDo(description: "Redux", done: false));
            State.AddToDo(new ToDo(description: "TopShelf", done: false));
            State.AddToDo(new ToDo(description: "Microservice", done: false));
            State.AddToDo(new ToDo(description: "Azure", done: false));
        }

        protected override void ProcessDispatchMessage(IStoreMessage message)
        {
            switch (message)
            {
                case AddToDoMessage m:
                    State.AddToDo(new ToDo(description: m.Description, done: m.Done));
                    break;
                default:
                    break;
            }
        }
    }
}
