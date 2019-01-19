Source Engine BSP Lightmap Editor
=================================

**Download:** [Click here!](https://www.dropbox.com/scl/fi/94mgvh98cdt3xnpi22yqw/vradFix0.2.zip?rlkey=7xezyjw1y2corrlshm57yr3ez&dl=1)

**Current version**: 0.2  
**Developed by**: fubarFX, fml42

## About
This application is a lightmap editor for Valve Source Engine games.
When a Source Engine map (.bsp) is compiled, precalculated lighting data is packed into it.
These are the so called lightmaps. They provide static lighting to the world geometry.
If you're not happy with the precalculated results from the lightmap creation tool (vrad), you can use this tool to modify them.

## Credits
This program was originally developed by fubarFX on https://tf2maps.net/  
Homepage: http://www.mdupuis.com/  
Original post: https://tf2maps.net/threads/vradfix-lightmap-editor.21080/  
Github repository: https://github.com/maxdup/VRADFix  

Since this version only supported text editing for the color values, I updated the software to use images as a more intuitive representation for the lightmaps.

This project is open source. You are free to continue development on it!

## What's new?
- Lightmaps are now displayed as an image instead of text rgb values.
- Some improvements to the GUI
- Exposure adjustment: You can brighten or darken the preview of the lightmap

## Why can't I export a lightmap to an editable image file (e.g. PNG)?
Pretty much every widespread image format uses three color channels with 256 possible color values per channel.
Lightmap color values have a fourth value, the exponent, with which we can achieve more than these 256 values per color channel ([docs](https://developer.valvesoftware.com/wiki/Source_BSP_File_Format#Lighting)).
This is a requirement for lightmap data, _especially for high dynamic range lighting_, because 256 values per channel simply aren't enough to differentiate between the darkest and brightest areas of a map.
Normal RBG colors would be obtained like this:
```
normal_red   = luxel_red   * 2^exponent
normal_green = luxel_green * 2^exponent
normal_blue  = luxel_blue  * 2^exponent
```
The exponent is a signed byte, i.e. can take on values form -128 to 127.
So we would need an image format that supports more than 256 values per channel. We'd actually need floating point color channels, because the exponent can go negative, resulting in values _between_ 0 and 1.
I do not know of such a format that is widely supported by the most common image editors (Photoshop, Gimp, Paint.NET, etc). If you do know of such a format or how to get floating point colors in one of these editors, **please absolutely do contact me** on Steam and let me know! (see below) I'll gladly add import/export functionality for that format to this application.

## Read more
https://developer.valvesoftware.com/wiki/Source_BSP_File_Format  
https://tf2maps.net/threads/vradfix-lightmap-editor.21080/

## Feedback / Feature suggestions / Bugs
You can find me on Steam http://steamcommunity.com/id/fml42/  
Add me and I'll be happy to hear your feedback or ideas on how to improve the software!
