using System.IO;

namespace WinBoostUtility
{
    public class StorageAnalyzer
    {
        public long GetFreeSpace(string drive)
        {
            DriveInfo info = new DriveInfo(drive);
            return info.AvailableFreeSpace;
        }
    }
}
