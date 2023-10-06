using pasantia_prototype.process.interfaces;
using pasantia_prototype.process.base_class;
using System;

namespace pasantia_prototype.process.services
{
    internal class FileHandlerServ : IFileHanlder
    {
        private static readonly IFileHanlder _fileHandler = FileHandlerWin.get_instance();
        FileHandlerServ()
        {
            
        }

        public static object get_instance()
        {
            return _fileHandler;
        }

        public void set_permissions()
        {
            _fileHandler.set_permissions();
        }

        public string base_dir()
        {
            return _fileHandler.base_dir();
        }

        public void verify_dirs()
        {
            _fileHandler.verify_dirs();
        }

        public void verify_files()
        {
            _fileHandler.verify_files();
        }

        public object copy_file(string path, string newPath)
        {
            return _fileHandler.copy_file(path, newPath);
        }

        public object copy_file(string path, string newPath, object exception)
        {
            return _fileHandler.copy_file(path, newPath, exception);
        }

        public object create_file(string path, object content)
        {
            return _fileHandler.create_file(path, content);
        }

        public object create_file(string path, object content, object exception)
        {
            return _fileHandler.create_file(path, content, exception);
        }

        public object delete_file(string path)
        {
            return _fileHandler.delete_file(path);
        }

        public object delete_file(string path, object exception)
        {
            return _fileHandler.delete_file(path, exception);
        }

        public object read_file(string path)
        {
            return _fileHandler.read_file(path);
        }

        public object read_file(string path, object exception)
        {
            return _fileHandler.read_file(path, exception);
        }

        public object modify_file(string path, object content)
        {
            return _fileHandler.modify_file(path, content);
        }

        public object modify_file(string path, object content, object exception)
        {
            return _fileHandler.modify_file(path, content, exception);
        }

        public void set_prjFolder(string path)
        {
            _fileHandler.set_prjFolder(path);
        }

        public void set_imgFolder(string path)
        {
            _fileHandler.set_imgFolder(path);
        }

        public void set_baseFolder(string path)
        {
            _fileHandler.set_baseFolder(path);
        }

        public string get_baseFolder()
        {
            return _fileHandler.get_baseFolder();
        }

        public string get_prjFolder()
        {
            return _fileHandler.get_prjFolder();
        }

        public string get_imgFolder()
        {
            return _fileHandler.get_imgFolder();
        }

        public string[] get_imgPaths()
        {
            return _fileHandler.get_imgPaths();
        }

        public string[] get_prjPaths()
        {
            return _fileHandler.get_prjPaths();
        }

        public object get_fileInfo(string path)
        {
            return _fileHandler.get_fileInfo(path);
        }
    }
}
