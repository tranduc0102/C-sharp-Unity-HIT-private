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
      ```
    Trong đó: 
        - `condition` là một biểu thức logic bắt buộc phải có với kết quả trả về bắt buộc là `true` hoặc `false`.
        - Từ khóa `do` và `while` biểu thị đây là một `vòng lặp do while`. Các câu lệnh trong khối lệnh sẽ được lặp lại đến khi không còn thỏa mãn điều kiện lặp sẽ kết thúc `vòng lặp do while`.
    Tiến trình:
        - Đầu tiên trình biên dịch sẽ đi vào dòng `do` và thực hiện khối lệnh bên trong. Sau đó khi gặp ký tự `}` sẽ kiểm tra điều kiện lặp có thỏa mãn hay không. Nếu kết quả là `true` thì sẽ quay lại ký tự `{` thực hiện khối lệnh. Quá trình chỉ kết thúc khi điều kiện lặp là `false`.
        - Điều kiện lặp luôn bằng `true` thì `vòng lặp do while` sẽ trở thành `vòng lặp vô tận`.
        - Điều kiện lặp luôn bằng `false` thì vòng lặp sẽ `không được thực thi`.
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

### 1. ArrayList
`ArrayList` là một Collection giống như mảng nhưng có thể thay đổi kích thước linh hoạt và quản lý các đối tượng qua chỉ số.

- **Cú pháp:**
    ```csharp
    ArrayList myArray = new ArrayList();
    ArrayList myArray2 = new ArrayList(5); // Với sức chứa ban đầu là 5
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
    - **Enqueue(object value)**: Thêm phần tử vào cuối Queue.
    - **
