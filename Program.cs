using DayFour.TextEditorContext;

namespace DayFour
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      TextEditor editor = new TextEditor();
      editor.AddLine("Primeira linha");
      editor.AddLine("Segunda linha");
      editor.InsertLine(1, "Linha inserida");
      editor.RemoveLine(0);

      Console.WriteLine("Conteúdo do Documento:");
      editor.DisplayDocument();
    }
  }
}

