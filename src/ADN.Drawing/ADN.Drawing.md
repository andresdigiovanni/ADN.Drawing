<a name='assembly'></a>
# ADN.Drawing

## Contents

- [BitmapExtensions](#T-ADN-Drawing-BitmapExtensions 'ADN.Drawing.BitmapExtensions')
  - [Resize(bitmap,width,height,pixelFormat)](#M-ADN-Drawing-BitmapExtensions-Resize-System-Drawing-Bitmap,System-Int32,System-Int32,System-Drawing-Imaging-PixelFormat- 'ADN.Drawing.BitmapExtensions.Resize(System.Drawing.Bitmap,System.Int32,System.Int32,System.Drawing.Imaging.PixelFormat)')
  - [ResizeCanvas(bitmap,width,height,pixelFormat)](#M-ADN-Drawing-BitmapExtensions-ResizeCanvas-System-Drawing-Bitmap,System-Int32,System-Int32,System-Drawing-Imaging-PixelFormat- 'ADN.Drawing.BitmapExtensions.ResizeCanvas(System.Drawing.Bitmap,System.Int32,System.Int32,System.Drawing.Imaging.PixelFormat)')
  - [SetBackgroundColor(bitmap,color,pixelFormat)](#M-ADN-Drawing-BitmapExtensions-SetBackgroundColor-System-Drawing-Bitmap,System-Drawing-Color,System-Drawing-Imaging-PixelFormat- 'ADN.Drawing.BitmapExtensions.SetBackgroundColor(System.Drawing.Bitmap,System.Drawing.Color,System.Drawing.Imaging.PixelFormat)')

<a name='T-ADN-Drawing-BitmapExtensions'></a>
## BitmapExtensions `type`

##### Namespace

ADN.Drawing

##### Summary

A static class of extension methods for [Bitmap](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap 'System.Drawing.Bitmap').

<a name='M-ADN-Drawing-BitmapExtensions-Resize-System-Drawing-Bitmap,System-Int32,System-Int32,System-Drawing-Imaging-PixelFormat-'></a>
### Resize(bitmap,width,height,pixelFormat) `method`

##### Summary

Resize a Bitmap.

##### Returns

Resized bitmap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bitmap | [System.Drawing.Bitmap](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap 'System.Drawing.Bitmap') | Bitmap to resize. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | New width. |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | New height. |
| pixelFormat | [System.Drawing.Imaging.PixelFormat](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Imaging.PixelFormat 'System.Drawing.Imaging.PixelFormat') | Specifies the format of the color data for each pixel in the image. |

##### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
int width = 320;
int height = 180;
var resizedBitmap = originalBitmap.Resize(width, height); 
```

<a name='M-ADN-Drawing-BitmapExtensions-ResizeCanvas-System-Drawing-Bitmap,System-Int32,System-Int32,System-Drawing-Imaging-PixelFormat-'></a>
### ResizeCanvas(bitmap,width,height,pixelFormat) `method`

##### Summary

Resize the canvas of a Bitmap.

##### Returns

Resized bitmap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bitmap | [System.Drawing.Bitmap](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap 'System.Drawing.Bitmap') | Bitmap to resize. |
| width | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | New width. |
| height | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | New height. |
| pixelFormat | [System.Drawing.Imaging.PixelFormat](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Imaging.PixelFormat 'System.Drawing.Imaging.PixelFormat') | Specifies the format of the color data for each pixel in the image. |

##### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
int width = 320;
int height = 180;
var resizedBitmap = originalBitmap.ResizeCanvas(width, height); 
```

<a name='M-ADN-Drawing-BitmapExtensions-SetBackgroundColor-System-Drawing-Bitmap,System-Drawing-Color,System-Drawing-Imaging-PixelFormat-'></a>
### SetBackgroundColor(bitmap,color,pixelFormat) `method`

##### Summary

Set background of a Bitmap.

##### Returns

Bitmap with the background changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bitmap | [System.Drawing.Bitmap](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Bitmap 'System.Drawing.Bitmap') | Bitmap to change background. |
| color | [System.Drawing.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') | Background color. |
| pixelFormat | [System.Drawing.Imaging.PixelFormat](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Imaging.PixelFormat 'System.Drawing.Imaging.PixelFormat') | Specifies the format of the color data for each pixel in the image. |

##### Example

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
var backgroundColor = Color.FromName("yellow");
var backgroundBitmap = originalBitmap.SetBackgroundColor(backgroundColor); 
```
