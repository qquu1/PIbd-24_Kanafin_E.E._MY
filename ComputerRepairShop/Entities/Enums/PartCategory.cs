namespace ComputerRepairShop.Entities.Enums
{
    [Flags]
    public enum PartCategory
    {
        None = 0,
        CPU = 1,
        RAM = 2,
        Storage = 4,
        Power = 8,
        Peripherals = 16
    }
}