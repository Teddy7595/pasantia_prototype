using pasantia_prototype.process.interfaces;
using System;
using System.IO;

namespace pasantia_prototype.process.base_class
{
    internal class FileHandlerWin : IFileHanlder
    {
        public FileHandlerWin() 
        { 
            
        }

        public object copy_file(string path, string newPath)
        {
            try 
            {
                File.Copy(path, newPath);
                return "completed";
            }
            catch (IOException e) 
            {
                return $"No se pudo realizar la copia {e.Message}";
            }
        }

        public object copy_file(string path, string newPath, object exception)
        {
            try
            {
                File.Copy(path, newPath);
                return "completed";
            }
            catch (IOException e)
            {
                return $"No se pudo realizar la copia {e.Message}";
            }
        }

        public object create_file(string path, object content)
        {
            try
            {
                File.WriteAllText(path, content.ToString());
                return "completed";
            }
            catch (IOException e)
            {
                return $"No se pudo crear el archivo {e.Message}";
            }
        }

        public object create_file(string path, object content, object exception)
        {
            try
            {
                File.WriteAllText(path, content.ToString());
                return "completed";
            }
            catch (IOException e)
            {
                return $"No se pudo crear el archivo {e.Message}";
            }
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
