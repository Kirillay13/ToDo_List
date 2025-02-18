using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List;


class ClassToDo
{
    private int id = 1;
    private List<Dictionary<string, string>> notes;
    public ClassToDo(List<Dictionary<string, string>> notes)
    {
        this.notes = notes;
    }
    public void CreateNote(string name, string text, string status)
    {
        Dictionary<string, string> note = new Dictionary<string, string>()
        {
            { "Id", id.ToString() },
            { "Name", name },
            { "Text", text },
            { "Status", status }
        };
        notes.Add(note);
        Console.WriteLine($"Id заметки: {id}");
        id++;
        Console.WriteLine("Заметка успешно создана");
    }

    Dictionary<string, string>? Search(string? id)
    {
        if (id == null)
        {
            return null;
        }
        Dictionary<string, string> result = new Dictionary<string, string>();
        for (int i = 0; i < notes.Count; i++)
        {
            if (notes[i]["Id"].ToString() == id)
            {
                return result = notes[i];
            }
        }
        return null;
    }

    public void RemoveNote(string? id)
    {
        var res = Search(id);
        if (res == null)
        {
            Console.WriteLine("Заметки с таким Id не существует");
            Console.WriteLine();
            ShowAllNote();
        }
        else
        {
            notes.Remove(res);
            Console.WriteLine("Заметка успешно удалена");
            Console.WriteLine();
        }
    }


    public void ShowAllNote()
    {
        foreach (var note in notes)
        {
            Console.WriteLine($"Id: {note["Id"]}");
            Console.WriteLine($"Name: {note["Name"]}");
            Console.WriteLine($"Text: {note["Text"]}");
            Console.WriteLine($"Status: {note["Status"]}");
            Console.WriteLine();

        }
    }


    public void SearchByID(string? id)
    {
        var res = Search(id);
        if (res == null)
        {
            Console.WriteLine("Заметки с таким Id не существует");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Id: {res["Id"]}");
            Console.WriteLine($"Name: {res["Name"]}");
            Console.WriteLine($"Text: {res["Text"]}");
            Console.WriteLine($"Status: {res["Status"]}");
            Console.WriteLine();
        }
    }


    public void ChangeOfStatus(string id, string status)
    {
        var thisNote = Search(id);
        if (thisNote == null)
        {
            Console.WriteLine("Заметки с таким Id не существует");
            Console.WriteLine();
        }
        else
        {
            thisNote.Remove("Status");
            thisNote.Add("Status", status);
            Console.WriteLine("Изменение произошло успешно");
            Console.WriteLine();
        }
    }


    //public bool Validation()
    //{

    //    return;
    //}



    //public void SearchByID(string id)
    //{
    //    for (int i = 0; i < notes.Count; i++)
    //    {
    //        if (notes[i]["Id"].ToString() == id)
    //        {
    //            var ournote = notes[i];
    //            Console.WriteLine($"Id: {ournote["Id"]}");
    //            Console.WriteLine($"Name: {ournote["Name"]}");
    //            Console.WriteLine($"Text: {ournote["Text"]}");
    //            Console.WriteLine($"Status: {ournote["Status"]}");
    //            Console.WriteLine();
    //            return;
    //        }
    //    }
    //    Console.WriteLine("Заметки с таким Id не существует");
    //    Console.WriteLine();
    //}


    //public void RemoveNote(string id)
    //{
    //    for(int i = 0; i < notes.Count; i++)
    //    {
    //        if (notes[i]["Id"].ToString() == id)
    //        {
    //            notes.RemoveAt(i);
    //            Console.WriteLine("Заметка успешно удалена");
    //            return;
    //        }
    //    }
    //    Console.WriteLine("Данный Id не найден");
    //    ShowAllNote();
    //}
}

