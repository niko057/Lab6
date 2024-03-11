
//Task1.


//int a = 5;

//for (int i = 1; i <= a; i++)
//{

//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}

//Task2. Write c# program to print all unique element in an array

//int[] arr = { 1, 2, 3, 3, 4, 5, 6, 6, 7 };

//int n = arr.Length;

//Console.WriteLine("Unikal ededler bunlardi: ");

//for (int i = 0; i < n; i++)
//{
//    bool copy = false;
//    for (int j = 0; j < i; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            copy = true;
//            break;
//        }
//    }

//    if (!copy)
//    {
//        Console.WriteLine(arr[i]);

//    }
//}

//Task3. Write c# program to copy all elements of one array to another
//int[] arr1 = {1,2,3,4,5,5,6};
//int[] arr2 = arr1;
//foreach (int item in arr2)
//{
//    Console.WriteLine(item);
//}


//Task4. Write c# program to count number of each element in an array

//int[] arr = { 1, 2, 3, 4, 5, 6, 8, 4 };

//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{

//    count++;

//}
//Console.WriteLine("Massivdeki elementin sayi:" + count);


//int[] arr = { 1, 2, 3, 3, 4, 5, 6, 6, 7,7,10 };

//int n = arr.Length;
//int count = 0;

//Console.WriteLine("Masivdeki elementin sayi: ");

//for (int i = 0; i < n; i++)
//{
   
//    bool copy = false;
//    for (int j = 0; j < i; j++)
//    {
       
//        if (arr[i] == arr[j])
//        {
//            copy = true;
//            break;
//        }
        

//    }

//    if (!copy)
//    {

//        count++;

//    }
   
//}
//Console.WriteLine(count);