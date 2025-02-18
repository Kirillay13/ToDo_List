using ToDo_List;
// можно после поиска по id добатить окошко с функциями изменить название или текст
string? task;
List<Dictionary<string, string>> notes = new List<Dictionary<string, string>>();
ClassToDo toDo = new ClassToDo(notes);
do
{
    Console.WriteLine("1. Создать заметку");
    Console.WriteLine("2. Удалить заметку");
    Console.WriteLine("3. Просмотр всех заметок");
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
            int status;
            do
            {
                Console.WriteLine("Выберите статус заметки: ");
                Console.WriteLine("1. Планируется");
                Console.WriteLine("2. Выполняется");
                Console.WriteLine("3. Завершено");
                Console.WriteLine("0. Назад");
                status = Convert.ToInt32(Console.ReadLine());
                if (status == 1)
                {
                    toDo.CreateNote(name, text, "Планируется");
                    break;
                }
                else if (status == 2)
                {
                    toDo.CreateNote(name, text, "Выполняется");
                    break;
                }
                else
                {
                    toDo.CreateNote(name, text, "Завершено");
                    break;
                }
            } while (status != 0);
            Console.WriteLine();
            break;
        case "2":
            break;
        case "3":
            toDo.ShowAllNote();
            break;
        case "4":
            Console.Write("Введите Id заметки:");
            string? id = Console.ReadLine();
            toDo.SearchByID(id);
            if (id == null)
            {
                Console.WriteLine("Вы ввели пустой Id, можете попробовать снова");
                break;
            }
            break;
        
        case "5":
            break;
        case null:
            Console.WriteLine("Вы ничего не ввели, нажмите '0', если хотите выйти из программы");
            Console.WriteLine();
            break;
    }

} while (task != "0");