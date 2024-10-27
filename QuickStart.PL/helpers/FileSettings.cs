using System.Security.Cryptography;

namespace QuickStart.PL.helpers
{
	public class FileSettings
	{
		public static string UplodeFile(IFormFile file ,string folderName)
		{
			 
			string folderpath=Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);
			string fileName =$"{Guid.NewGuid() }{ file.FileName}";
			string filepath = Path.Combine(folderpath, fileName);
			var fileStream = new FileStream(filepath, FileMode.Create);
			file.CopyTo(fileStream);
			return fileName;
		}
		public static void Delete(string fileName,string folderName)
		{
			string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
			if(File.Exists(filepath))
			{
				File.Delete(filepath);
			}
		}
	}
}
