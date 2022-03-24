using System;
using System.IO;

namespace Diretorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory e DirectoryInfo

            //var folderName = "pasta";
            //var subFolderName = "subpasta";
            //var subFolderNameStatic = "subpasta_usingstatic";

            //var directoyInfoSubFolder = new DirectoryInfo(subFolderName);

            //if(!Directory.Exists(subFolderName) || !directoyInfoSubFolder.Exists)
            //{
            //    Directory.CreateDirectory(subFolderNameStatic);
            //    Directory.CreateDirectory(folderName);
            //    directoyInfoSubFolder.Create();

            //    directoyInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
            //    Directory.Move(subFolderNameStatic, @$"{folderName}\{subFolderNameStatic}");
            //}

            //var name = directoyInfoSubFolder.Name;
            //var parent = directoyInfoSubFolder.Parent;
            //var root = directoyInfoSubFolder.Root;
            //var exists = directoyInfoSubFolder.Exists;

            //foreach (var directory in Directory.GetDirectories(folderName))
            //{
            //    Console.WriteLine(directory);
            //}

            //Directory.Delete($@"{folderName}\{subFolderName}");

            #endregion

            #region File e FileInfo

            var file = @"pasta\texto.txt";

            if(!File.Exists(file))
            {
                File.CreateText(file);
            }

            var fileInfo = new FileInfo(file);

            Console.WriteLine($"Nome:{fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de atualização: {fileInfo.LastWriteTime}");

            #endregion
        }
    }
}
