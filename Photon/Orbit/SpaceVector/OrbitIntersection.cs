namespace Photon.SpaceVector
{
    public struct OrbitIntersection
    {
        public Circle3Projection Cp;
        public Orbit Orbit1;
        public Orbit Orbit2;

        public OrbitIntersection(in Circle3Projection cp, in Orbit orbit1, in Orbit orbit2)
        {
            Cp = cp;
            Orbit1 = orbit1;
            Orbit2 = orbit2;
        }

    }
}
