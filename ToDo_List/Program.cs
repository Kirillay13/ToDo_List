using ToDo_List;

ClassToDo user = new();
user.CreateNote("Сделать ToDoList",
    "Реализовать функции",
    "В процессе");

user.CreateNote("Задача",
    "Сделать функцию поиска одного словаря",
    "В процессе");
user.CreateNote("Задача2",
    "Менять статус",
    "В процессе");

user.ShowAllNote();
Console.WriteLine("---------------");
user.ChangeOfStatus("2", "Выполнено");
user.SearchByID("2");