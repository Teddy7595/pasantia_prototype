using pasantia_prototype.process.interfaces;
using System.Linq;
using System.IO;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class FileHandlerWin : IFileHanlder
    {
        private static FileHandlerWin _fileHandlerWin;
        private readonly string _docfolderPath;
        private string[] _paths { get; set; }
        public  string[] _projPaths { get; set;}
        public  string[] _imgPaths { get; set; }
        public  string   _imgFolder { get; set; }
        public  string   _prjFolder { get; set; }

        FileHandlerWin() 
        { 

            this._docfolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this._imgFolder     = "img_visualizer";
            this._prjFolder     = "prj_visualizer";

            this._paths = new string[] { 
                $"{this._docfolderPath}\\{this._imgFolder}",
                $"{this._docfolderPath}\\{this._prjFolder}"
            };
        }

        public static FileHandlerWin get_instance()
        {
            if (_fileHandlerWin == null)
            {
                _fileHandlerWin = new FileHandlerWin();
            }
             
            return _fileHandlerWin; 
        }

        public void verify_dirs()
        {
            this._paths.ToList().ForEach((path) =>
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Se creo el directorio {path}");
                }else
                    Console.WriteLine($"El directorio {path} ya existe");
            });
        }

        public void verify_files()
        {
            this._paths.ToList().ForEach((path) =>
            {
                if (Directory.Exists(path) && path.Contains(this._imgFolder))
                    this._imgPaths = Directory.GetFiles(path);

                if (Directory.Exists(path) && path.Contains(this._prjFolder))
                    this._projPaths = Directory.GetFiles(path);
            });

            this._imgPaths.ToList().ForEach((path) =>
            {
                Console.WriteLine($"Imagenes: {path}");
            });
        }

        public string base_dir()
        {
            return Environment.CurrentDirectory;
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
