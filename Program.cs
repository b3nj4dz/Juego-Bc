Console.WriteLine("Hello, World!");
Console.Write("Hola Mundo"); 
Console.Write("Hola Mundo 2");
// comentario
/* bloque de comentario */
Console.WriteLine();
Console.WriteLine("Ingrese nombre: ");
string? nombre=Console.ReadLine();
Console.WriteLine("Su nombre es: "+nombre);
int edad=21, peso=100;
float estatura=1.80f;
double promedio=7.0;
bool estaVivo=true;
char letra='1';
Console.WriteLine("Ingrese edad: ");
edad=int.Parse(Console.ReadLine()!);
Console.WriteLine("El próximo año tendrá: "+(edad+1));
int a=23;
double b=a;
double aa=2.3;
int bb=(int)aa;
string h=aa.ToString("f3"); //convertir en string
Console.WriteLine("h="+h);
bool estarVivo=int.TryParse("30",out int zz);
Console.WriteLine(estarVivo);
Console.WriteLine("zz="+(zz+1)); // +, -, /, *, %
edad=edad+1;
edad+=1;
edad++;