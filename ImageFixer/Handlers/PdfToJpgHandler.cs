using ImageFixer.Commands;
using ImageFixer.Core.IO;
using Microsoft.Extensions.Logging;
using PDFiumSharp;
using Upstream.CommandLine;

namespace ImageFixer.Handlers
{

	public class PdfToJpgHandler : ICommandHandler<PdfToJpgCommand>
	{

		private readonly IIoUtility IoUtility;
		private readonly ILogger Logger;

		public PdfToJpgHandler(
			IIoUtility ioUtility, 
			ILogger<PdfToJpgHandler> logger)
		{
			IoUtility = ioUtility;
			Logger = logger;
		}

		public Task<int> ExecuteAsync(PdfToJpgCommand options, CancellationToken cancellationToken)
		{
			Logger.LogInformation("Executing PDF to JPG Handler");
			if (!IoUtility.File.Exists(options.Target))
				throw new ArgumentException($"Could not find the file {options.Target}");

			var pdf = new PdfDocument(options.Target);
			Logger.LogInformation($"There are {pdf.Pages.Count} pages in this document");

			if (!IoUtility.Directory.Exists(options.Destination))
			{
				Logger.LogInformation($"Creating new directory {options.Destination}.");
				IoUtility.Directory.CreateDirectory(options.Destination);
			}

			var pageNumber = 0;
			foreach (var page in pdf.Pages)
			{
				var payload = page.ToByteArray(options.DPI);
				Logger.LogInformation($"PDF page converted to {payload.Length}b image");
				var dest = IoUtility.Path.Combine(options.Destination, $"Page-{pageNumber.ToString().PadLeft(4, '0')}.jpg");
				Logger.LogInformation($"Saving page {pageNumber} to {dest}");
				IoUtility.File.WriteAllBytes(dest, payload);
				pageNumber++;
			}
			return Task.FromResult(0);
		}

	}

}
