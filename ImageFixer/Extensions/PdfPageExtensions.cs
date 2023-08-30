using PDFiumSharp;

namespace ImageFixer
{

	public static class PdfPageExtensions
	{


		public static Byte[] ToByteArray(this PdfPage page, Int32 dpi = 600)
		{
			double scale = dpi / 96;
			using (var bmp = new PDFiumBitmap((int)(page.Width * scale), (int)(page.Height * scale), true))
			{
				page.Render(bmp);
				using (var stream = new MemoryStream())
				{
					bmp.Save(stream, dpi, dpi);
					return stream.ToArray();
				}
			}
		}

	}

}
