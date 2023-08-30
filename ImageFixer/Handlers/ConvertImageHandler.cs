using ImageFixer.Commands;
using ImageFixer.Core.IO;
using ImageFixer.Imaging;
using Microsoft.Extensions.Logging;
using Upstream.CommandLine;

namespace ImageFixer.Handlers
{

	public class ConvertImageHandler : ICommandHandler<ConvertImageCommand>
	{

		private readonly IIoUtility IoUtility;
		private readonly IImageUtility ImageUtility;
		private readonly ILogger Logger;

		public ConvertImageHandler(
			ILogger<ResizeImageHandler> logger, 
			IImageUtility imageUtility, 
			IIoUtility ioUtility)
		{
			Logger = logger;
			ImageUtility = imageUtility;
			IoUtility = ioUtility;
		}


		public Task<int> ExecuteAsync(ConvertImageCommand options, CancellationToken cancellationToken)
		{
			Logger.LogInformation("Executing Convert Image Handler");
			// TODO: Implement this
			throw new NotImplementedException();
		}

	}

}
