using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace DisoposableDemo
{
    class ConnectionAndMemory : IDisposable
    {
        private static long _totalFreed;
        private static long _totalAllocated;
        public static long TotalFreed { get { return _totalFreed; } }
        public static long TotalAllocated { get { return _totalAllocated; } }

        SqlConnection connection;
        IntPtr chunkHandle;
        private int _chunkSize;
        public ConnectionAndMemory(int chunkSize)
        {
            connection = new SqlConnection
                ("Server=(localdb)\\MSSQLLocalDB;Database=msdb;MultipleActiveResultSets=true");
            connection.Open();
            _chunkSize = chunkSize;

            chunkHandle = Marshal.AllocHGlobal(chunkSize);
            _totalAllocated += chunkSize;
        }
        public void DoWork()
        {

        }

        #region Manual Finalize
        bool isFreed;
        private void FreeChunk()
        {
            if (isFreed) return;
            Marshal.FreeHGlobal(chunkHandle);
            _totalFreed += _chunkSize;
            isFreed = true;

        }
        ~ConnectionAndMemory()
        {
            FreeChunk();
        }
        #endregion

        #region Using Dispose Pattern
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        bool isDisposed;
        protected virtual void Dispose(bool isDisposing)
        {
            if (isDisposed) return;
            if(isDisposing)
            {
                connection.Dispose();
                connection = null;
            }
            FreeChunk();
        }
        #endregion

    }
}
