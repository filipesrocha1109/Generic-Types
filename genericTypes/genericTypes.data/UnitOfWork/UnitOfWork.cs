using genericTypes.data.Context;
using genericTypes.domain.Interfaces.UnitOfWork;

namespace genericTypes.data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region FIELDS
        private readonly CompanyContext _context;
        #endregion

        #region CTOR
        public UnitOfWork(CompanyContext context)
        {
            _context = context;
        }
        #endregion

        #region PUBLIC OBJECTS
        //public IGenericRepository<Order> OrderRepository => new GenericRepository<Order>(_context);
        #endregion

        #region PUBLIC METHODS
        public void PersistChanges()
        {
            _context.SaveChanges();
        }
        public async Task PersistchangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

        #region  BULK
        public void BulkSaveChanges()
        {
            _context.BulkSaveChanges();
        }
        public async Task BulkSaveChangesAsync()
        {
            await _context.BulkSaveChangesAsync();
        }
        #endregion

        #region DISPOSABLE
        bool disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_context != null)
                    {
                        _context.Dispose();
                    }
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
