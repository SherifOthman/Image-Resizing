# 🖼️ Image Resizing & Conversion Tool

> **Desktop Application** for batch image processing with async programming and multi-threading

- **📸 Screenshot**: ![App Screenshot](https://d.top4top.io/p_356176zz91.png)
- **🖥️ Platform**: Windows Desktop Application (.NET Framework 4.7.2)

## 🎯 **What This Project Is**

A desktop application for batch image processing built to practice asynchronous programming and multi-threading in C#. Resizes images in bulk, converts formats, and organizes output with real-time progress tracking.

## 🛠️ **Technology Stack**

| Technology                  | Purpose                               |
| --------------------------- | ------------------------------------- |
| **C# .NET Framework 4.7.2** | Core application development          |
| **Windows Forms**           | Desktop user interface                |
| **Magick.NET**              | Professional image processing library |
| **Guna.UI2**                | Modern UI components and controls     |
| **Async/Await**             | Non-blocking asynchronous operations  |

## ✅ **Key Features Implemented**

### **Batch Processing**

- ✅ **Folder Selection** - Drag-drop or browser selection for entire folders
- ✅ **Multi-format Support** - JPG, PNG, GIF, BMP, JPEG input formats
- ✅ **Smart Organization** - Groups images by original dimensions for optimized processing
- ✅ **Output Structure** - Saves in dimension-named folders (e.g., "1920 X 1080")

### **Image Processing**

- ✅ **Bulk Resizing** - Custom width/height with automatic aspect ratio preservation
- ✅ **Format Conversion** - Convert between PNG and JPG formats
- ✅ **Quality Enhancement** - 100% quality settings with sharpening filter
- ✅ **EXIF Handling** - Detects and corrects image orientation from metadata

### **Performance & UI**

- ✅ **Asynchronous Processing** - Non-blocking UI with async/await pattern
- ✅ **Multi-threading** - Parallel image processing for better performance
- ✅ **Real-time Progress** - Per-group and overall progress tracking with percentages
- ✅ **Cancellation Support** - Stop processing at any time
- ✅ **Modern Interface** - Guna2 components with progress indicators

## 🏗️ **Architecture**

**Two-Project Solution:**

- **ImageResizeUI** - Main WinForms application with UI logic
- **ImageConverterLib** - Reusable image processing utilities

**Key Workflow:**

1. Select source folder → Scan for images → Group by dimensions
2. Configure output settings → Set dimensions per group
3. Async processing with progress tracking → Organized output

## 🚀 **Quick Start**

**Prerequisites:** Windows OS, .NET Framework 4.7.2+

**Usage:**

1. Select source folder containing images
2. Choose output destination and format (PNG/JPG)
3. Configure dimensions for each image size group
4. Start processing and monitor progress

## 📊 **Project Stats**

- **2 Projects** - UI application + utility library
- **5 Input Formats** - Comprehensive image format support
- **Multi-threaded** - Async processing with cancellation
- **Modern UI** - Guna2 components with progress tracking
- **Image Enhancement** - Quality optimization and sharpening

---

**Built for:** Practicing async programming and multi-threading concepts in C#
