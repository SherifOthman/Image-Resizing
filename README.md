# Image Resizing & Conversion Tool

A Windows desktop application for batch image processing, built to practice asynchronous programming and multi-threading in C#.

## Purpose

This project solves the problem of manually resizing and converting large batches of images. It processes entire folders of images in parallel, organizes output by dimensions, and provides real-time progress tracking without freezing the UI.

## Architecture

**Two-Project Solution**:

- **ImageResizeUI**: Windows Forms application with UI logic
- **ImageConverterLib**: Reusable image processing library

**Key Design Decisions**:

- Async/await pattern for non-blocking UI operations
- Multi-threading for parallel image processing
- Grouping images by dimensions before processing (optimization)
- Separation of UI and business logic into different projects

## Technical Skills Demonstrated

**Asynchronous Programming**:

- Used `async`/`await` throughout to keep UI responsive
- Implemented cancellation tokens for stopping long-running operations
- Handled async exceptions and progress reporting

**Multi-Threading**:

- Parallel processing of image batches
- Thread-safe UI updates using `Invoke` pattern
- Progress tracking across multiple threads

**Image Processing**:

- Magick.NET library integration for professional-quality resizing
- EXIF metadata handling for correct orientation
- Format conversion (PNG ↔ JPG) with quality preservation
- Aspect ratio calculations and preservation

**Windows Forms**:

- Drag-and-drop folder selection
- Real-time progress bars (per-group and overall)
- Modern UI with Guna2 components
- Form validation and error handling

## Implementation Details

**Batch Processing Flow**:

1. Scan folder for images (JPG, PNG, GIF, BMP)
2. Group images by original dimensions
3. Allow user to set target dimensions per group
4. Process each group in parallel with progress tracking
5. Save to organized output folders (named by dimensions)

**Async Operations**:

```csharp
// Non-blocking image processing
await Task.Run(() => ProcessImagesAsync(imageGroup, cancellationToken));
```

**Data Handling**:

- File system operations with error handling
- Image metadata extraction and validation
- Memory-efficient processing of large image sets

## Technology Stack

- C# .NET Framework 4.7.2
- Windows Forms for UI
- Magick.NET for image processing
- Guna.UI2 for modern UI components
- Async/Await for concurrency

## What I Learned

**Async Programming Fundamentals**:

- How to properly use async/await to avoid blocking the UI thread
- The importance of cancellation tokens for long-running operations
- How to report progress from async operations back to the UI

**Multi-Threading Challenges**:

- Thread-safe UI updates require marshalling to the UI thread
- Parallel processing improves performance but adds complexity
- Proper exception handling across threads is critical

**Image Processing**:

- EXIF orientation data affects how images should be displayed
- Quality settings significantly impact file size
- Different image formats have different use cases

**Architecture**:

- Separating UI from business logic makes code more testable
- Reusable libraries can be consumed by different applications
- Progress reporting requires careful design of async methods

## Project Stats

- 2 projects (UI + library)
- 5 supported input formats
- Async/await throughout
- Multi-threaded processing
- Real-time progress tracking

---

**Learning Focus**: Asynchronous programming, multi-threading, and Windows desktop development in C#
