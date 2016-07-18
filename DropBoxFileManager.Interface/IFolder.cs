using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropBoxFileManager.Model;

namespace DropBoxFileManager.Interface
{
    public interface IFolder
    {
        void addFolder(Folder _file);
        void removeFolder(Folder _file);
        Folder getFolderDetails(string _fileInfo);
    }
}
