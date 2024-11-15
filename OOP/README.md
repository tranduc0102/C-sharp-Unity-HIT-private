# Lập trình hướng đối tượng (OOP)

**Lập trình hướng đối tượng (Object-Oriented Programming - OOP)** là một phương pháp lập trình lấy đối tượng làm nền tảng để xây dựng chương trình. Phương pháp này dựa trên kiến trúc **lớp (class)** và **đối tượng (object)**.

## 1. Khái niệm cơ bản trong OOP

### Đối tượng (Object)
- Đối tượng là một thực thể trong lập trình, có thể đại diện cho: con người, sự vật, hoặc một bảng dữ liệu,...
- Mỗi đối tượng bao gồm:
  - **Thuộc tính:** Thông tin hoặc đặc điểm của đối tượng. Ví dụ: họ tên, ngày sinh, màu da, kiểu tóc của một người.
  - **Phương thức:** Các hành động mà đối tượng có thể thực hiện. Ví dụ: nói, đi, ăn, uống.

### Lớp (Class)
- Lớp là tập hợp các đối tượng có đặc điểm và hành vi giống nhau.
- Một lớp bao gồm:
  - **Thuộc tính:** Mô tả dữ liệu chung của các đối tượng trong lớp.
  - **Phương thức:** Xác định các hành động mà đối tượng có thể thực hiện.
- Lớp cũng được sử dụng để định nghĩa kiểu dữ liệu mới.

### Phân biệt giữa lớp và đối tượng:
- **Lớp:** Là khuôn mẫu, bản thiết kế.
- **Đối tượng:** Là thể hiện cụ thể của lớp.

## 2. Các đặc điểm chính của lập trình hướng đối tượng

### 1. Tính đóng gói (Encapsulation)
- Dữ liệu và phương thức liên quan được đóng gói trong một lớp.
- Tính đóng gói giúp:
  - Dễ dàng quản lý và sử dụng.
  - Che giấu thông tin và chi tiết cài đặt nội bộ, ngăn không cho bên ngoài truy cập trực tiếp.

### 2. Tính trừu tượng (Abstraction)
- Tập trung vào các đặc điểm chung, bỏ qua chi tiết không cần thiết.
- Các đối tượng được trừu tượng hóa thành giao diện (interface) và được thiết kế để tương tác với nhau.

### 3. Tính kế thừa (Inheritance)
- Một lớp con có thể kế thừa dữ liệu và phương thức từ lớp cha.
- Giảm thiểu việc viết lại mã nguồn và giúp chương trình gọn gàng hơn.

### 4. Tính đa hình (Polymorphism)
- Đối tượng thuộc các lớp khác nhau có thể hiểu cùng một thông điệp theo cách riêng.
- Giúp các lớp mở rộng linh hoạt mà không cần thay đổi mã hiện tại.

## 3. Ví dụ minh họa:
Xét các hình: Hình tròn, Hình vuông, Hình chữ nhật.  
Thay vì tạo từng lớp riêng lẻ, ta xây dựng một lớp trừu tượng `Shape`:

```csharp
public abstract class Shape
{
    // Phương thức trừu tượng
    public abstract void Area();
    
    // Đóng gói: phương thức hiển thị chỉ có thể truy cập trong lớp con
    protected void DisplayArea(double area)
    {
        Console.WriteLine($"Diện tích hình là: {area}");
    }
}

public class Rectangle : Shape
{
    private float height, width;

    // Ghi đè phương thức Area
    public override void Area()
    {
        double area = height * width;
        DisplayArea(area);
    }
}


# Nguyên tắc thiết kế SOLID trong Lập trình Hướng đối tượng

**SOLID** là tập hợp 5 nguyên tắc thiết kế phần mềm trong lập trình hướng đối tượng, giúp tạo ra mã nguồn linh hoạt, dễ bảo trì và mở rộng. Các nguyên tắc này bao gồm:

## 1. Single Responsibility Principle (SRP) - Nguyên tắc đơn trách nhiệm
- **Mô tả:** Một lớp chỉ nên có **một lý do duy nhất để thay đổi**, tức là lớp đó chỉ nên đảm nhiệm **một trách nhiệm duy nhất**.
- **Giải thích:** Khi thay đổi diễn ra, chỉ lớp đó cần phải thay đổi mà không ảnh hưởng đến các lớp khác trong chương trình.
- **Ví dụ:**
  ```csharp
  public class Employee
  {
      public string Name { get; set; }
      public double Salary { get; set; }
  }

  // Không nên xử lý cả việc tính toán lương trong Employee, nên tách riêng thành lớp khác.
  public class SalaryCalculator
  {
      public double CalculateSalary(Employee employee)
      {
          return employee.Salary * 1.1;
      }
  }
- **Giải thích:**
  - Lớp `Employee` chỉ giữ thông tin nhân viên, đảm nhiệm trách nhiệm duy nhất là lưu trữ dữ liệu nhân viên.
  - Lớp `SalaryCalculator` chịu trách nhiệm tính toán lương. Việc tách chức năng này giúp đảm bảo mỗi lớp chỉ có một lý do để thay đổi. Nếu công thức tính lương thay đổi, chỉ cần sửa lớp `SalaryCalculator`, không ảnh hưởng đến lớp `Employee`.
