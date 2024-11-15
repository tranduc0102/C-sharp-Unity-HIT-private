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

### 5. Ví dụ minh họa:
- Có một lớp trừu tượng Animal đại diện cho các loại động vật.
- Mỗi loại động vật sẽ kế thừa từ Animal và định nghĩa hành vi cụ thể của mình.
- Sử dụng tính đa hình để gọi các phương thức của các loại động vật khác nhau mà không cần biết cụ thể đó là loại động vật nào.

```csharp
// Tính trừu tượng: Lớp trừu tượng Animal mô tả các đặc điểm chung của mọi động vật.
public abstract class Animal
{
    // Thuộc tính: Đóng gói thông tin về tên và tuổi.
    public string Name { get; private set; }
    public int Age { get; private set; }

    // Constructor để khởi tạo thông tin chung của động vật.
    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Phương thức trừu tượng: Các lớp con bắt buộc phải cài đặt.
    public abstract void Speak();

    // Phương thức cụ thể: Có thể dùng chung cho tất cả động vật.
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Tính kế thừa: Lớp Dog kế thừa từ Animal.
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    // Tính đa hình: Ghi đè phương thức Speak để định nghĩa hành vi cụ thể.
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Woof Woof!");
    }
}

// Tính kế thừa: Lớp Cat kế thừa từ Animal.
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    // Tính đa hình: Ghi đè phương thức Speak để định nghĩa hành vi cụ thể.
    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

// Một lớp đặc biệt: Bird không chỉ có hành vi bay mà còn có hành vi kêu khác biệt.
public class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Tweet Tweet!");
    }

    // Đóng gói: Một phương thức riêng của Bird.
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying!");
    }
}

// Chương trình chính
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo danh sách động vật (đa hình).
        Animal[] animals = new Animal[]
        {
            new Dog("Buddy", 3),
            new Cat("Whiskers", 2),
            new Bird("Tweety", 1)
        };

        // Lặp qua danh sách và gọi các phương thức.
        foreach (var animal in animals)
        {
            animal.ShowInfo(); // Thông tin chung của động vật.
            animal.Speak();    // Đa hình: Gọi phương thức Speak phù hợp với từng loại động vật.
            Console.WriteLine();
        }

        // Gọi phương thức riêng của Bird.
        Bird bird = new Bird("Sky", 4);
        bird.ShowInfo();
        bird.Speak();
        bird.Fly(); // Tính đóng gói: Phương thức chỉ thuộc về Bird.
    }
}
```
**Kết quả khi chạy:**
```csharp
    Name: Buddy, Age: 3
    Buddy says: Woof Woof!

    Name: Whiskers, Age: 2
    Whiskers says: Meow!

    Name: Tweety, Age: 1
    Tweety says: Tweet Tweet!

    Name: Sky, Age: 4
    Sky says: Tweet Tweet!
    Sky is flying!
```
## Giải thích:

- **Tính đóng gói (Encapsulation):**
    - Trong đoạn mã, thuộc tính `Name` và `Age` của lớp `Animal` được khai báo là `private`, nghĩa là chúng không thể được truy cập trực tiếp từ bên ngoài lớp. Các thuộc tính này chỉ có thể được truy cập hoặc thay đổi thông qua các phương thức của lớp, như constructor và getter. Điều này giúp bảo vệ dữ liệu, chỉ cho phép truy cập thông qua các phương thức đã được định nghĩa.
    - Phương thức `Fly` được đóng gói riêng chỉ cho lớp `Bird`. Phương thức này không thể được gọi từ các lớp khác, giúp đảm bảo rằng hành vi bay chỉ áp dụng cho đối tượng của lớp `Bird`.

- **Tính trừu tượng (Abstraction):**
    - Lớp `Animal` là lớp trừu tượng (abstract class), có các phương thức và thuộc tính chung cho tất cả các loài động vật như `Name`, `Age`, và phương thức `Speak`. Tuy nhiên, phương thức `Speak` không có cài đặt cụ thể mà chỉ được khai báo dưới dạng trừu tượng, bắt buộc các lớp con phải cài đặt chi tiết hành vi của chúng (ví dụ: `Dog`, `Cat`, `Bird`).
    - Điều này giúp ẩn đi những chi tiết cài đặt và chỉ để lại các phương thức chung để tương tác với đối tượng, tạo điều kiện cho việc mở rộng hệ thống mà không cần thay đổi mã hiện có.

