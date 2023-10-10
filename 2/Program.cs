int N = Int32.Parse(Console.ReadLine());
int[] arr = new int[N];

for(int i=0; i<N; i++) {
    arr[i] = Int32.Parse(Console.ReadLine());
}

for(int i=0; i<N/2; i++) {
    (arr[i], arr[N/2+N%2+i]) = (arr[N/2+N%2+i], arr[i]);
}

for(int i=0; i<arr.Length; i++){
    Console.Write(Convert.ToString(arr[i]) + ' ');
}