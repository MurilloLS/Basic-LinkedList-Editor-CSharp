namespace DayFour.TextEditorContext
{
  public class TextEditor
  {
    private readonly LinkedList<string> document;

    public TextEditor()
    {
      document = new LinkedList<string>();
    }

    public void AddLine(string text)
    {
      document.AddLast(text);
    }

    public void InsertLine(int index, string text)
    {
      if (index < 0 || index > document.Count)
      {
        throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
      }

      if (index == document.Count)
      {
        document.AddLast(text);
      }
      else
      {
        var node = GetNodeAt(index);
        document.AddBefore(node, text);
      }
    }

    public void RemoveLine(int index)
    {
      if (index < 0 || index >= document.Count)
      {
        throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
      }

      var node = GetNodeAt(index);
      document.Remove(node);
    }

    public void DisplayDocument()
    {
      int lineNumber = 1;
      foreach (var line in document)
      {
        Console.WriteLine($"{lineNumber}: {line}");
        lineNumber++;
      }
    }

    private LinkedListNode<string> GetNodeAt(int index)
    {
      var current = document.First;
      for (int i = 0; i < index; i++)
      {
        current = current.Next;
      }
      return current;
    }
  }
}
