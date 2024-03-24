using DnDProject.Data.Basic;
namespace DnDProject.Data.Items
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public Coins Value { get; set; }
    }
}
