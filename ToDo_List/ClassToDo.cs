﻿using System;
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
            Console.WriteLine("Вот список существующих заметок:");
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
        if (notes.Count == 0)
        {
            Console.WriteLine("Список пуст");
            Console.WriteLine();
        }
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


    public void ChangeOfStatus(string? id, string status)
    {
        var thisNote = Search(id);
        if (thisNote == null)
        {
            Console.WriteLine("Заметки с таким Id не существует, \n или вы ничего не ввели");
            Console.WriteLine();
        }
        else
        {
            thisNote.Remove("Status");
            thisNote.Add("Status", status);
            Console.WriteLine("Статус успешно изменён");
            Console.WriteLine();
        }
    }
}

