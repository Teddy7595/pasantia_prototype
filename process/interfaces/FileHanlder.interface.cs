namespace pasantia_prototype.process.interfaces
{
    public interface IFileHanlder
    {
        void set_permissions();
        void verify_dirs();
        void verify_files();
        void set_prjFolder(string path);
        void set_imgFolder(string path);
        void set_baseFolder(string path);
        string base_dir();
        string get_baseFolder();
        string get_prjFolder();
        string get_imgFolder();
        string[] get_imgPaths();
        string[] get_prjPaths();
        object get_fileInfo(string path);
        object read_file(string path);
        object read_file(string path, object exception);
        object create_file(string path, object content);
        object create_file(string path, object content, object exception);
        object modify_file(string path, object content);
        object modify_file(string path, object content, object exception);
        object delete_file(string path);
        object delete_file(string path, object exception);
        object copy_file(string path, string newPath);
        object copy_file(string path, string newPath, object exception);

    }
}
