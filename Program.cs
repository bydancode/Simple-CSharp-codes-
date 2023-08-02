// Revertir un string 

string cadena = "revertir";

string cadenaRevertida = "";

for (int i = cadena.Length - 1; i >= 0; i--)
{
    cadenaRevertida += cadena[i];
}

Console.WriteLine(cadenaRevertida);


// Revertir de otra manera 
string cadena1 = "revertir";

char[] cadenaRevertida1 = new char[cadena1.Length];
int index = 0;

for (int i = cadena1.Length - 1; i >= 0; i--)
{
    cadenaRevertida1[index] = cadena1[i];
    index++;
}

Console.WriteLine(new string(cadenaRevertida1));


// Revertir de otra la forma usual
char[] stringArray = cadena.ToCharArray();
Array.Reverse(stringArray);
Console.WriteLine(new string(stringArray));



// Problema 1: Suma de Números
// Escribe una función que tome un número entero como entrada 
// y devuelva la suma de todos los números enteros positivos desde 1 hasta ese número.

static int FuncionSuma(int numero)
{
    int sumaHastaNumero = 0;
    for (int i = 1; i <= numero; i++)
    {
        sumaHastaNumero += i;
    }
    return sumaHastaNumero;
}

Console.WriteLine(FuncionSuma(50));



// Problema 2: Factorial
// Escribe una función que tome un número entero como entrada y
//  devuelva el factorial de ese número. El factorial de un número N es el producto de todos los enteros positivos desde 1 hasta N.

static int Factorial(int numero)
{
    int factorial = 1;
    for (int i = 1; i <= numero; i++)
    {
        factorial *= i;
    }
    return factorial;
}

Console.WriteLine(Factorial(4));



// Remover los duplicados en una dacena de texto 

var text = "This is a string and nothing more than a string";

string newText = string.Empty;

for (int i = 0; i < text.Length - 1; i++)
{
    if (!newText.Contains(text[i]))
    {
        newText += text[i];
    }
}

Console.WriteLine(newText);



//Remover los duplicados en un array 

int[] numeros = new int[] { 1, 2, 3, 4, 5, 3, 4, 1 };

int[] numerosSinDuplicado = new int[numeros.Length];
int indexx = 0;

for (int i = 0; i < numeros.Length; i++)
{
    bool duplicado = false;

    for (int j = 0; j < index; j++)
    {
        if (numeros[i] == numerosSinDuplicado[j])
        {
            duplicado = true;
            break;
        }
    }

    if (!duplicado)
    {
        numerosSinDuplicado[indexx] = numeros[i];
        indexx++;
    }
}

Array.Resize(ref numerosSinDuplicado, indexx);

string arregloComoCadena = string.Join(", ", numerosSinDuplicado);

Console.WriteLine(arregloComoCadena);



// Contar cuantas veces se repite un caracter en un string 

var stringCaracteres = "This is a string and nothing more than a string";

Dictionary<char, int> characterCount = new Dictionary<char, int>();

foreach (var character in stringCaracteres)
{
    if (character != ' ')
    {
        if (!characterCount.ContainsKey(character))
        {
            characterCount.Add(character, 1);
        }
        else
        {
            characterCount[character]++;
        }
    }
}

foreach (var caracter in characterCount.OrderBy(x => x.Key))
{
    Console.WriteLine($"{caracter.Key} - {caracter.Value}");
}




// Resta de las diagonales de una matriz 

static int diagonalDifference(List<List<int>> arr)
{
    int n = arr.Count;
    int primarySum = 0;
    int secondarySum = 0;

    for (int i = 0; i < n; i++)
    {
        primarySum += arr[i][i];
        secondarySum += arr[i][n - 1 - i];
    }

    // Calcular la diferencia absoluta entre las sumas de las diagonales
    int difference = Math.Abs(primarySum - secondarySum);

    return difference;
}

List<List<int>> matriz = new List<List<int>>
{
    new List<int> { 11, 2, 4 },
    new List<int> { 4, 5, 6 },
    new List<int> { 10, 8, -12 }
};

int diferenciaAbsoluta = diagonalDifference(matriz);
Console.WriteLine(diferenciaAbsoluta); // Salida: 15




// Dada una matriz de enteros, calcula los cocientes de sus elementos que son positivos, negativos y cero.

static void plusMinus(List<int> arr)
{
    float tamano = arr.Count;
    float positivo = 0f;
    float negativo = 0f;
    float cero = 0f;

    for (int i = 0; i < tamano; i++)
    {
        if (arr[i] < 0)
        {
            negativo++;
        }
        else if (arr[i] > 0)
        {
            positivo++;
        }
        else
        {
            cero++;
        }
    }

    positivo /= tamano;
    negativo /= tamano;
    cero /= tamano;

    Console.WriteLine(positivo);
    Console.WriteLine(negativo);
    Console.WriteLine(cero);

}

List<int> listaNums = new List<int> { -4, 3, -9, 0, 4, 1 };
plusMinus(listaNums);



