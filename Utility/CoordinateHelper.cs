namespace DoodleDuel.Utility;

public static class CoordinateHelper
{
    public static double PixelToPercentage(double pixel, double size)
    {
        return pixel / size * 100;
    }

    public static double PercentageToPixel(double percentage, double position, double size)
    {
        return position + percentage / 100 * size;
    }
}
