namespace Harbor
{
    public interface IShip
    {
        string Name { get; set; }
        Enums.ShipTypes ShipType { get; set; }
        string Color { get; set; }
        decimal Length { get; set; }
        string BeepSound();
    }
}