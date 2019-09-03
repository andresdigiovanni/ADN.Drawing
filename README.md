# Drawing Library for .NET

ADN.Drawing is a cross-platform open-source library which provides drawing utilities to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.Drawing.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.Drawing)
[![NuGet](https://img.shields.io/nuget/v/ADN.Drawing.svg)](https://www.nuget.org/packages/ADN.Drawing/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.Drawing?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Drawing&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Drawing)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Drawing&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Drawing)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Example of set background color:

Original bitmap:
![Polar bear](resources/polar-bear-2.png)

```csharp
var originalBitmap = (Bitmap)Bitmap.FromFile("polar-bear.png");
var backgroundColor = Color.FromName("yellow");
var backgroundBitmap = originalBitmap.SetBackgroundColor(backgroundColor);
```

Background bitmap:
![Polar bear yellow background](resources/polar-bear-2-yellow.png)

## Installation

ADN.Drawing runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.Drawing NuGet package from the NuGet package manager:

```
Install-Package ADN.Drawing
```

Or alternatively you can add the ADN.Drawing package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.Drawing/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.Drawing is licensed under the [MIT license](LICENSE).
