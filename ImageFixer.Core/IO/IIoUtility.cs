namespace ImageFixer.Core.IO
{

	/// <summary>
	/// 
	/// </summary>
	public interface IIoUtility
	{

		/// <summary>
		/// Gets the directory.
		/// </summary>
		IDirectoryUtility Directory { get; }

		/// <summary>
		/// Gets the file.
		/// </summary>
		IFileUtility File { get;  }

		/// <summary>
		/// Gets the path.
		/// </summary>
		IPathUtility Path { get;  }

	}

}
