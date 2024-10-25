# Tổng Quan về C# và Lập Trình Hướng Đối Tượng

## Mục Lục
- [Tổng quan về C# và lập trình hướng đối tượng](#tổng-quan-về-c-và-lập-trình-hướng-đối-tượng)
- [Quy tắc đặt tên trong C#](#quy-tắc-đặt-tên-trong-c)
- [Các kiểu dữ liệu cơ bản](#các-kiểu-dữ-liệu-cơ-bản)
- [Nhập, xuất và chuyển đổi kiểu dữ liệu](#nhập-xuất-và-chuyển-đổi-kiểu-dữ-liệu)
- [Toán tử trong C#](#toán-tử-trong-c)
- [Cấu trúc lệnh rẽ nhánh](#cấu-trúc-lệnh-rẽ-nhánh)


## Tổng quan về C# và lập trình hướng đối tượng
C# là một ngôn ngữ lập trình hướng đối tượng, nơi các chương trình được xây dựng từ các đối tượng tương tác với nhau thông qua các phương thức. Một chương trình C# bao gồm các phần chính sau:

- **Khai báo Namespace**: Sử dụng `using` để nhập các namespace có sẵn như `System`.
- **Định nghĩa Namespace**: Tổ chức mã nguồn và tránh xung đột tên.
- **Định nghĩa Class**: Lớp chứa phương thức `Main` để bắt đầu thực thi chương trình.
- **Phương thức của Class**: Các phương thức bổ sung có thể được gọi từ `Main` hoặc từ các phương thức khác trong lớp.
- **Phương thức Main**: Điểm bắt đầu thực thi chương trình.
- **Lệnh và biểu thức**: Các lệnh và biểu thức được viết trong các phương thức của lớp.
- **Comment**: Dùng để ghi chú mã.

*Lưu ý*: C# phân biệt chữ hoa và chữ thường, các lệnh kết thúc bằng dấu chấm phẩy `;`.

## Quy tắc đặt tên trong C#
1. **Camel Case**: Chữ cái đầu tiên viết thường, các từ tiếp theo viết hoa.
   - Dùng cho biến có phạm vi truy cập private hoặc protected và các tham số hàm.
   - Ví dụ: `educationFree`, `chiPhi`.
2. **Pascal Case**: Viết hoa chữ cái đầu của mỗi từ.
   - Dùng cho tên hàm, interface, enum, sự kiện.
   - Ví dụ: `CalculateInterest`, `EmployeeList`.

*Lưu ý*: Đặt tên biến ngắn gọn, dễ hiểu và tránh sử dụng ký tự đơn lẻ trừ khi dùng trong vòng lặp.

## Các kiểu dữ liệu cơ bản
Một số kiểu dữ liệu cơ bản trong C# bao gồm:
- **int**: Số nguyên có dấu, 32 bit.
- **sbyte, byte, short, ushort, long, ulong**: Các kiểu số nguyên có hoặc không dấu với kích thước và phạm vi khác nhau.
- **float, double, decimal**: Kiểu số thực dấu chấm động với kích thước khác nhau.
- **char**: Ký tự Unicode 16 bit.
- **bool**: Kiểu logic chỉ có giá trị true hoặc false.
- **string**: Chuỗi ký tự.
- **object**: Kiểu cơ sở, mọi đối tượng trong C# đều kế thừa từ kiểu này.

## Nhập, xuất và chuyển đổi kiểu dữ liệu
- **Xuất dữ liệu**:
  - `Console.WriteLine()`: In ra màn hình và xuống dòng.
  - `Console.Write()`: In ra màn hình nhưng không xuống dòng.
- **Nhập dữ liệu**:
  - `Console.ReadLine()`: Nhập dữ liệu và trả về chuỗi.
  - `Console.ReadKey()`: Trả về thông tin phím bấm.
- **Ép kiểu dữ liệu**:
  - **Chuyển đổi kiểu ngầm định**: Trình biên dịch tự động chuyển kiểu nếu miền giá trị cho phép.
  - **Chuyển đổi kiểu tường minh**: Dùng từ khóa để chuyển kiểu.
  - **Sử dụng phương thức, lớp hỗ trợ**: Dùng `Parse()`, `TryParse()`, hoặc lớp `Convert`.

## Toán tử trong C#
### Toán tử toán học
- `+`: Cộng hai toán hạng.
- `-`: Trừ hai toán hạng.
- `*`: Nhân hai toán hạng.
- `/`: Chia lấy phần nguyên (nếu là số nguyên).
- `%`: Chia lấy dư.
- `++`: Tăng giá trị toán hạng lên 1 đơn vị.
- `--`: Giảm giá trị toán hạng đi 1 đơn vị.

### Toán tử khởi tạo và gán
- `=`: Gán giá trị của toán hạng bên phải cho bên trái.
- `+=`, `-=`, `*=`, `/=`, `%=`: Gán kết quả biểu thức sau khi thực hiện phép toán.

### Toán tử quan hệ
- `==`: So sánh bằng nhau.
- `!=`: So sánh khác nhau.
- `>`, `<`, `>=`, `<=`: So sánh lớn hơn, nhỏ hơn, lớn hơn hoặc bằng, nhỏ hơn hoặc bằng.

### Các toán tử khác
- `sizeof()`: Trả về kích thước của kiểu dữ liệu.
- `typeof()`: Trả về kiểu dữ liệu của một lớp.
- `new`: Cấp phát vùng nhớ mới.
- `is`: Xác định kiểu của đối tượng.
- `as`: Ép kiểu không gây lỗi, trả về null nếu ép không thành công.
- `?:`: Toán tử ba ngôi, tương đương với cấu trúc điều kiện.

## Cấu trúc lệnh rẽ nhánh
### If-else
- **Dạng thiếu**:
  ```csharp
  if (biểu thức điều kiện) 
      câu lệnh thực hiện;
- **Dạng đủ**:
  ```csharp
  if (biểu thức điều kiện)
    câu lệnh thực hiện 1;
  else
    câu lệnh thực hiện 2;
### Switch-case
- **Dạng thiếu**:
  ```csharp
  switch (biểu thức)
  {
    case giá trị 1:
        câu lệnh 1;
        break;
    case giá trị 2:
        câu lệnh 2;
        break;
  }
- **Dạng đủ**:
  ```csharp
  switch (biểu thức)
  {
    case giá trị 1:
        câu lệnh 1;
        break;
    case giá trị 2:
        câu lệnh 2;
        break;
    default:
        câu lệnh mặc định;
        break;
  }

