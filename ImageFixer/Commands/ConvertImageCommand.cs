using ImageFixer.Imaging;
using Upstream.CommandLine;

namespace ImageFixer.Commands
{

	[Command("convert", "Converts each image to the destination file type")]
	public class ConvertImageCommand
	{

		[Option("-t", "--target", DefaultValue = "./")]
		public String Target { get; set; } = "./";

		[Option("-f", "--filetype")]
		public String FileType { get; set; } = ".jpg";

	}

}
