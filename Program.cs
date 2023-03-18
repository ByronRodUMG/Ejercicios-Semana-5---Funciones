//1. Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.
double calcArea (double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}

//2. Crear una función que calcule el perímetro de un rectángulo, recibiendo como parámetros el ancho y la altura.
float calcPerimetro (float ancho, float altura)
{
    float perimetro = (ancho + altura) * 2;
    return perimetro;
}

//3. Crear una función que calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros.
float calcPromedio (List<int> numeros)
{
    float suma = 0;
    if (numeros.Count > 0)
    {
        foreach (int num in numeros)
        {
            suma += num;
        }
    }
    float promedio = suma / numeros.Count;
    return promedio;
}

//4. Crear una función que determine si un número es par o impar, recibiendo como parámetro el número.
string esPar (int numero)
{
    if (numero % 2 == 0)
    {
        return "par";
    }
    else
    {
        return "impar";
    }
}

//5.Crear una función que convierta una cadena a mayúsculas, recibiendo como parámetro la cadena.
string convMayus (string cadena)
{
    string mayusculas = cadena.ToUpper();
    return mayusculas;
}

/*6. Crear una función que calcule la distancia entre dos puntos en un plano cartesiano,
recibiendo como parámetros las coordenadas x e y de ambos puntos.*/
double calcDistancia (double x1, double y1, double x2, double y2)
{
    double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return distancia;
}

//7. Crear una función que calcule la suma de los primeros n números naturales, recibiendo como parámetro el número n.
int calcSumaNaturales (int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}

//8. Crear una función que calcule el factorial de un número, recibiendo como parámetro el número.
int calcFactorial (int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}

double radio = 10.0;
double area = calcArea(radio);
Console.WriteLine($"El área de un círculo con un radio de {radio} es {area}");

float ancho = 10, altura = 5;
float perimetro = calcPerimetro(ancho, altura);
Console.WriteLine($"El perímetro del rectángulo es {perimetro}");

List<int> numeros = new() { 55, 44, 66, 99, 33 };
float promedio = calcPromedio(numeros);
Console.WriteLine($"El promedio es {promedio}");

int numero = 11;
string parImpar = esPar(numero);
Console.WriteLine($"El número {numero} es {parImpar}.");

string cadena = "Esto está dificil.";
string mayusculas = convMayus(cadena);
Console.WriteLine($"La cadena en mayúsculas es: {mayusculas}");

double distancia = calcDistancia(5, 5, 6, -2);
Console.WriteLine($"La distancia entre los puntos es: {distancia}");

int num1 = 10;
int suma = calcSumaNaturales(num1);
Console.WriteLine($"La suma de los primeros {num1} números naturales es: {suma}");

int num2 = 6;
int factorial = calcFactorial(num2);
Console.WriteLine($"El factorial de {num2} es: {factorial}");
