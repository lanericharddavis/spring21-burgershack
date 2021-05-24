using burgershack.Enums;

namespace burgershack.Interfaces
{
    public interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Cost { get; set; }
        int Quantity { get; set; }
        string Modifications { get; set; }
        ItemType ItemType { get; }
    }



}