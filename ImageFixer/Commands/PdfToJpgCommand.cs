using Upstream.CommandLine;

namespace ImageFixer.Commands
{

	[Command("pdf-to-jpg", "Converts each page of the target PDF to a JPG")]
	public class PdfToJpgCommand
	{

		[Option("-t", "--target")]
		public String Target { get; set; } = "";

		[Option("-d", "--dpi" , DefaultValue = 600)]
		public Int32 DPI { get; set; }

		[Option("--dest", "--destination", DefaultValue = "./")]
		public String Destination { get; set; } = "./";

	}

}
