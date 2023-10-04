namespace pasantia_prototype.process.interfaces
{
    public interface IFileHanlder
    {
        object verify_dirs();
        string base_dir();
        object list_files(string folder);
        object list_files(string folder, object exception);
        object open_file(string path);
        object open_file(string path, object exception);
        object create_file(string path, object content);
        object create_file(string path, object content, object exception);
        object move_file(string path, object content);
        object move_file(string path, object content, object exception);
        object delete_file(string path);
        object delete_file(string path, object exception);
        object copy_file(string path, string newPath);
        object copy_file(string path, string newPath, object exception);

    }
}
