using JP_MT_16;





/*classes*/

Person Person1 = new Person(15) { Name="John", };

Person1.TellMeYourId();


Console.WriteLine($"are you adult?  {Person1.IsAdult()}");

Person Person2 = new Person(20) { };

Person2.TellMeYourId();
Person2.Name = "Anna";

Console.WriteLine($"are you adult?  {Person2.IsAdult()}");




Console.WriteLine(Person2.Name);


Console.WriteLine("=====================================");


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int? age = 15;

int[] array = new int[4];

Console.WriteLine(array.Length);// გვიჩვენებს მასივის სიგრძეს
Console.WriteLine(array.Rank);// გვიჩვენებს განზომილებსი სიგრძეს

/*კონსოლიდან ინოფრმაციის შეტანა მასივში*/
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
/*დაბეჭდვა*/
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
foreach (int value in array)
{
    Console.Write($"{value} ");
}


/*matrix*/


int[,] matrix = new int[5, 10];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    matrix[i, i] = 1;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

//დაკბიული მასივი
int[][] jaggedArray = new int[4][];

// Set the values of the first array in the jagged array structure.
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

jaggedArray[1] = new int[8] { 1, 2, 3, 4,5,6,7,8 };

jaggedArray[2] = new int[9] { 1, 2,3, 4,5,6,7,8 ,9};
jaggedArray[3] = new int[3] { 1, 2,1 };
/*
დაბეჭდვა*/
foreach (var i in jaggedArray)
{
    foreach (var item in i)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}



//== | === '1'==1 =>true '1'=== 1  => false    ||  &&

// georgia tbilisi +4

/*foreach (int i in array)
{
    Console.WriteLine(i);
}*/

/*switch*/





/*if (age <0)
{
    Console.WriteLine("this number is negative");
}else if (age >0 ) {
    Console.WriteLine("this number is positive");
}else if (age >10) {
    Console.WriteLine("this number is more than 10");
}*/

Console.WriteLine("please input number:");
var input = Console.ReadLine();

// + - * / %


try
{
    int value = int.Parse(input);

    Console.WriteLine(value);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{

}

/*for (int i = 0; i < 50; i++)
{
var random= new Random().Next(15);

    Console.WriteLine(random);
        *//*switch (random)
        {
        case 1: Console.WriteLine("this number is 1");
        break;
        case 2: Console.WriteLine("this number is 1");
        break ;
        case 3:    Console.WriteLine("this number is 3");
        break;
        default: Console.WriteLine("value is not found");
        break;
        }*//*
}
*/




/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}");

    for(int j = 0; j < 5; j++)
    {
        Console.Write($" {j} ");
    }
    Console.WriteLine();
}*/

//methods


void PringArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}


int CompareTwoNumber(int num1, int num2)
{
    if (num1 > num2)
        return num1;
    else
        return num2;

}


