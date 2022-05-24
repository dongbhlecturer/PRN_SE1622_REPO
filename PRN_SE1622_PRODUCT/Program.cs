/*
 Lap trinh quan ly Product(Id, ProductName, UnitPrice)
    - Them nhieu Product tu chuong trinh
    - Xoa 1 product bat ky
    - lay ra 1 product theo chi so bat ky
    - Hien thi toan bo product ra man hinh
 */

using static System.Console;

using Prn.Se1622;
Product p1 = new Product(1,"Macbook Pro 12",2500d);
Product p2 = new Product(2, "Macbook Pro 13", 200d);
Product p3 = new Product(3, "Macbook Pro 14", 5500d);
Product p4 = new Product(4, "Macbook Pro 15", 8500d);
Product p5 = new Product(5, "Macbook Pro 16", 2900d);
Product p6 = new Product(6, "Macbook Pro 17", 200d);




ProductManager productManager = new ProductManager();

productManager.Add(p1);
productManager.Add(p2);
productManager.Add(p3);
productManager.Add(p4);
productManager.Add(p5);
productManager.Add(p6);



productManager.Display();

ReadLine();
