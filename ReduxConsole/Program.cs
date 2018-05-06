using System;
using System.Linq;

namespace ReduxConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var controller = new ToDoController();

            DisplayResult(controller);


            while (true)
            {
                if (Console.ReadLine() == "a")
                {
                    Console.Clear();
                    controller.AddToDos(new ToDoProp() { Description = "new Todo" });
                    DisplayResult(controller);
                }
                else
                {
                    break;
                }
            }
        }

        private static void DisplayResult(ToDoController controller)
        {
            var str = string.Join("\n", controller.ToDos.Select(x => x.ToString()));
            Console.WriteLine(str);
        }
    }

    
}
