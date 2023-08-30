using Upstream.CommandLine;

namespace ImageFixer.Commands
{

	[Command("jpg-to-pdf", "Converts each image in the target folder to a PDF")]
	public class JpgToPdfCommand
	{

		[Option("-t", "--target", DefaultValue = "./")]
		public String Target { get; set; } = "./";

		[Option("--dest", "--destination", DefaultValue = "./output.pdf")]
		public String Destination { get; set; } = "./";

	}

}
