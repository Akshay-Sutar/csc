# **C# Learning Path**

### **Basics**
  * Net Framework
    - [`Overview`](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/#net-architecture)
    - [`CLR`](https://docs.microsoft.com/en-us/dotnet/standard/clr)
    - [`IL`](https://www.geeksforgeeks.org/cil-or-msil-microsoft-intermediate-language-or-common-intermediate-language/)
  * [`C# Compilation process`](https://www.c-sharpcorner.com/blogs/compilation-process-of-a-c-sharp-program1)
    - [`Compiling and linking`](https://stackoverflow.com/questions/5308491/what-are-the-obj-and-bin-folders-created-by-visual-studio-used-for)
  * Memory allocation in .NET
    - [`Stack and Managed Heap`](https://dotnettutorials.net/lesson/stack-and-heap-dotnet/)
  * [`Garbage collection C#`](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)

<br/>

### **OOP**
  * [`Struct`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)
  * Class
    - [`Regular`](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes#declaring-classes)
    - [`Abstract`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members#abstract-classes-and-class-members)
    - [`Static`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
    - [`Partial`](https://www.tutorialsteacher.com/csharp/csharp-partial-class)
    - [`Sealed`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members#sealed-classes-and-class-members)
  * [`this keyword`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this)
  * Constructor 
    - [`Default`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
    - [`Parameterized`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors#constructor-syntax)
    - [`Static`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors#static-constructors)
    - [`Constructor Chaining`](https://stackoverflow.com/questions/1814953/how-to-do-constructor-chaining-in-c-sharp)
  * [`Destructors`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/destructors)
  * [`Enums`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
  * [`Interfaces`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
  * [`Records (C# 9)`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record)
  * Polymorphism
    - [`Method overloading`](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading)
    - [`Operator overloading`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)
    - [`Virtual members`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)
    - [`Overriden members`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override)
    - [`Local functions (C# 7)`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
    - [`Generics`](https://www.tutorialsteacher.com/csharp/csharp-generics)
    - [`Constraint on generics`](https://www.tutorialsteacher.com/csharp/constraints-in-generic-csharp)
  
  * [`Inheritance`](https://www.geeksforgeeks.org/c-sharp-inheritance/)
    - [`Single`](https://www.tutorialspoint.com/Chash-Example-for-Single-Inheritance)
    - [`Multilevel`](https://www.geeksforgeeks.org/c-sharp-multilevel-inheritance/)
    - [`Namespaces and Fully qualified namespaces`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/namespaces)

<br/>  

### **Core concepts**
  * [`Null coalescing operator '??'`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)
  * [`Safe evaluation operator '?.'`](https://stackoverflow.com/questions/32261869/c-sharp-safe-navigation-operator-what-is-actually-going-on)
  * [`readonly keyword`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly)
  * [`const keywords`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const)
  * [`ref keyword`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref)
  * [`out keyword`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier)
  * [`params keyword`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params) 
  * [`Value types`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
    - [`Signed integers (sbyte, short, int, long)`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
    - [`Unsigned integers (byte, ushort, uint, ulong)`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
    - [`IEEE 754 floating point to binary representation`](https://www.youtube.com/watch?v=L8OYx1I8qNg&t=48s)
    - float (IEEE Single Precision)
    - double (IEEE Double Precision)
    - decimal
    - [`Nullable<T> types`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
    - [`Enum`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
    - [`ValueTuple (C# 7)`](https://www.tutorialsteacher.com/csharp/valuetuple)
  * [`Reference types`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)
    - [`Class types`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class)
    - [`Interface types`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
    - [`Array types`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
  * [`Boxing and Unboxing`](https://www.tutorialsteacher.com/articles/boxing-unboxing-in-csharp)
  * [`is operator`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is)
  * [`as operator`](https://makolyte.com/csharp-the-is-and-as-operators/)
  * [`typeof operator`](https://www.geeksforgeeks.org/typeof-operator-keyword-in-c-sharp/)
  * [`nameof operator (C# 6)`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof)
  * Math utilities
    - [`Math.Pow`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-5.0)
    - [`Math.Round`](https://docs.microsoft.com/en-us/dotnet/api/system.math.round?view=net-5.0)
    - [`Math.DivRem`](https://docs.microsoft.com/en-us/dotnet/api/system.math.divrem)
    - [`Math.Floor`](https://docs.microsoft.com/en-us/dotnet/api/system.math.floor)
    - [`Math.Ceiling`](https://docs.microsoft.com/en-us/dotnet/api/system.math.ceiling)
    - [`Math.Abs`](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-5.0)
  * [`BigIntegers`](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-5.0)
  * Control statements
    - if
    - else
    - if-else
    - if-elseif-else
    - switch 
    - ternary operator
    - return
    - break
    - continue
    - throw
    - [`Pattern matching`](https://www.youtube.com/watch?v=9lvx6mzCAE4)
  * Loop statements
    - for
    - while
    - do-while
    - foreach
  * [`Implicitly typed variables (var)`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var)
  * [`Duck typing`](https://stackoverflow.com/questions/4205130/what-is-duck-typing)
    - Duck typing in C# using [`dynamic and ExpandoObject`](https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.expandoobject?view=net-5.0)
  * [`Immutable strings (System.String)`](https://www.tutorialsteacher.com/csharp/csharp-string)
    - [`String Encoding (UTF-8, UTF-16, Unicode)`]()
    - [`Byte order mark (BOM)`]()
    - string.Join
    - string.Replace
    - string.IndexOf
    - string.IsNullOrEmpty
    - string.Format
    - Verbatim strings
    - interpolated strings
  * [`Mutable strings (System.Text.StringBuilder)`](https://www.tutorialsteacher.com/csharp/csharp-stringbuilder)
    - StringBuilder.Append
    - StringBuilder.AppendLine
    - StringBuilder.AppendFormat
  * Delegates
  - [`Non generic delegate`](https://www.tutorialsteacher.com/csharp/csharp-delegates)
  - [`Multicast delegate`](https://www.tutorialsteacher.com/csharp/csharp-delegates)
  - [`Func<TIn, Tout>`](https://www.tutorialsteacher.com/csharp/csharp-func-delegate)
  - [`Predicate<T>`](https://www.tutorialsteacher.com/csharp/csharp-predicate)
  - [`Action<T>`](https://www.tutorialsteacher.com/csharp/csharp-action-delegate)
  
  * [`Fields`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields)
  * [`Auto-implemented properties { get; set; }`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
  * [`Indexers`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/)
  * [`Extension methods`](https://www.tutorialsteacher.com/csharp/csharp-extension-method)
  * [`Attributes`](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/)
  * [`Exception handling`](https://www.tutorialsteacher.com/csharp/csharp-exception-handling)
    - [`Try, catch and finally blocks`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch-finally)
    - [`throw vs throw new Exception`](https://stackoverflow.com/questions/2999298/difference-between-throw-and-throw-new-exception)
    - [`Creating custom exceptions`](https://www.tutorialsteacher.com/csharp/custom-exception-csharp) 
    - [`when clause in exceptions`](https://weblogs.asp.net/dixin/c-6-0-exception-filter-and-when-keyword)

<br/>

### **Regular Expressions**
  * Fundamental Concepts
    - [`Character class`](https://www.regular-expressions.info/charclass.html)
    - [`Quantifiers`](https://www.regular-expressions.info/repeat.html)
    - [`Alternation`](https://www.regular-expressions.info/alternation.html)
    - [`Capturing Groups`](https://www.regular-expressions.info/brackets.html)
    - [`Backreferences`](https://www.regular-expressions.info/backref.html)
    - [`Lookarounds (Positive lookahead, Negative Lookahead, Positive Lookbehind and Negative Lookbehind`](https://www.regular-expressions.info/lookaround.html)
  * `System.Text.RegularExpressions`
    - [`Regex.Split`](https://www.dotnetperls.com/regex-split)
    - [`Regex.IsMatch`](https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.ismatch)
    - [`Regex.Match`](https://www.dotnetperls.com/regex)

<br/>
   
### **Collections**
  * [`1d array`](https://www.tutorialsteacher.com/csharp/array-csharp)
  * [`Multi-dimensional array`](https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array)
  * [`Jagged array`](https://www.tutorialsteacher.com/csharp/csharp-jagged-array)
  * Array methods most used
    - [`Array.Copy`](https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-5.0)
    - [`Array.Clone`](https://docs.microsoft.com/en-us/dotnet/api/system.array.clone?view=net-5.0)
    - [`Array.Sort`](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-5.0)
    - [`Array.ConvertAll`](https://docs.microsoft.com/en-us/dotnet/api/system.array.convertall?view=net-5.0)
    - [`Array.Reverse`](https://docs.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-5.0)
    - [`Array.Empty<T>()`](https://docs.microsoft.com/en-us/dotnet/api/system.array.empty?view=net-5.0)
    - [`Array.GetLowerBound`](https://docs.microsoft.com/en-us/dotnet/api/system.array.getlowerbound?view=net-5.0)
    - [`Array.GetUpperBound`](https://docs.microsoft.com/en-us/dotnet/api/system.array.getupperbound?view=net-5.0)
  * [`List<T>`](https://www.tutorialsteacher.com/csharp/csharp-list)
  * [`Dictionary<TKey, TValue>`](https://www.tutorialsteacher.com/csharp/csharp-dictionary)
  * [`Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>`](https://www.tutorialsteacher.com/csharp/csharp-tuple)
  * [`HashSet<T>`](https://www.geeksforgeeks.org/hashset-in-c-sharp-with-examples/)
  * [`Stack<T>`](https://www.geeksforgeeks.org/c-sharp-stack-with-examples/?ref=lbp)
  * [`Queue<T>`](https://www.geeksforgeeks.org/c-sharp-queue-with-examples/?ref=lbp)
  * [`LinkedList<T> (Native double linked list implementation)`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-5.0)
  * [`Yield keyword`](https://www.youtube.com/playlist?list=PL9B5E4C37F7B234A8)
  * [`IEnumerator<T> and IEnumerator`](https://stackoverflow.com/questions/558304/can-anyone-explain-ienumerable-and-ienumerator-to-me)
  * LINQ
    - Select
    - Where
    - Distinct
    - Except
    - Find
    - FindAll
    - Contains
    - Any
    - All
    - Aggregate
    - Max
    - Min
    - Join
    - GroupBy
    - Aggregate
    - Zip
  * [`Expression trees`](https://www.youtube.com/playlist?list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg)

<br/>
    
### **I/O**
   * [`File`](https://www.tutorialsteacher.com/csharp/csharp-file)
   * [`FileInfo`](https://www.tutorialsteacher.com/csharp/csharp-fileinfo)
   * [`Streams`](https://www.tutorialsteacher.com/csharp/csharp-stream-io)
   * [`Path`](https://www.dotnetperls.com/path)
   * [`Directory`](https://docs.microsoft.com/en-us/dotnet/api/system.io.directory?view=net-5.0)
   * [`DirectoryInfo`](https://docs.microsoft.com/en-us/dotnet/api/system.io.directoryinfo?view=net-5.0)
   * [`ZipFile`](https://docs.microsoft.com/en-us/dotnet/api/system.io.compression.zipfile?view=net-5.0)

<br/>   
   
### **Reflection**
   * [`FieldInfo, MethodInfo and PropertyInfo`](https://www.dotnetperls.com/reflection)
   * [`Activator.CreateInstance`](https://stackoverflow.com/questions/7598088/purpose-of-activator-createinstance-with-example)

<br/>

### **Synchronization Primitives**
   * [`Threads`](https://stackoverflow.com/questions/5201852/what-is-a-thread-really)
   * [`Thread class, Parameterized thread class`](https://www.geeksforgeeks.org/thread-class-in-c-sharp/)
   * [`Foreground and background threads`](https://docs.microsoft.com/en-us/dotnet/standard/threading/foreground-and-background-threads)
   * [`ThreadStatic attribute`](https://docs.microsoft.com/en-us/dotnet/api/system.threadstaticattribute?view=net-5.0)
   * [`Joining threads`](https://www.geeksforgeeks.org/joining-threads-in-c-sharp/)
   * [`Monitors`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.monitor?view=net-5.0)
   * [`lock`](https://stackoverflow.com/questions/6029804/what-does-a-lock-statement-do-under-the-hood)
   * [`Mutex`](https://docs.microsoft.com/en-us/dotnet/api/system.threading.mutex?view=net-5.0)
   * [`SemaphoreSlim`](https://www.youtube.com/watch?v=GKjM4AX8NME)
   * [`Channels`](https://devblogs.microsoft.com/dotnet/an-introduction-to-system-threading-channels/)

<br/>
  
### **Process**
  * Process class
    - [`Process.Start`](https://www.dotnetperls.com/process)
  * [`Process vs threads`](https://stackoverflow.com/questions/200469/what-is-the-difference-between-a-process-and-a-thread)

<br/>
  
### **Tasks**
  * [`Tasks in C#`](https://blog.stephencleary.com/2014/04/a-tour-of-task-part-0-overview.html)
  * [`Delegate tasks`](https://blog.stephencleary.com/2015/03/a-tour-of-task-part-9-delegate-tasks.html)
  * [`Promise tasks`](https://blog.stephencleary.com/2015/04/a-tour-of-task-part-10-promise-tasks.html)
  * [`Lifecycle of task`](https://blog.stephencleary.com/2014/06/a-tour-of-task-part-3-status.html)
  * [`Id`](https://blog.stephencleary.com/2014/06/a-tour-of-task-part-4-id.html)
  * [`Starting`](https://blog.stephencleary.com/2015/02/a-tour-of-task-part-8-starting.html)
  * [`Waiting`](https://blog.stephencleary.com/2014/10/a-tour-of-task-part-5-wait.html)
  * [`Results`](https://blog.stephencleary.com/2014/12/a-tour-of-task-part-6-results.html)
  * [`Continuations`](https://blog.stephencleary.com/2015/01/a-tour-of-task-part-7-continuations.html)
  * [`Cancellation tokens`](https://www.youtube.com/watch?v=TKc5A3exKBQ)
  * [`async and await`](https://blog.stephencleary.com/2012/02/async-and-await.html)

<br/>

## **Security**
  * Hashing
    - [`SHA512 hashing`](https://github.com/kunalm8470/security_in_dotnet/blob/main/Hashing/Hashing/Models/ShaHasher.cs)
    - [`Bcrypt hashing`](https://github.com/kunalm8470/security_in_dotnet/blob/main/Hashing/Hashing/Models/BcryptHasher.cs)
  * Symmetric key encryption
    - [`AES algorithm overview`](https://www.youtube.com/watch?v=rLEJLuA3hd0&t=1497s)
    - [`AES algorithm`](https://github.com/kunalm8470/security_in_dotnet/blob/main/SymmetricKeyEncryption/SymmetricKeyEncryption/SymmetricKeyEncryption.cs)
  * Asymmetric key encryption
    - [`RSA algorithm overview`](https://www.youtube.com/watch?v=cKWA8f7xdL8&t=1s)
    - [`RSA alogrithm`](https://github.com/kunalm8470/security_in_dotnet/blob/main/AsymmetricKeyEncryption/AsymmetricKeyEncryption/AsymmetricKeyEncryption.cs)
  * [`Elliptic Curve Cryptography`](https://www.youtube.com/watch?v=dCvB-mhkT0w)
    - [`Elliptic Curve Digital Signature Algorithm (ECDSA)`](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.ecdsa.create?view=net-5.0)

<br/>

### **HTTP Requests**
  * [`Sending HTTP requests using System.Net.HttpClient`](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient)

<br/>

### **[JSON.NET (Newtonsoft.JSON)](https://www.newtonsoft.com/json)**
  * [`Serialize POCO object into JSON`](https://www.newtonsoft.com/json/help/html/SerializingJSON.htm#JsonConvert)
  * [`Deserialize JSON into POCO`](https://www.newtonsoft.com/json/help/html/SerializingJSON.htm#JsonConvert)
  * Newtonsoft.Json Common utilities
    - JObject
    - JProperty
    - JToken
    - JArray