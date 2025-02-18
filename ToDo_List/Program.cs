using ToDo_List;

int task;
do
{
    Console.WriteLine("1. Создать заметку");
    Console.WriteLine("2. Удалить заметку");
    Console.WriteLine("3. Просмотр всех заметок");
    Console.WriteLine("4. Поиск заметки по Id");
    Console.WriteLine("5. Изменить статус заметки");
    Console.WriteLine("0. Выход");
    task = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    ClassToDo toDo = new ClassToDo();
    switch (task)
    {
        case 1:
            Console.Write("Введите название заметки: ");
            string name = Console.ReadLine();
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
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
        case 2:
            break;
        case 3:
            toDo.ShowAllNote();
            break;
        case 4:
            Console.Write("Введите Id заметки:");
            string? id = Console.ReadLine();
            toDo.SearchByID(id);
            if (id == null)
            {
                Console.WriteLine("Вы ввели пустой Id, можете попробовать снова");
                break;
            }
            break;
    }

} while (task != 0);