- **Tính kế thừa (Inheritance):**
    - Các lớp `Dog`, `Cat`, và `Bird` kế thừa từ lớp cha `Animal`, nghĩa là chúng tự động có các thuộc tính và phương thức của lớp `Animal` (như `Name`, `Age`, và phương thức `ShowInfo`). Điều này giúp giảm thiểu việc lặp lại mã nguồn và tăng tính tái sử dụng mã.
    - Các lớp con có thể thêm hoặc ghi đè các phương thức để định nghĩa lại hành vi đặc thù của chúng, ví dụ: `Speak`.

- **Tính đa hình (Polymorphism):**
    - Phương thức `Speak` được ghi đè (override) bởi mỗi lớp con để thể hiện hành vi đặc trưng của chúng (chó sủa, mèo kêu, chim hót, v.v.).
    - Tính đa hình cho phép bạn gọi phương thức `Speak` trên một biến kiểu `Animal`, nhưng phương thức thực tế được gọi sẽ phụ thuộc vào kiểu đối tượng thực tế mà biến đó tham chiếu đến (ví dụ: đối tượng `Dog`, `Cat`, hoặc `Bird`). Điều này giúp chương trình linh hoạt hơn và dễ mở rộng.




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
  ```
- **Giải thích:**
  - Lớp `Employee` chỉ giữ thông tin nhân viên, đảm nhiệm trách nhiệm duy nhất là lưu trữ dữ liệu nhân viên.

  - Lớp `SalaryCalculator` chịu trách nhiệm tính toán lương. Việc tách chức năng này giúp đảm bảo mỗi lớp chỉ có một lý do để thay đổi. Nếu công thức tính lương thay đổi, chỉ cần sửa lớp `SalaryCalculator`, không ảnh hưởng đến lớp `Employee`.
## 2. Open/Closed Principle (OCP) - Nguyên tắc đóng mở
- **Mô tả:** Một lớp nên mở để mở rộng nhưng đóng để sửa đổi.**.
- **Giải thích:** Điều này có nghĩa là bạn có thể mở rộng chức năng của lớp (thông qua kế thừa hoặc các cách khác) mà không cần thay đổi mã nguồn hiện tại của lớp đó.
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
  ```
- **Giải thích:**
  - Lớp `Shape` là lớp cơ sở. Các lớp con như `Rectangle` và `Circle` mở rộng `Shape` và cung cấp cách diện tích riêng.

  - Khi thêm một lớp hình mới ` Ví dụ: Triangle`, chỉ cần tạo một lớp mới kế thừa từ shape mà không cần phải sửa đổi code của các lớp hiện tại.


## 3. Liskov Substitution Principle (LSP) - Nguyên tắc thay thế Liskov
- **Mô tả:** Ta có thể thay thế bất kỳ đối tượng của một lớp con bằng đối tượng của lớp cha mà không làm thay đổi tính đúng đắn của chương trình.
- **Giải thích:** Các lớp con phải đảm bảo rằng chúng không làm mất tính đúng đắn của chương trình khi thay thế lớp cha.
- **Ví dụ sai:**
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
  ```
- **Giải thích lỗi:**
    - Nếu dùng Bird làm cha, chúng ta kỳ vọng tất cả các lớp con có thể "bay". Tuy nhiên, Ostrich `đà điểu` không thể bay, dẫn đến việc phá vỡ tính đúng đắn của chương trình khi thay thế Bird bằng Ostrich.
- **Cách sửa:**
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
      ```
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
  ```
-**Giải thích:**

    - Con người `(Human)` vừa làm việc vừa ăn uống, nên triển khai cả IWorker và IEater.

    - Robot chỉ làm việc, không ăn uống, nên chỉ triển khai IWorker.

    - Điều này giúp các lớp chỉ phải triển khai những giao diện phù hợp, tránh việc viết code không cần thiết.
## 5. Dependency Inversion Principle (DIP) - Nguyên tắc phản ngược sự phụ thuộc
- **Mô tả:** Các module cấp cao không nên phụ thuộc vào các module cấp thấp. Thay vào đó, cả hai nên phụ thuộc vào các abstraction (trừu tượng).
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
  ```
-**Giải thích:**

    - Lớp Document phụ thuộc vào abstraction `IPrinter`, không phụ thuộc vào cụ thể `LaserPrinter hay InkJetPrinter`.

    - Nếu cần đổi loại máy in, chỉ cần thay đổi đối tượng truyền vào Document, không cần thay đổi code của lớp Document.

