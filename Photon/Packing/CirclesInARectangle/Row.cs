namespace Photon.Packing
{
    public static partial class CirclesInARectangle
    {
        public class Row
        {
            public string Class;
            public double Radius;
            public double Height;
            public double Density;
            public double Contacts;
            public double Loose;
            public double Boundary;

            public Row(string _class, double radius, double height, double density, double contacts, double loose, double boundary)
            {
                Class = _class;
                Radius = radius;
                Height = height;
                Density = density;
                Contacts = contacts;
                Loose = loose;
                Boundary = boundary;
            }
        }
    }
}
