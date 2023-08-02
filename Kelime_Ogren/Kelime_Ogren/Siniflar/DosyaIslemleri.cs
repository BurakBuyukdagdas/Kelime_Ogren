using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ogren.Siniflar
{
    public class DosyaIslemleri
    {
        public static bool CreateFile(string filepath)
        {
			try
			{
				if (!File.Exists(filepath))
				{
					using (FileStream fs = File.Create(filepath)) { }
				}
				return true;
			}
			catch (System.Exception) { return false; }
			
        }
		public static void RemoveFile(string filePath)
		{
			if (File.Exists(filePath))
				File.Delete(filePath);
		}
		public static void CopyFile(string filePath,string CopyFilePath)
		{
			if (File.Exists(filePath))
			{
				if (File.Exists(CopyFilePath))
					File.Delete(CopyFilePath);
				File.Copy(filePath, CopyFilePath);
			}
		}
		public static void MoveFile(string filePath,string moveFilePath)
		{
			if (File.Exists(filePath))
				File.Move(filePath, moveFilePath);
		}

        public static string ReadFile(string filePath)
        {
            string text;
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.GetEncoding("iso-8859-9")))
            {
                text = streamReader.ReadToEnd();
            }
            return text;
        }

		public static List<string> ReadLinesOfFile(string filePath)  //DOSYA YOLUNU TEK TEK OKUR VE LİST E AKTARIR
		{
			List<string> lines = new List<string>();
			using(StreamReader reader=new StreamReader(filePath, Encoding.UTF8))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
					lines.Add(line);
			}
			return lines;
		}
		public static void WriteToFile(string filePath,string text, bool writeContinueFile)
		{
			if (File.Exists(filePath))
			{
				using (StreamWriter sw = new StreamWriter(filePath, writeContinueFile))
				{
					sw.WriteLine(text);
				}
			}
		}

		public static void WriteLinesToFile(string dosyaYolu,List<string>satirlar)
		{
			string metin = "";
			foreach(string satir in satirlar)
			{
				metin += satir + "\n";
			}
			WriteToFile(dosyaYolu, metin, false);
		}

    }
}
