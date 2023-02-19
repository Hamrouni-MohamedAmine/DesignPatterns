namespace Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public abstract long GetSize();

        public FileSystemItem(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// Leaf
    /// </summary>
    public class File : FileSystemItem
    {
        private long _size;

        public File(string name, long size) : base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            return _size;
        }
    }

    /// <summary>
    /// Composite
    /// </summary>
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _fileSystemItems = new List<FileSystemItem>();

        private long _size;

        public Directory(string name, long size) : base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach(var fileSystemItem in _fileSystemItems)
            {
                treeSize+= fileSystemItem.GetSize();
            }
            return treeSize;
        }

        public void Add(FileSystemItem item)
        {
            _fileSystemItems.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            _fileSystemItems.Remove(item);
        }
    }
}
