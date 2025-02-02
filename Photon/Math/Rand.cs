namespace Photon
{
    public static partial class Rand
    {
        private static readonly Random random = new();

        public static Vector3 Vector3()
        {
            var ret = new Vector3(
                2 * random.NextDouble() - 1,
                2 * random.NextDouble() - 1,
                2 * random.NextDouble() - 1
            );

            while (ret == Photon.Vector3.Zero)
            {
                ret = new Vector3(
                    2 * random.NextDouble() - 1,
                    2 * random.NextDouble() - 1,
                    2 * random.NextDouble() - 1
                );
            }

            return ret;
        }
    }
}
