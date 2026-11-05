namespace ComputerRepairShop.Entities.Enums
{
    [Flags]
    public enum RepairStatus
    {
        None = 0,
        Diagnostics = 1,
        WaitingForParts = 2,
        InProgress = 4,
        Completed = 8,
        Paid = 16
    }
}