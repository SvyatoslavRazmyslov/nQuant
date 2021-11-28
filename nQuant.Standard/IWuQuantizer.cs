using System.Drawing;

namespace nQuant.Standard
{
    public interface IWuQuantizer
    {
        Image QuantizeImage(Bitmap image, int alphaThreshold, int alphaFader);
        Image QuantizeImage(Bitmap image, int alphaThreshold, int alphaFader, int maxColors);
    }
}