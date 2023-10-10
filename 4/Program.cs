int n = Int32.Parse(Console.ReadLine());
int m = Int32.Parse(Console.ReadLine());
int res = 0;
int[,] arr = new int[n, m];

for(int i=0; i<n; i++) {
    for(int j=0; j<m; j++)
        arr[i, j] = Int32.Parse(Console.ReadLine());
}

int k = Int32.Parse(Console.ReadLine());

if(k>m || k<0) Console.WriteLine(0);
else {
    for(int i=0; i<n; i++) {
        int c = 0;
        for(int j=0; j<m; j++){
            if(c==k) break;
            if(arr[i,j]==0) c++;
            else if(arr[i,j]==1) c=0;
        }
        if(c>=k) {
            res = i+1;
            break;
        }
    }
}

if(res == 0) Console.WriteLine(0);
else Console.WriteLine(res);