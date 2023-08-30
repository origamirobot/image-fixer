namespace ImageFixer.Core.IO
{

	public class IoUtility : IIoUtility
	{

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets the directory.
		/// </summary>
		public IDirectoryUtility Directory { get; private set; }

		/// <summary>
		/// Gets the file.
		/// </summary>
		public IFileUtility File { get; private set; }

		/// <summary>
		/// Gets the path.
		/// </summary>
		public IPathUtility Path { get; private set; }


		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="IoUtility"/> class.
		/// </summary>
		public IoUtility(
			IDirectoryUtility directoryUtility,
			IFileUtility fileUtility,
			IPathUtility pathUtility)
		{
			Directory = directoryUtility;
			Path = pathUtility;
			File = fileUtility;
		}


		#endregion CONSTRUCTORS

	}

}
