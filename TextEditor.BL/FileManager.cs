﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.BL
{
	public interface IFileManager
	{
		string GetContent(string filePath);
		string GetContent(string filePath, Encoding encoding);
		void SaveContent(string content, string filePath);
		void SaveContent(string content, string filePath, Encoding encoding);
		int GetSymbolCount(string content);
		bool IsExist(string filePath);
	}

	public class FileManager: IFileManager
	{
		private readonly Encoding defaultEncoding = Encoding.GetEncoding(1251);
		public string GetContent(string filePath, Encoding encoding)
		{
			string content = File.ReadAllText(filePath, encoding);
			return content;

		}
		public string GetContent(string filePath)
		{
			return GetContent(filePath, defaultEncoding);
		}
		public void SaveContent(string content, string filePath, Encoding encoding)
		{
			File.WriteAllText(filePath, content, encoding);
		}
		public void SaveContent(string content, string filePath)
		{
			SaveContent(filePath, content, defaultEncoding);
		}
		public bool IsExist(string filePath)
		{
			bool isExist = File.Exists(filePath);
			return isExist;
		}
		public int GetSymbolCount(string content)
		{
			int count = content.Length;
			return count;
		}
	}
}
