namespace BookingApp.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}