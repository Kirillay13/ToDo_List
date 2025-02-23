namespace ToDo_List;


class ClassToDo
{
    private int id = 1;
    private List<Note> notes;
    public ClassToDo(List<Note> notes)
    {
        this.notes = notes;
    }
    public void CreateNote(string name, string text, Status status)
    {
        var note = new Note()
        {
            Id = id,
            Text = text,
            Status = status,
            Name = name
        };

        notes.Add(note);
        Console.WriteLine($"Id заметки: {id++}");
        Console.WriteLine("Заметка успешно создана");
    }

    private Note Search(int id)
    {
        return notes.FirstOrDefault(x => x.Id == id);
    }

    public void RemoveNote(int id)
    {
        var res = Search(id);

        if (res == null)
        {
            Console.WriteLine("Заметки с таким Id не существует");
            Console.WriteLine("Вот список существующих заметок:");
            ShowAllNotes();
        }
        else
        {
            notes.Remove(res);
            Console.WriteLine("Заметка успешно удалена");
            Console.WriteLine();
        }
    }

    public void ShowAllNotes()
    {
        if (notes.Count == 0)
        {
            Console.WriteLine("Список пуст");
            Console.WriteLine();
        }
        foreach (var note in notes)
        {
            Console.WriteLine(note + Environment.NewLine);
        }
    }


    public void SearchByID(int id)
    {
        var res = Search(id);

        if (res == null)
        {
            Console.WriteLine("Заметки с таким Id не существует");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(res + Environment.NewLine);
        }
    }


    public void ChangeNoteStatus(int id, Status status)
    {
        var thisNote = Search(id);

        if (thisNote == null)
        {
            Console.WriteLine("Заметки с таким Id не существует, \n или вы ничего не ввели");
            Console.WriteLine();
        }
        else
        {
            thisNote.Status = status;
            Console.WriteLine("Статус успешно изменён");
            Console.WriteLine();
        }
    }
}

