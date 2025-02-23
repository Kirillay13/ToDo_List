using System.Text;

namespace ToDo_List
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Status Status { get; set; }
        public string Name {  get; set; }

        public override string ToString()
        {
            StringBuilder sb = new ();

            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Text: {Text}");

            switch (Status)
            {
                case Status.InPlan:
                    sb.AppendLine($"Status: Планируется");
                    break;
                case Status.Done:
                    sb.AppendLine($"Status: Завершено");
                    break;
                case Status.InProgress:
                    sb.AppendLine($"Status: Выполняется");
                    break;
            }

            return sb.ToString();
        }
    }

    public enum Status
    {
        InPlan = 1,
        InProgress = 2,
        Done = 3,
    }
}
