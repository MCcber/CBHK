using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbhk_editor.DatapackSpawner
{
    class CompareFile : IEqualityComparer<FileInformation>
    {
		public bool Equals(FileInformation x, FileInformation y)
		{
			return x.FileName == y.FileName;
		}

		public int GetHashCode(FileInformation obj)
		{
			return obj.FileName.GetHashCode();
		}
	}
}
