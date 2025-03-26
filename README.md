# Image Manipulation
My personal project for manipulating image files, for fun and practice.


Currently implemented features:
- Open Files (.bmp, .gif, .jpeg/.jpg, .png)
- Save Files (.bmp, .gif, .jpeg/.jpg, .png)
- Decrease/Increase Brightness of an Image
- Get the Grayscale of an Image
- Get the Negative of an Image
- Flip an Image Horizontally/Vertically
- Rotate an Image +90° / -90°
- Combine several images to create a .gif animation
- Export the frames of a .gif animation
- Modify the frame delay of a .gif that will be combined (delay is in centiseconds)


To Do List:
- Implement a layer system.
  - Layers need a selection toggle.
    - This is important because all options will be modified to apply changes to any selected layers.
  - Layers need a viewport visibility toggle.
- Implement the Find and Replace Colors (Pixels) option.
  - This will allow the user to replace the colors of a sprite or animation.
  - Additionally, implement a template system that can be parsed for color codes.
    - This will allow for team colors or palette swaps to be changed much more easily for sprites or animations.
- Allow cursor file formats to be opened and saved.