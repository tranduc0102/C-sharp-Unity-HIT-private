# Cấu trúc Vòng lặp và Mảng trong C#

## Mục lục
1. [Cấu trúc Vòng lặp](#1-cấu-trúc-vòng-lặp)
    - [Vòng lặp `for`](#vòng-lặp-for)
    - [Vòng lặp `foreach`](#vòng-lặp-foreach)
    - [Vòng lặp `while`](#vòng-lặp-while)
    - [Vòng lặp `do-while`](#vòng-lặp-do-while)
    - [Vòng lặp `goto`](#vòng-lặp-goto)
2. [Từ khóa Điều khiển Luồng](#2-từ-khóa-điều-khiển-luồng)
3. [Mảng](#3-mảng)
    - [Mảng Một Chiều](#mảng-một-chiều)
    - [Mảng Nhiều Chiều](#mảng-nhiều-chiều)
4. [Định dạng Code trong Visual Studio](#4-định-dạng-code-trong-visual-studio)
5. [Collection trong C#](#5-collection-trong-c)
    - [ArrayList](#1-arraylist)
    - [Hashtable](#2-hashtable)
    - [Stack](#3-stack)
    - [Queue](#4-queue)
    - [Dictionary](#5--dictionary)

---

## 1. Cấu trúc Vòng lặp

### Vòng lặp `for`
Vòng lặp `for` lặp lại một khối mã khi điều kiện còn đúng.

- **Cú pháp:**
    ```csharp
    for (initialization; condition; iteration)
    {
        // Code block
    }
    ``` 
- **Ví dụ:**
    ```csharp
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Số hiện tại: {i}");
    }
    ```

### Vòng lặp `foreach`
Dùng để duyệt qua tất cả phần tử của một tập hợp.

- **Cú pháp:**
    ```csharp
    foreach (DataType item in collection)
    {
        // Code block
    }
    ```
- **Ví dụ:**
    ```csharp
    string[] fruits = { "Táo", "Cam", "Xoài" };
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    ```

### Vòng lặp `while`
Lặp lại khi điều kiện còn đúng.

- **Cú pháp:**
    ```csharp
    while (condition)
    {
        // Code block
    }
    ```
- **Ví dụ:**
    ```csharp
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine("Giá trị của i: " + i);
        i++;
    }
    ```

### Vòng lặp `do-while`
Luôn thực hiện ít nhất một lần trước khi kiểm tra điều kiện.

- **Cú pháp:**
    ```csharp
    do
    {
        // Code block
    } while (condition);
    ```
- **Ví dụ:**
    ```csharp
    int i = 0;
    do
    {
        Console.WriteLine("Giá trị của i: " + i);
        i++;
    } while (i < 5);
    ```

### Vòng lặp `goto`
Điều khiển luồng mã bằng cách nhảy đến một nhãn nhất định.

- **Cú pháp:**
    ```csharp
    int count = 0;
    StartLoop: // Đây là label
    Console.WriteLine("Count: " + count);
    count++;
    if (count < 5)
    {
        goto StartLoop;
    }
    ```
- **Ví dụ:**
    ```csharp
    int count = 0;
    StartLoop:
    Console.WriteLine("Count: " + count);
    count++;
    if (count < 5)
    {
        goto StartLoop;
    }
    ```

## 2. Từ khóa Điều khiển Luồng
- **break**: Thoát khỏi vòng lặp hoặc switch.
- **continue**: Bỏ qua phần còn lại và bắt đầu vòng lặp tiếp theo.
- **goto**: Nhảy đến một nhãn xác định.
- **return**: Kết thúc phương thức và trả về giá trị (nếu có).
- **throw**: Phát sinh ngoại lệ.
- **try, catch, finally**: Xử lý ngoại lệ.

## 3. Mảng
### Mảng Một Chiều
Mảng là tập hợp các phần tử có cùng kiểu dữ liệu.

- **Cú pháp:**
    ```csharp
    // Khai báo
    dataType[] arrayName = new dataType[size];

    // Khởi tạo với giá trị
    dataType[] arrayName = new dataType[] { value1, value2 };
    ```
- **Ví dụ:**
    ```csharp
    int[] numbers = { 10, 20, 30 };
    Console.WriteLine(numbers[0]); // Output: 10
    ```

### Mảng Nhiều Chiều
Dùng cho các tập hợp dữ liệu dạng bảng, như ma trận.

- **Cú pháp:**
    ```csharp
    dataType[,] arrayName = new dataType[rows, columns];
    ```
- **Ví dụ:**
    ```csharp
    int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
    Console.WriteLine(matrix[0, 1]); // Output: 2
    ```

## 4. Định dạng Code trong Visual Studio
- **Format toàn bộ tệp tin**: `Ctrl + K, Ctrl + D`
- **Format đoạn code đã chọn**: `Ctrl + K, Ctrl + F`

## 5. Collection trong C#

### 1. List
`List` là một Collection giống như mảng nhưng có thể thay đổi kích thước linh hoạt và quản lý các đối tượng qua chỉ số.

- **Cú pháp:**
    ```csharp
    List<data type> myArray = new List<data type>();
    List<data type> myArray2 = new List<data type>(5); // Với sức chứa ban đầu là 5
    ```
- **Thuộc tính:**
    - **Count**: Số phần tử hiện có trong ArrayList.
    - **Capacity**: Sức chứa của ArrayList, tự động tăng khi cần thiết.
- **Phương thức:**
    - **Add(object value)**: Thêm phần tử vào cuối.
    - **Remove(object value)**: Xóa phần tử đầu tiên gặp.
    - **Clear()**: Xóa toàn bộ phần tử.
    - **Contains(object value)**: Kiểm tra phần tử có tồn tại hay không.

### 2. Hashtable
`Hashtable` lưu trữ dữ liệu dưới dạng cặp Key-Value, cho phép truy cập Value thông qua Key.

- **Cú pháp:**
    ```csharp
    Hashtable myHash = new Hashtable();
    Hashtable myHash2 = new Hashtable(5); // Với sức chứa ban đầu là 5
    ```
- **Thuộc tính:**
    - **Count**: Số lượng cặp Key-Value.
    - **Keys**: Danh sách các Key.
    - **Values**: Danh sách các Value.
- **Phương thức:**
    - **Add(object key, object value)**: Thêm cặp Key-Value.
    - **Clear()**: Xóa tất cả phần tử.
    - **ContainsKey(object key)**: Kiểm tra sự tồn tại của Key.
    - **ContainsValue(object value)**: Kiểm tra sự tồn tại của Value.
    - **Remove(object key)**: Xóa phần tử dựa trên Key.

### 3. Stack
`Stack` là cấu trúc dữ liệu theo nguyên lý LIFO (Last In First Out).

- **Cú pháp:**
    ```csharp
    Stack myStack = new Stack();
    Stack myStack2 = new Stack(5); // Với sức chứa ban đầu là 5
    ```
- **Thuộc tính:**
    - **Count**: Số phần tử trong Stack.
- **Phương thức:**
    - **Push(object value)**: Thêm phần tử vào đầu Stack.
    - **Pop()**: Lấy và xóa phần tử trên cùng.
    - **Peek()**: Lấy phần tử trên cùng mà không xóa.
    - **Clear()**: Xóa tất cả phần tử.
    - **Contains(object value)**: Kiểm tra sự tồn tại của phần tử.

### 4. Queue
`Queue` là cấu trúc dữ liệu theo nguyên lý FIFO (First In First Out).

- **Cú pháp:**
    ```csharp
    Queue myQueue = new Queue();
    Queue myQueue2 = new Queue(5); // Với sức chứa ban đầu là 5
    ```
- **Thuộc tính:**
    - **Count**: Số phần tử trong Queue.
- **Phương thức:**
    - **Enqueue(object value)**: Tthêm phần tử vào cuối hàng đợi.
    - **Dequeue()**: lấy phần tử ra khỏi đầu hàng đợi.
    - **ToArray()**: Tạo ra 1 mảng các object  chứa tất cả các phần tử trong Queue và trả về mảng đó.
    - **Clear()**: Xoá tất cả các phần tử trong Queue .
    - **Contains(object value)**: Kiểm tra đối tượng Value có tồn tại trong Queue hay không.
### 5.  Dictionary
Tương tự như List, `Dictionary` chính là sự thay thế cho Collections Hashtable đã được học. Cho nên về khái niệm hay sử dụng thì Dictionary đều sẽ giống Hashtable.

- **Cú pháp:**
    ```csharp
    // khởi tạo 1 Dictionary rỗng với Key và Value đều có kiểu dữ liệu là chuỗi.
    Dictionary<string, string> MyHash = new Dictionary<string, string>(); 
    // khởi tạo 1 Dictionary rỗng với Key và Value đều có kiểu dữ liệu là chuỗi.
    Dictionary<string, string> MyHash = new Dictionary<string, string>(); 
- **Thuộc tính:**
    - **Count**: Trả về 1 số nguyên là số phần tử hiện có trong Dictionary.
    - **Keys**: Trả về 1 danh sách chứa các Key trong Dictionary.
    - **Values**:  Trả về 1 danh sách chứa các Value trong Dictionary.
- **Phương thức:**
    - **Add(TKey Key, TValue Value)**: Thêm 1 cặp Key - Value vào Dictionary.
    - **Clear()**: Xoá tất cả các phần tử trong Dictionary.
    - **ContainsKey(TKey Key)**: Kiểm tra đối tượng Key có tồn tại trong Dictionary hay không.
    - **ContainsValue(TValue Value)**: Kiểm tra đối tượng Value có tồn tại trong Dictionary hay không.
    - **Remove(TKey Key)**: Xoá đối tượng có Key xuất hiện đầu tiên trong Dictionary.
    - **TryGetValue(TKey Key, TValue Value)**: Kiểm tra Key có tồn tại hay không. Nếu có sẽ trả về true đồng thời trả về giá trị Value tương ứng qua biến Value. Ngược lại trả về false.
- **Một số lưu ý về Dictionary:**
    - Mỗi một phần tử trong Dictionary (bao gồm 1 cặp Key - Value) được C# định nghĩa là 1 đối tượng có kiểu: KeyValuePair<TKey, TValue>
    - Trong đó, có 2 thuộc tính chính:
        Key: trả về giá trị Key của phần tử hiện tại.
        Value: trả về giá trị Value của phần tử hiện tại.