## 2. Open/Closed Principle (OCP) - Nguyên tắc đóng mở
- **Mô tả:**Một lớp nên mở để mở rộng nhưng đóng để sửa đổi.**.
- **Giải thích:**Điều này có nghĩa là bạn có thể mở rộng chức năng của lớp (thông qua kế thừa hoặc các cách khác) mà không cần thay đổi mã nguồn hiện tại của lớp đó. .
- **Ví dụ:**
  ```csharp
  public abstract class Shape
  {
     public abstract double Area();
  }

  public class Rectangle : Shape
  {
     public double Width { get; set; }
     public double Height { get; set; }

     public override double Area()
     {
         return Width * Height;
     }
  }

  public class Circle : Shape
  {
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
  }
- **Giải thích:**
  - Lớp `Shape` là lớp cơ sở. Các lớp con như `Rectangle` và `Circle` mở rộng `Shape` và cung cấp cách diện tích riêng.
  - Khi thêm một lớp hình mới ` Ví dụ: Triangle`, chỉ cần tạo một lớp mới kế thừa từ shape mà không cần phải sửa đổi code của các lớp hiện tại.


## 3. Liskov Substitution Principle (LSP) - Nguyên tắc thay thế Liskov
- **Mô tả:**Ta có thể thay thế bất kỳ đối tượng của một lớp con bằng đối tượng của lớp cha mà không làm thay đổi tính đúng đắn của chương trình.**.
- **Giải thích:** Các lớp con phải đảm bảo rằng chúng không làm mất tính đúng đắn của chương trình khi thay thế lớp cha.
- **Ví dụ sai: **
  ```csharp
  public class Bird
  {
      public virtual void Fly() { }
  }

  public class Sparrow : Bird
  {
      public override void Fly() { /* Chim sẻ bay */ }
  }

  public class Ostrich : Bird
  {
      // Sẽ gây lỗi nếu Ostrich thay thế Bird và gọi phương thức Fly() vì Ostrich không bay
      public override void Fly() { throw new NotImplementedException(); }
  }
- **Giải thích lỗi: **
    - Nếu dùng Bird làm cha, chúng ta kỳ vọng tất cả các lớp con có thể "bay". Tuy nhiên, Ostrich `đà điểu` không thể bay, dẫn đến việc phá vỡ tính đúng đắn của chương trình khi thay thế Bird bằng Ostrich.
- **Cách sửa: *
    - Đừng đưa Fly vào lớp cha Bird. Thay vào đó, tách thành một interface IFlyingBird chỉ áp dụng cho các loài chim biết bay
      ```csharp
      public interface IFlyingBird
      {
            void Fly();
      }

      public class Sparrow : IFlyingBird
      {
            public void Fly() { /* Chim sẻ bay */ }
      }

      public class Ostrich
     {
            // Không cần phương thức Fly()
     }

## 4. Interface Segregation Principle (ISP) - Nguyên tắc phân chia giao diện
- **Mô tả:** Không nên buộc một lớp phải triển khai các phương thức mà nó không sử dụng. Nên chia nhỏ các giao diện thành nhiều giao diện nhỏ hơn, đặc trưng cho từng mục đích sử dụng.**.
- **Giải thích:** Các lớp chỉ cần triển khai các phương thức trong giao diện mà chúng thực sự cần.
- **Ví dụ:**
  ```csharp
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public class Human : IWorker, IEater
{
    public void Work() { /* Làm việc */ }
    public void Eat() { /* Ăn uống */ }
}

public class Robot : IWorker
{
    public void Work() { /* Làm việc */ }
}
-**Giải thích:**
    - Con người `(Human)` vừa làm việc vừa ăn uống, nên triển khai cả IWorker và IEater.
    - Robot chỉ làm việc, không ăn uống, nên chỉ triển khai IWorker.
    - Điều này giúp các lớp chỉ phải triển khai những giao diện phù hợp, tránh việc viết code không cần thiết.
## 5. Dependency Inversion Principle (DIP) - Nguyên tắc phản ngược sự phụ thuộc
- **Mô tả:** Các module cấp cao không nên phụ thuộc vào các module cấp thấp. Thay vào đó, cả hai nên phụ thuộc vào các abstraction (trừu tượng).**.
- **Giải thích:**  Các module cấp cao và cấp thấp không nên phụ thuộc trực tiếp vào nhau mà nên phụ thuộc vào các interface hoặc lớp trừu tượng.
- **Ví dụ:**
  ```csharp
public interface IPrinter
{
    void Print(string content);
}

public class LaserPrinter : IPrinter
{
    public void Print(string content) { /* In với máy in laser */ }
}

public class InkJetPrinter : IPrinter
{
    public void Print(string content) { /* In với máy in phun mực */ }
}

public class Document
{
    private readonly IPrinter _printer;

    public Document(IPrinter printer)
    {
        _printer = printer;
    }

    public void PrintDocument(string content)
    {
        _printer.Print(content);
    }
}
-**Giải thích:*
    - Lớp Document phụ thuộc vào abstraction `IPrinter`, không phụ thuộc vào cụ thể `LaserPrinter hay InkJetPrinter`.
    - Nếu cần đổi loại máy in, chỉ cần thay đổi đối tượng truyền vào Document, không cần thay đổi code của lớp Document.

