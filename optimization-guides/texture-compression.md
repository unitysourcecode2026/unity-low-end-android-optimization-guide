# Texture Compression for Low-End Android Devices

Textures are often one of the biggest contributors to memory usage in a Unity mobile game.

A game may perform well in the Unity Editor but still experience memory pressure on lower-end Android devices if textures are unnecessarily large or poorly configured.

## Recommended Practices

* Avoid unnecessarily large texture resolutions.
* Use Android-appropriate texture compression.
* Use sprite atlases where appropriate.
* Disable Read/Write when it is not required.
* Avoid duplicate textures.
* Review mipmap usage.
* Compress textures according to their purpose.
* Test texture memory usage on real Android devices.

## Texture Resolution

Always consider the actual screen size of your target devices.

Using a very large texture for a small UI element or mobile object can waste memory without producing a visible improvement.

## Read/Write Setting

The Read/Write option can increase memory usage.

Disable it unless the texture must be accessed or modified through scripts.

## Sprite Atlases

Sprite atlases can help organize textures and reduce unnecessary material changes.

They can be especially useful for:

* UI elements
* 2D characters
* Icons
* Collectibles
* Repeated sprites

## Testing

Use the Unity Profiler and Memory Profiler to identify large textures.

Do not optimize only based on texture import settings. Test the final build on actual Android hardware.
