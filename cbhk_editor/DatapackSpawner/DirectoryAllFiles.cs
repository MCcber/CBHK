using System.Collections.Generic;
using System.IO;

namespace cbhk_editor.DatapackSpawner
{
    class DirectoryAllFiles
    {
		private static List<FileInformation> FileList = new List<FileInformation>();

		public static List<FileInformation> GetAllFiles(DirectoryInfo dir, bool NeedAdd)
		{
			FileInfo[] allFile = dir.GetFiles();
			FileInfo[] array = allFile;
			foreach (FileInfo fi in array)
			{
				if (NeedAdd)
				{
					FileList.Add(new FileInformation
					{
						FileName = fi.Name,
						FilePath = fi.FullName
					});
				}
			}
			DirectoryInfo[] allDir = dir.GetDirectories();
			DirectoryInfo[] array2 = allDir;
			foreach (DirectoryInfo d in array2)
			{
				if (d.Name == "structures" || d.Name == "advancements" || d.Name == "loot_tables" || d.Name == "recipes" || d.Name == "tags" || d.Name == "functions")
				{
					NeedAdd = true;
				}
				GetAllFiles(d, NeedAdd);
			}
			return FileList;
		}
	}

	public class FileInformation
	{
		public string FileName
		{
			get;
			set;
		}

		public string FilePath
		{
			get;
			set;
		}
	}
}
