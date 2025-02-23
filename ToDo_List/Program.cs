using ToDo_List;

List<Note> notes = new();
ClassToDo todo = new ClassToDo(notes);
string? task;
int id;
Status status;
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

            var res = Enum.TryParse(Console.ReadLine(), out status);

            if (res)
            {
                todo.CreateNote(name, text, status);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Console.WriteLine();
            }

            break;

        case "2":
            Console.Write("Введите Id заметки, которую хотите удалить: ");
            res = int.TryParse(Console.ReadLine(), out id);

            if (!res)
            {
                Console.WriteLine("Вы ничего не ввели"); // ??
                break;
            }

            todo.RemoveNote(id);
            break;

        case "3":
            todo.ShowAllNotes();
            break;

        case "4":
            Console.Write("Введите Id заметки:");
            res = int.TryParse(Console.ReadLine(), out id);
            todo.SearchByID(id);

            if (!res)
            {
                Console.WriteLine("Вы ничего не ввели"); // ?? 
                break;
            }

            break;

        case "5":
            Console.Write("Введите Id заметки:");
            res = int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine();

            if (!res)
            {
                Console.WriteLine("Вы ничего не ввели"); // ??
                break;
            }

            Console.WriteLine("Выберете новый статус");
            Console.WriteLine("Выберите статус заметки: ");
            Console.WriteLine("1. Планируется");
            Console.WriteLine("2. Выполняется");
            Console.WriteLine("3. Завершено");
            Console.WriteLine("0. Назад");

            res = Enum.TryParse(Console.ReadLine(), out status);

            if (res)
            {
                todo.ChangeNoteStatus(id, status);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение"); // +
            }

            break;

        case "":
            Console.WriteLine("Вы ничего не ввели, нажмите '0', если хотите выйти из программы");
            break;
        default:
            Console.WriteLine("Вы ввели какую-то хрень"); // )))
            break;
    }

} while (task != "0");