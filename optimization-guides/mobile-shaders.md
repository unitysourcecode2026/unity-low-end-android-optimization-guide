# Mobile Shader Optimization

Shader complexity can significantly affect performance on low-end Android GPUs.

A visually impressive shader may create unnecessary GPU load when used across many objects.

## Recommended Practices

### Use Simpler Shaders

Prefer mobile-friendly shaders where advanced visual effects are not required.

### Reduce Transparency

Transparency can increase overdraw because multiple layers may need to be rendered.

Use transparent effects carefully.

### Limit Real-Time Shadows

Real-time shadows can be expensive on mobile devices.

Consider:

* Reducing shadow resolution
* Reducing shadow distance
* Limiting shadow-casting lights
* Using baked lighting where appropriate

### Reduce Post-Processing

Effects such as:

* Bloom
* Depth of Field
* Motion Blur
* Screen-space effects

can create additional GPU work.

Use them only when they provide meaningful visual value.

### Optimize Particles

Particle systems can create high overdraw.

Reduce:

* Particle count
* Particle size
* Transparency
* Lifetime
* Unnecessary effects

## Testing

Always test shaders and visual effects on the target Android devices.

Desktop GPU performance does not accurately represent low-end mobile hardware.
