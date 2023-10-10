int N = Int32.Parse(Console.ReadLine());
int M = Int32.Parse(Console.ReadLine());
int K = Int32.Parse(Console.ReadLine());
int[] arr = new int[N];

for(int i=0; i<N; i++) {
    arr[i] = Int32.Parse(Console.ReadLine());
}

Array.Resize(ref arr, N+M);

for(int i=0; i<=N-K; i++) {
    arr[N+M-i-1] = arr[N-i-1];
}

for(int i=0; i<M; i++) {
    int value = Int32.Parse(Console.ReadLine());
    arr[K+i-1] = value;
}

for(int i=0; i<arr.Length; i++){
    Console.Write(Convert.ToString(arr[i]) + ' ');
}