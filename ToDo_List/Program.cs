using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using ToDo_List;

List<Dictionary<string, string>> notes = new List<Dictionary<string, string>>();
ClassToDo todo = new ClassToDo(notes);
string? task;
string? id;
string? status;
do
{
    Console.WriteLine("1. Создать заметку");
    Console.WriteLine("2. Удалить заметку");
    Console.WriteLine("3. Список заметок");
    Console.WriteLine("4. Поиск заметки по Id");
    Console.WriteLine("5. Изменить статус заметки");
    Console.WriteLine("0. Выход");
    task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "1":
            Console.Write("Введите название заметки: ");
            string? name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Имя должно быть обязательно\n можете попробовать создать заметку его ещё раз");
                break;
            }
            Console.Write("Введите текст: ");
            string? text = Console.ReadLine();
            if (text == null)
            {
                text = "Undefined";
            }
            Console.WriteLine("Выберите статус заметки: ");
            Console.WriteLine("1. Планируется");
            Console.WriteLine("2. Выполняется");
            Console.WriteLine("3. Завершено");
            Console.WriteLine("0. Назад");
            status = Console.ReadLine();
            if (status == "1")
            {
                todo.CreateNote(name, text, "Планируется");
                Console.WriteLine();
                break;
            }
            else if (status == "2")
            {
                todo.CreateNote(name, text, "Выполняется");
                Console.WriteLine();
                break;
            }
            else if (status == "3")
            {
                todo.CreateNote(name, text, "Завершено");
                Console.WriteLine();
                break;
            }
            else if (status == null)
            {
                Console.WriteLine("Вы ничего не ввели");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Console.WriteLine();
                break;
            }

        case "2":
            Console.Write("Введите Id заметки, которую хотите удалить: ");
            id = Console.ReadLine();
            if (id == null)
            {
                Console.WriteLine("Вы ничего не ввели");
                break;
            }
            todo.RemoveNote(id);
            break;

        case "3":
            todo.ShowAllNote();
            break;

        case "4":
            Console.Write("Введите Id заметки:");
            id = Console.ReadLine();
            todo.SearchByID(id);
            if (id == null)
            {
                Console.WriteLine("Вы ничего не ввели");
                break;
            }
            break; 
            
        case "5":
            Console.Write("Введите Id заметки:");
            id = Console.ReadLine();
            Console.WriteLine();
            if (id == null)
            {
                Console.WriteLine("Вы ничего не ввели");
                break;
            }
            Console.WriteLine("Выберете новый статус");
            Console.WriteLine("Выберите статус заметки: ");
            Console.WriteLine("1. Планируется");
            Console.WriteLine("2. Выполняется");
            Console.WriteLine("3. Завершено");
            Console.WriteLine("0. Назад");
            status = Console.ReadLine();
            if (status == "0")
            {
                break;
            }
            else if(status == "1")
            {
                todo.ChangeOfStatus(id, "Планируется");
                break;
            }
            else if (status == "2")
            {
                todo.ChangeOfStatus(id, "Выполняется");
                break;
            }
            else if (status == "3")
            {
                todo.ChangeOfStatus(id, "Завершено");
                break;
            }
            else if (status == null)
            {
                Console.WriteLine("Вы ничего не ввели");
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
                break;
            }
            

        case "":
                    Console.WriteLine("Вы ничего не ввели, нажмите '0', если хотите выйти из программы");
                    break;
                }

} while (task != "0");