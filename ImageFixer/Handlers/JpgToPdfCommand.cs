using ImageFixer.Commands;
using ImageFixer.Core.IO;
using Microsoft.Extensions.Logging;
using Upstream.CommandLine;

namespace ImageFixer.Handlers
{

	public class JpgToPdfHandler : ICommandHandler<JpgToPdfCommand>
	{

		private readonly IIoUtility IoUtility;
		private readonly ILogger Logger;

		public JpgToPdfHandler(
			IIoUtility ioUtility, 
			ILogger<JpgToPdfHandler> logger)
		{
			IoUtility = ioUtility;
			Logger = logger;
		}

		public Task<int> ExecuteAsync(JpgToPdfCommand options, CancellationToken cancellationToken)
		{
			Logger.LogInformation("Executing JPG to PDF Handler");
			// TODO: Finish implementing this
			return Task.FromResult(0);
		}

	}

}
