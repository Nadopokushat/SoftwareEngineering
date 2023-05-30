#region Task1
void SortFiles(string path)
{
    if (!Directory.Exists(path))
    {
        throw new ArgumentException("The directory {0} is not exists.", path);
    }

    string[] files = Directory.GetFiles(path);

    foreach (string file in files)
    {
        FileInfo fileInfo = new FileInfo(file);
        string fileExtension = fileInfo.Extension.Remove(0, 1);
        string newPath = Path.Combine(path, fileExtension);
        Directory.CreateDirectory(newPath);
        fileInfo.MoveTo(Path.Combine(newPath, fileInfo.Name));
    }
}
#endregion

#region Task2
void DirectoryTree(string path, byte nesting)
{
    if (!Directory.Exists(path))
    {
        throw new ArgumentException("The directory {0} is not exists.", path);
    }

    string[] directories = Directory.GetDirectories(path);

    foreach (string directory in directories)
    {
        Console.WriteLine(directory);

        if (nesting > 1)
        {
            DirectoryTree(directory, (byte)(nesting - 1));
        }
    }
}
#endregion