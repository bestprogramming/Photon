namespace Photon.Packing
{
    public static partial class CirclesInASquare
    {
        public class Row
        {
            public double Radius;
            public double Distance;
            public double Ratio;
            public double Density;
            public double Contacts;
            public double Loose;
            public double Boundary;

            public Row(double radius, double distance, double ratio, double density, double contacts, double loose, double boundary)
            {
                Radius = radius;
                Distance = distance;
                Ratio = ratio;
                Density = density;
                Contacts = contacts;
                Loose = loose;
                Boundary = boundary;
            }
        }
    }
}
