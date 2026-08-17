# Unity Profiler Guide for Mobile Games

Profiling helps identify the real cause of performance problems.

Avoid making optimization decisions based only on assumptions.

## CPU Profiling

Check for:

* Expensive Update methods
* Garbage collection spikes
* Physics calculations
* Excessive object creation
* Repeated component searches
* Complex AI calculations

## GPU Profiling

Check for:

* High rendering cost
* Expensive shaders
* Overdraw
* Real-time lighting
* Shadows
* Particle effects

## Memory Profiling

Monitor:

* Texture memory
* Mesh memory
* Audio memory
* Managed memory
* Loaded assets

## Rendering Statistics

Monitor:

* Draw calls
* Batches
* Triangles
* Vertices
* SetPass calls

## Test on Real Devices

A Unity game that performs well inside the Editor may still experience problems on a low-end Android device.

Always test:

* Frame rate
* Loading times
* Memory usage
* Battery consumption
* Device temperature
* Long gameplay sessions

## Optimization Workflow

1. Build the game.
2. Test on a real device.
3. Identify the performance bottleneck.
4. Profile the problem.
5. Make one optimization change.
6. Test again.
7. Compare the results.

This approach helps prevent unnecessary optimization work.
