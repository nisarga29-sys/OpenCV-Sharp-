UI 

<img width="2720" height="2840" alt="winforms_opencvsharp_architecture_detailed" src="https://github.com/user-attachments/assets/398fe2eb-9e48-44be-9b2c-d97d250ed86a" />
## Overview

The app shows two views in the main window:

- **Original view:** the loaded image as an OpenCV `Mat`
- **Processed view:** the result of the selected processing operations, applied only to the chosen ROI

This makes it easy to tune and compare image processing steps such as thresholding, edge detection and contour analysis, and to get measurements from the result.

## Features

- **Flexible input:** browse a single image or an entire folder
- **ROI-based processing:** operations run only on the region you select
- **Thresholding:** global, adaptive and range-based
- **Morphological operations:** erode, dilate, open, close and more, with configurable structuring elements
- **Color intensity analysis:** grayscale and HSV conversion, mean and standard deviation of intensity
- **Edge detection:** Canny, Sobel and Laplacian
- **Perspective transform:** correct skewed or angled regions
- **Contour detection:** find, draw and measure contours (area, bounding rectangle)
- **Pixel counting:** count non-zero pixels in the processed ROI

## Architecture

```
Image / Folder browse
        │
        ▼
  Load image as Mat (Cv2.ImRead)
        │
        ▼
    ROI selection
        │
        ▼
 Processing pipeline (OpenCvSharp)
 ├── Thresholding
 ├── Morphological operations
 ├── Color intensity
 ├── Edge detection
 ├── Perspective transform
 └── Contours
        │
        ▼
 PictureBox 1 (original)  |  PictureBox 2 (processed)  |  Pixel count
```

Mats are converted to Bitmaps with `BitmapConverter.ToBitmap` for display in the PictureBoxes.

## Tech stack

- C# / Windows Forms
- .NET [version]
- [OpenCvSharp4](https://www.nuget.org/packages/OpenCvSharp4) and OpenCvSharp4.Extensions
- OpenCvSharp4.runtime.win

## Getting started

### Prerequisites

- Windows
- Visual Studio [version] with the .NET desktop development workload

### Build and run

```bash
git clone https://github.com/[username]/[repo].git
cd [repo]
```

1. Open `[Project].sln` in Visual Studio
2. Restore NuGet packages
3. Build and run (F5)

## Usage

1. Click **Browse Image** or **Browse Folder** to load your input
2. Draw an ROI on the original image
3. Choose an operation and adjust its parameters
4. View the processed result in the second PictureBox
5. Read the pixel count and other measurements from the result

## Project structure

```
[Project]/
├── Forms/          # WinForms UI
├── Processing/     # OpenCvSharp processing logic
├── Helpers/        # Mat/Bitmap conversion, utilities
└── Program.cs
```

## Possible future work

- Save processed images and measurements to file
- Chain multiple operations into a saved pipeline
- Batch processing across a folder

