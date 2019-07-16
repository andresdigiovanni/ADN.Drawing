# ADN.Drawing

# Content

- [BitmapExtensions](#T:ADN.Drawing.BitmapExtensions)

  - [Resize(bitmap, width, height, pixelFormat)](#BitmapExtensions.Resize(bitmap,width,height,pixelFormat))

  - [ResizeCanvas(bitmap, width, height, pixelFormat)](#BitmapExtensions.ResizeCanvas(bitmap,width,height,pixelFormat))

  - [SetBackgroundColor(bitmap, color, pixelFormat)](#BitmapExtensions.SetBackgroundColor(bitmap,color,pixelFormat))

<a name='T:ADN.Drawing.BitmapExtensions'></a>


## BitmapExtensions

A static class of extension methods for .

<a name='BitmapExtensions.Resize(bitmap,width,height,pixelFormat)'></a>


### Resize(bitmap, width, height, pixelFormat)

Resize a Bitmap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| bitmap | *System.Drawing.Bitmap*<br>Bitmap to resize. |

#### Parameters

| width | *System.Int32*<br>New width. |

#### Parameters

| height | *System.Int32*<br>New height. |

#### Parameters

| pixelFormat | *System.Drawing.Imaging.PixelFormat*<br>Specifies the format of the color data for each pixel in the image. |


#### Returns

Resized bitmap.


#### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
int width = 320;
int height = 180;
var resizedBitmap = originalBitmap.Resize(width, height);
```

<a name='BitmapExtensions.ResizeCanvas(bitmap,width,height,pixelFormat)'></a>


### ResizeCanvas(bitmap, width, height, pixelFormat)

Resize the canvas of a Bitmap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| bitmap | *System.Drawing.Bitmap*<br>Bitmap to resize. |

#### Parameters

| width | *System.Int32*<br>New width. |

#### Parameters

| height | *System.Int32*<br>New height. |

#### Parameters

| pixelFormat | *System.Drawing.Imaging.PixelFormat*<br>Specifies the format of the color data for each pixel in the image. |


#### Returns

Resized bitmap.


#### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
int width = 320;
int height = 180;
var resizedBitmap = originalBitmap.ResizeCanvas(width, height);
```

<a name='BitmapExtensions.SetBackgroundColor(bitmap,color,pixelFormat)'></a>


### SetBackgroundColor(bitmap, color, pixelFormat)

Set background of a Bitmap.


#### Parameters

| Name | Description |
| ---- | ----------- |
| bitmap | *System.Drawing.Bitmap*<br>Bitmap to change background. |

#### Parameters

| color | *System.Drawing.Color*<br>Background color. |

#### Parameters

| pixelFormat | *System.Drawing.Imaging.PixelFormat*<br>Specifies the format of the color data for each pixel in the image. |


#### Returns

Bitmap with the background changed.


#### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
var backgroundColor = Color.FromName("yellow");
var backgroundBitmap = originalBitmap.SetBackgroundColor(backgroundColor);
```

