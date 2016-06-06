using Harbour.Enums;

namespace ShipInterface
{
    public interface IShip
    {
        string Name { get; set; }
        Enums.ShipTypes IncomeShipType { get; set; }
        string GetBeep();
    }
}