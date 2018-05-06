using System;
using System.Collections.Generic;
using System.Linq;

namespace ReduxConsole
{
    public class ToDosState
    {
        private List<ToDo> _toDos = new List<ToDo>();
        public IReadOnlyList<ToDo> ToDos => _toDos;

        public void AddToDo(ToDo toDo)
        {
            if (ToDos.Any(x => x.Description == toDo.Description))
            {
                throw new InvalidOperationException("Todo with same description can not be added");
            }
            _toDos.Add(toDo);
        }

    }
}
