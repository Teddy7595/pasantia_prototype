using pasantia_prototype.process.interfaces;
using System.Security.AccessControl;
using System.Linq;
using System.IO;
using System;

namespace pasantia_prototype.process.base_class
{
    internal class FileHandlerWin : IFileHanlder
    {
        private static FileHandlerWin _fileHandlerWin;
        private string _docfolderPath;
        private string[] _paths { get; set; }
        private string[] _projPaths;
        private string[] _imgPaths;
        private string   _imgFolder;
        private string   _prjFolder; 

        FileHandlerWin() 
        { 

            this._docfolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this._imgFolder     = "img_visualizer";
            this._prjFolder     = "prj_visualizer";

            this._paths = new string[] { 
                $"{this._docfolderPath}\\{this._imgFolder}",
                $"{this._docfolderPath}\\{this._prjFolder}"
            };
        }

        public void set_permissions()
        {
            DirectoryInfo dir1 = new DirectoryInfo(this._paths[0]);
            DirectoryInfo dir2 = new DirectoryInfo(this._paths[1]);

            DirectorySecurity dirSec1 = dir1.GetAccessControl(AccessControlSections.Access);
            DirectorySecurity dirSec2 = dir2.GetAccessControl(AccessControlSections.Access);

            dirSec1.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));
            dirSec2.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.ReadAndExecute, AccessControlType.Allow));

            dir1.SetAccessControl(dirSec1);
            dir2.SetAccessControl(dirSec2);
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
        }

        public string base_dir()
        {
            return Environment.CurrentDirectory;
        }

        public object copy_file(string path, string newPath)
        {
            try 
            {
                //byte[] buffer = File.ReadAllBytes(path);
                //File.WriteAllBytes(newPath, buffer);
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
            try
            {
                File.Delete(path);
                return "completed";
            }
            catch (IOException e)
            {
                return $"No se pudo crear el archivo {e.Message}";
            }
        }

        public object delete_file(string path, object exception)
        {
            try
            {
                File.Delete(path);
                return "completed";
            }
            catch (IOException e)
            {
                return $"No se pudo crear el archivo {e.Message}";
            }
        }

        public object read_file(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (IOException e)
            {
                return null;
            }
        }

        public object read_file(string path, object exception)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (IOException e)
            {
                return null;
            }
        }

        public object modify_file(string path, object content)
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

        public object modify_file(string path, object content, object exception)
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

        public void set_prjFolder(string path)
        {
            this._prjFolder = path;
        }

        public void set_imgFolder(string path)
        {
            this._imgFolder = path;
        }

        public string get_prjFolder()
        {
            return this._prjFolder;
        }

        public string get_imgFolder()
        {
            return this._imgFolder;
        }

        public string[] get_imgPaths()
        {
            return this._imgPaths;
        }

        public string[] get_prjPaths()
        {
            return this._projPaths;
        }

        public void set_baseFolder(string path)
        {
            this._docfolderPath = path;
        }

        public string get_baseFolder()
        {
            return this._docfolderPath;
        }

        public object get_fileInfo(string path)
        {
            try
            {
                return new FileInfo(path);
            }
            catch (IOException e)
            {
                return null;
            }
        }
    }
}
