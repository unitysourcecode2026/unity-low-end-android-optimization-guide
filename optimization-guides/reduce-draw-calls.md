# Reducing Draw Calls in Unity

A large number of draw calls can create rendering bottlenecks on low-end Android devices.

Draw call optimization should focus on reducing unnecessary rendering work while maintaining the required visual quality.

## Recommended Techniques

### Reuse Materials

Objects using the same material may be easier for Unity to batch.

Avoid creating unnecessary duplicate materials.

### Use Static Batching

Static batching can help with objects that do not move or change frequently.

Use it carefully and test memory usage and rendering performance.

### Use Sprite Atlases

Sprite atlases can reduce texture and material changes in 2D projects.

### Reduce Transparent Objects

Transparent objects can increase overdraw.

Avoid stacking unnecessary transparent UI elements, particles, and effects.

### Optimize UI

Large or frequently updated UI canvases can create unnecessary rebuild work.

Consider separating:

* Static UI
* Frequently updated UI
* Popups
* Dynamic elements

### Use the Frame Debugger

The Unity Frame Debugger can help identify how objects are being rendered and where unnecessary rendering work may occur.

## Important

Do not optimize based only on the number of draw calls.

A lower draw call count does not always guarantee better performance. Profile the game on target devices.
