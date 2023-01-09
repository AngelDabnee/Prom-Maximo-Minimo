// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Mediante un ciclo pedir al usuario que " +
    "capture 15 números, " +
    "calcular el promedio, máximo " +
    "y mínimo. Imprimir resultados.");
//DE
double[] numeros = new double[15];
double promedio = 0;
double minimo = 0;
double maximo = 0;
double suma = 0;
//Procedimiento pedir al usuario que capture lo 15 números
Console.WriteLine("Vamos a capturar 15 números");
for (int i = 0; i < numeros.Length; i++)//Ciclo para pedir los 15 numeros
{
    Console.WriteLine("Captura tu número No. " + (i+1));//Ciclo para pedir
    numeros[i] = double.Parse(Console.ReadLine());
    suma = suma + numeros[i];
    promedio = suma / numeros.Length;//Aquí promediamos los números dados. 
}
//Comenzaremos con los dos ordenamientos para el número mínimo y máximo capturado por el usuario mediante un for
for (int k = 0; k < numeros.Length; k++)
{
    for (int j = 0; j < numeros.Length-1; j++)
    {
        if (numeros[j] > numeros[j + 1]) //Haremos el ordenamiento colocando el menor el la posición 0(que sería 1)
        {
            double temp = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = temp;
        }
    }
    minimo = numeros[0];//Aquí guardamos el primer numero mínimo en la variable minimo
    maximo = numeros[14];//Son 14 posiciones, por lo cual la ultima posición sería el máximo debido a como colocamos el arreglo
}
Console.WriteLine($"El promedio de los números que capturaste es {promedio}");
Console.WriteLine($"El menor de los números capturados es {minimo}");
Console.WriteLine($"El mayor número que capturaste es {maximo}");