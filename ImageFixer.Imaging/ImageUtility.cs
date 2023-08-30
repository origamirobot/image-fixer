using System.Drawing;
using System.Drawing.Imaging;

namespace ImageFixer.Imaging
{

	public interface IImageUtility
	{

		/// <summary>
		/// Converts the specified image to a byte array.
		/// </summary>
		/// <param name="img">The image to convert to a byte array.</param>
		/// <returns></returns>
		Byte[] ByteArrayFromImage(Image img);

	}


	public class ImageUtility : IImageUtility
	{


		/// <summary>
		/// Converts the specified image to a byte array.
		/// </summary>
		/// <param name="img">The image to convert to a byte array.</param>
		/// <returns></returns>
		public Byte[] ByteArrayFromImage(Image img)
		{
			using (var ms = new MemoryStream())
			{
				img.Save(ms, ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}


	}

}
