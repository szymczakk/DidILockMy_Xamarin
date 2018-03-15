using System;
using System.Threading.Tasks;
using DidILockMy.Contracts;
using SQLite;

namespace DidILockMy.Repository
{
    public class LockDatabase
    {
        private readonly ILocalFilePathProvider _filePathProvider;
        private SQLiteAsyncConnection _sqLiteConnection;
        private const string DefaultDbName = "DidILockMy.db";
        private CreateTablesResult _createTablesResult;

        public LockDatabase(ILocalFilePathProvider filePathProvider)
        {
            _filePathProvider = filePathProvider;
            var pathToDb = _filePathProvider.GetPathForFile(DefaultDbName);
            _sqLiteConnection = new SQLiteAsyncConnection(pathToDb);
            _createTablesResult = _sqLiteConnection.CreateTableAsync<Models.LockEntity>().Result;
        }
    }
}