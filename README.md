# Asymptotic-Notations-using-Chart-at-.Net-
Asymptotic Notations are languages that allow us to analyze an algorithm’s running time by identifying its behavior as the input size for the algorithm increases. This is also known as an algorithm’s growth rate. Does the algorithm suddenly become incredibly slow when the input size grows? Does it mostly maintain its quick run time as the input size increases? In the first section of this doc we described how an Asymptotic Notation identifies the behavior of an algorithm as the input size changes. Let us imagine an algorithm as a function f, n as the input size, and f(n) being the running time. So for a given algorithm f, with input size n you get some resultant run time f(n). This results in a graph where the Y axis is the runtime, X axis is the input size, and plot points are the resultants of the amount of time for a given input size. You can label a function, or algorithm, with an Asymptotic Notation in many different ways. Some examples are, you can describe an algorithm by its best case, worse case, or equivalent case. The most common is to analyze an algorithm by its worst case. You typically don’t evaluate by best case because those conditions aren’t what you’re planning for. A very good example of this is sorting algorithms; specifically, adding elements to a tree structure. Best case for most algorithms could be as low as a single operation. However, in most cases, the element you’re adding will need to be sorted appropriately through the tree, which could mean examining an entire branch. This is the worst case, and this is what we plan for. And you know that we have six Types of Asymptotic Notation. I used data chart in c# language to show the Quadratic o(n^2) type for every runtime process by using Stopwatch api in C# language in namespace System.Diagnostics.
