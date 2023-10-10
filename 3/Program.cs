int size = Int32.Parse(Console.ReadLine());

int[] arr_1 = InitArr(size);
int[] arr_2 = InitArr(size);

Console.WriteLine("Массив 1: ");
PrintArray(arr_1);
Console.WriteLine("\nМассив 2: ");
PrintArray(arr_2);

if(arr_1.Length != arr_2.Length) {
    Console.WriteLine("\nМассивы разной длины");
}
else{
    int[] sum = SumArrs(arr_1, arr_2);
    Console.WriteLine("\nСумма массивов: ");
    PrintArray(sum);
}

Console.WriteLine("\n");
int multiplyer = Int32.Parse(Console.ReadLine());
Console.WriteLine($"\nМассив умноженный на {multiplyer}: ");
int[] multiplyedArr = MultiplyArr(arr_1, multiplyer);
PrintArray(multiplyedArr);

Console.WriteLine("\nОбищие значение в двух массивах: ");
FindMatchingValue(arr_1, arr_2);

Console.WriteLine("\nМассив, отсортированный по убыванию: ");
SortArray(arr_1);
PrintArray(arr_1);

int max = FindMaxValue(arr_1);
int min = FindMinValue(arr_1);
double average = FindAverage(arr_1);
Console.WriteLine($"\nМаксимальное значение: {max}");
Console.WriteLine($"\nМинимальное значение: {min}");
Console.WriteLine($"\nСреднее значение: {average}");

static int[] InitArr(int size) {
    Random random = new Random();
    int[] arr = new int[size];
    for(int i=0; i<size; i++) {
        arr[i] = random.Next(1, 101);
    }
    return arr;
}

static int[] SumArrs(int[] arr_1, int[] arr_2) {
    int[] res = new int[arr_1.Length];
    for(int i=0; i<arr_1.Length; i++) {
        res[i] = arr_1[i] + arr_2[i];
    }
    return res;
}

static int[] MultiplyArr(int[] arr, int multiplyer) {
    int[] res = new int[arr.Length];
    for(int i=0; i<arr.Length; i++){
        res[i] = arr[i] * multiplyer;
    }
    return res;
}

static void FindMatchingValue(int[] arr_1, int[] arr_2) {
    foreach(int value_1 in arr_1) {
        foreach(int value_2 in arr_2) {
            if(value_1==value_2) {
                Console.WriteLine(value_1);
                break;
            }
        }
    }
}

static void PrintArray(int[] arr) {
    foreach(int value in arr){
        Console.Write(Convert.ToString(value) + ' ');
    }
}

static void SortArray(int[] arr) {
    for(int i=0; i<arr.Length-1; i++) {
        for(int j=i+1; j<arr.Length; j++) {
            if(arr[i] < arr[j]) 
                (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}

static int FindMinValue(int[] arr) {
    int min = arr[0];
    foreach(int value in arr) {
        if(value<min) 
            min = value;
    }
    return min;
}

static int FindMaxValue(int[] arr) {
    int max = arr[0];
    foreach(int value in arr) {
        if(value>max)
            max = value;
    }
    return max;
}

static double FindAverage(int[] arr) {
    int sum = 0;
    foreach(int value in arr) {
        sum += value;
    }
    return (double)sum / arr.Length;
}