# Image Processing Tool

## 🚀 Overview

Windows desktop application for batch image resizing and format conversion. Processes entire folders of images in parallel, organizes output by dimensions, and provides real-time progress tracking.

Built to practice asynchronous programming and multi-threading in C#.

---

## 🧠 Technical Concepts

**Pointers and memory management:** Working with image data in memory. Understanding how images are stored as byte arrays. Managing memory efficiently when processing large batches. Proper disposal of resources to prevent memory leaks.

**File handling:** Reading images from disk. Writing processed images to organized output folders. Handling file system errors (permissions, missing files). Validating file formats before processing.

**Image manipulation algorithms:** Resizing with aspect ratio preservation. Format conversion (PNG ↔ JPG). EXIF metadata handling for correct orientation. Quality settings for compression.

---

## 🧠 Skills Demonstrated

**Problem solving:** Grouping images by dimensions before processing (optimization). Organizing output into folders named by dimensions. Handling edge cases (corrupted images, unsupported formats). Providing user feedback during long operations.

**Low-level logic implementation:** Async/await pattern for non-blocking UI operations. Multi-threading for parallel image processing. Thread-safe UI updates using Invoke pattern. Cancellation tokens for stopping operations. Progress tracking across multiple threads.

---

## 🧠 What I Learned

**Asynchronous programming is essential for responsive UIs:** Blocking the UI thread makes applications feel frozen. Async/await keeps the interface responsive during long operations. Cancellation tokens allow users to stop operations gracefully. Progress reporting requires careful coordination between threads.

**Multi-threading adds complexity but improves performance:** Parallel processing significantly speeds up batch operations. Thread-safe UI updates require marshalling to the UI thread. Proper exception handling across threads is critical. Synchronization primitives prevent race conditions.

**Memory management matters with large datasets:** Processing hundreds of images requires efficient memory usage. Proper disposal of resources prevents memory leaks. Understanding when objects are garbage collected. Streaming large files instead of loading entirely into memory.

**Algorithmic thinking for image processing:** Aspect ratio calculations require mathematical precision. Grouping similar images reduces redundant calculations. Quality vs file size trade-offs. Understanding image formats and their characteristics.

---

## Technology Stack

C# .NET Framework 4.7.2, Windows Forms, Magick.NET, Async/Await, Multi-threading

---

## License

MIT
