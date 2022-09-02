using genericTypes.domain.Interfaces.Repositories;

namespace genericTypes.domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        #region PUBLIC OBJECTS
        //IGenericRepository<Order> OrderRepository { get; }
        #endregion

        #region PUBLIC METHODS
        void PersistChanges();
        Task PersistchangesAsync();
        void Dispose();
        #endregion

        #region BULK
        void BulkSaveChanges();
        Task BulkSaveChangesAsync();
        #endregion
    }
}
