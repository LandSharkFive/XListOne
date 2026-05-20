# Segmented List (Unrolled Linked List)

A high-performance C# implementation of an **Unrolled Linked List**. This structure combines the flexibility of a Linked List with the cache-efficiency of a contiguous Array, maintaining a sorted collection that handles duplicates with ease.



## 🚀 Why Use a Segmented List?

While standard List<T> and Dictionary<TKey, TValue> are great for general use, the Segmented List excels in specific scenarios:
* **Cache Locality**: By storing 100–300 elements per node, the CPU retrieves data in "chunks," significantly reducing cache misses compared to a standard Linked List.
* **Low Memory Fragmentation**: Unlike a giant List<int> which requires one massive block of memory, this structure allocates smaller "segments," avoiding the Large Object Heap (LOH).
* **Sorted Insertions**: The list remains sorted at all times, making it ideal for priority queues or streaming CSV data.
* **Efficient Deletions**: Removing items only requires shifting data within a small segment rather than re-indexing an entire million-row array.

## 🛠 Features & API

* **Self-Managing Nodes**: Automatically splits or merges segments as data is added or removed.
* **Duplicate Support**: Full support for non-unique values.
* **Search Optimized**: Faster than a standard Linked List due to the ability to "skip" entire segments during traversal.

---

## 💻 Installation & Build

This is a **C# Console-Mode Project** compatible with modern .NET.

1. **Requirements**: Visual Studio 2022 or the .NET SDK.
2. **Setup**: Open the solution file and build (`Ctrl+Shift+B`).
3. **Execution**: Run the project to see a live demonstration of sorted insertions and high-speed deletions.

## 🧪 Quality Assurance

Includes a suite of **Unit Tests** covering:
* Boundary conditions for segment splitting.
* Sorted order integrity after mass deletions.
* Duplicate value handling.
