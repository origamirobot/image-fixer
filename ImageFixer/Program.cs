

using ImageFixer.Commands;
using ImageFixer.Core.IO;
using ImageFixer.Handlers;
using ImageFixer.Imaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Upstream.CommandLine;

namespace ImageFixer
{
	
	public static class Program
	{

		public static async Task Main(string[] args) 
		{
			var stopwatch = Stopwatch.StartNew();
			try
			{
				await BuildApplication()
					.InvokeAsync(args);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				stopwatch.Stop();
				Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds}ms");
			}
		}

		public static CommandLineApplication BuildApplication()
		{
			return new CommandLineApplication("image-fixer")
				.AddCommand<PdfToJpgHandler, PdfToJpgCommand>()
				.ConfigureServices(services =>
				{
					services.AddLogging(configure => configure.AddConsole());
					services.AddSingleton<IFileUtility, FileUtility>();
					services.AddSingleton<IDirectoryUtility, DirectoryUtility>();
					services.AddSingleton<IPathUtility, PathUtility>();
					services.AddSingleton<IIoUtility, IoUtility>();
					services.AddSingleton<IImageUtility, ImageUtility>();
				})
				.UseExceptionHandler(ex =>
				{
					var color = Console.ForegroundColor;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(ex.Message);
					Console.ForegroundColor = color;
				});
		}


	}

}