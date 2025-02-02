# Photon
This project is a rendering of an imaginary physics scenario.
The scenario should be like this.
Let the material itself determine the pattern formed on the curtain as light passes through a pair of slits, pinholes, etc.
In other words, the waves emitted from the material create a large lens condensation at the point where the light passes, and this lens determines the route of the light.
In the first stage, let's try to obtain the rendering of the waves emitted from the matter.

## How it works
Let's think of the atoms that make up matter as points and let waves propagate from these points.
Let the waves be spherical shells growing with square radius.
Let's render the intersections of these spherical shells with a screen (sphere-plane) and the intersections of these spheres with each other (sphere-sphere).
Let's compare these renders we finally got with the expected diffraction grating.

https://www.youtube.com/watch?v=GXwQ95i53zE<br>
https://www.youtube.com/watch?v=ZoJgFltE11U<br>

## Categories
- **Big numbers**: Contains basic mathematical operations with large numbers.
- **Physics simulation**: As a result, render is performed with OpenGL.