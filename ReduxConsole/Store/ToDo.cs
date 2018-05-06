namespace ReduxConsole
{
    public class ToDo
    {
        public ToDo(string description, bool done)
        {
            Description = description;
            Done = done;
        }
        public string Description { get; private set; }
        public bool Done { get; private set; }
    }
}
