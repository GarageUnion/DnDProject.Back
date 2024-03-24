namespace DnDProject.Data.Items
{
    public class Tool
    {
        public string ToolType { get; set; }
        public List<string> Actions { get; set; } // Класс действие{Название; описание; сложность}
        public List<string> Items { get; set; }
    }
}
