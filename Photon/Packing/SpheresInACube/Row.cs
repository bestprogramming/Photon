namespace Photon.Packing
{
    public static partial class SpheresInACube
    {
        public class Row
        {
            public double Radius;
            public double Distance;
            public double Ratio;
            public double Density;
            public double Contacts;

            public Row(double radius, double distance, double ratio, double density, double contacts)
            {
                Radius = radius;
                Distance = distance;
                Ratio = ratio;
                Density = density;
                Contacts = contacts;
            }
        }
    }
}
