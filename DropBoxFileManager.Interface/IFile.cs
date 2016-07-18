using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DropBoxFileManager.Model;

namespace DropBoxFileManager.Interface
{
    interface IFile
    {
        void addfile(File _file);
        void removeFile(File _file);
        File getFileDetails(string _fileInfo);
    }
}
