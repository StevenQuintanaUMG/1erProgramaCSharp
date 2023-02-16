byte edad, num1, num2;
long n1, n2, sum, res, prod;

//Ejercicio1

Console.WriteLine($"Cual es tu edad?");
edad = Convert.ToByte(Console.ReadLine());

Console.WriteLine($"No aparentas tener " + edad + " años de edad");

//Ejercicio2

Console.WriteLine($"Digite 2 numeros de dos cifras: ");

num1 = Convert.ToByte(Console.ReadLine());
num2 = Convert.ToByte(Console.ReadLine());

ushort resultado = Convert.ToUInt16(num1 * num2);

Console.WriteLine($"El resultado de la multiplicacion es: " + resultado);

//Ejercicio3

Console.WriteLine("Escriba dos numeros enteros largos: ");
n1 = Convert.ToInt64(Console.ReadLine());
n2 = Convert.ToInt64(Console.ReadLine());

sum = n1 + n2;
res = n1 - n2;
prod = n1 * n2;

Console.WriteLine("La suma de los numeros es: " + sum);
Console.WriteLine("La resta de los numeros es: " + res);
Console.WriteLine("El producto de los numeros es: " + prod);

//comentario para git