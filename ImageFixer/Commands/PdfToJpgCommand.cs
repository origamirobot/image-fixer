using ImageFixer.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upstream.CommandLine;

namespace ImageFixer.Commands
{

	[Command("pdf-to-jpg", "Converts each page ")]
	public class PdfToJpgCommand
	{

		[Option("-t", "--target")]
		public string Target { get; set; }

		[Option("-d", "--dpi" , DefaultValue = 600)]
		public int DPI { get; set; }

		[Option("--dest", "--destination", DefaultValue = "./")]
		public string Destination { get; set; }

	}

}
