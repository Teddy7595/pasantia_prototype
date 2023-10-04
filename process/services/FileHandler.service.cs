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
            throw new NotImplementedException();
        }

        public object copy_file(string path, string newPath, object exception)
        {
            throw new NotImplementedException();
        }

        public object create_file(string path, object content)
        {
            throw new NotImplementedException();
        }

        public object create_file(string path, object content, object exception)
        {
            throw new NotImplementedException();
        }

        public object delete_file(string path)
        {
            throw new NotImplementedException();
        }

        public object delete_file(string path, object exception)
        {
            throw new NotImplementedException();
        }

        public object list_files(string folder)
        {
            throw new NotImplementedException();
        }

        public object list_files(string folder, object exception)
        {
            throw new NotImplementedException();
        }

        public object move_file(string path, object content)
        {
            throw new NotImplementedException();
        }

        public object move_file(string path, object content, object exception)
        {
            throw new NotImplementedException();
        }

        public object open_file(string path)
        {
            throw new NotImplementedException();
        }

        public object open_file(string path, object exception)
        {
            throw new NotImplementedException();
        }
    }
}
