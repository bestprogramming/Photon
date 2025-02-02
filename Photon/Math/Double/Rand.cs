namespace Photon
{
    public static partial class Rand
    {
        public static Vector3D Vector3D()
        {
            var ret = new Vector3D(
                2 * random.NextDouble() - 1,
                2 * random.NextDouble() - 1,
                2 * random.NextDouble() - 1
            );

            while (ret == Photon.Vector3D.Zero)
            {
                ret = new Vector3D(
                    2 * random.NextDouble() - 1,
                    2 * random.NextDouble() - 1,
                    2 * random.NextDouble() - 1
                );
            }

            return ret;
        }

        public static double Double(double min, double max) => random.NextDouble() * (max - min) + min;
        public static double NextDouble() => random.NextDouble();
        public static int Int(int min, int max) => random.Next(min, max);
    }
}
