using ImageFixer.Imaging;
using Upstream.CommandLine;

namespace ImageFixer.Commands
{

	[Command("resize", "Resizes each image to the exact specifications")]
	public class ResizeImageCommand
	{

		[Option("-t", "--target", DefaultValue = "./")]
		public String Target { get; set; } = "./";

		[Option("--dest", "--destination", DefaultValue = "./")]
		public string Destination { get; set; } = "./";

		[Option("-w", "--width")]
		public Int32 Width { get; set; }

		[Option("-h", "--height")]
		public Int32 Height { get; set; }

		[Option("-f", "--fillmode")]
		public FillMode FillMode { get; set; }

		[Option("-b", "--bg", "--background", DefaultValue = "#00000000")]
		public String Background { get; set; } = "#00000000";

	}

}
