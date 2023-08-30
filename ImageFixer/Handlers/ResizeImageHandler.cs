using ImageFixer.Commands;
using ImageFixer.Core.IO;
using ImageFixer.Imaging;
using Microsoft.Extensions.Logging;
using Upstream.CommandLine;

namespace ImageFixer.Handlers
{

	public class ResizeImageHandler : ICommandHandler<ResizeImageCommand>
	{

		private readonly IIoUtility IoUtility;
		private readonly IImageUtility ImageUtility;
		private readonly ILogger Logger;

		public ResizeImageHandler(
			ILogger<ResizeImageHandler> logger, 
			IImageUtility imageUtility, 
			IIoUtility ioUtility)
		{
			Logger = logger;
			ImageUtility = imageUtility;
			IoUtility = ioUtility;
		}


		public Task<int> ExecuteAsync(ResizeImageCommand options, CancellationToken cancellationToken)
		{
			Logger.LogInformation("Executing Resize Image Handler");
			// TODO: Implement this
			return Task.FromResult(0);
		}

	}

}
