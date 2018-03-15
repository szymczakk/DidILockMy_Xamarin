using SQLite;

namespace DidILockMy.Models
{
    public class LockEntity
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        [Indexed]
        public string Name { get; set; }
        public bool IsLocked { get; set; }
    }
}