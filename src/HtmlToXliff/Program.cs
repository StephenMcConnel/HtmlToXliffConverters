using System;
using System.IO;
using System.Text;
using HtmlAgilityPack;

namespace HtmlToXliff
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				Console.WriteLine("Usage: HtmlToXliff htmlfile");
				return;
			}
			var infile = args[0];
			var outfile = Path.ChangeExtension(infile, "xlf");

			var converter = HtmlToXliffConverter.Load(infile);
			var xliffDoc = converter.Convert();
			xliffDoc.Save(outfile);
		}
	}
}
