int row = 1000;
int col = 1000;
int[] matrixA = new int[col*row];
int[] matrixB = new int[col*row];
int[] resMatrix = new int[col*row];
Random random = new Random();

for(int i=0; i<col*row; i++) {
    matrixA[i] = random.Next(1, 11);
    matrixB[i] = random.Next(1, 11);
}

for(int i=0; i<row; i++){
    for(int j=0; j<col; j++){
        int sum = 0;
        for(int k=0; k<col; k++) {
            sum += matrixA[i*col+k] * matrixB[k*col+j];
        }
        resMatrix[i*col+j] = sum;
    }
}

for(int i=0; i<resMatrix.Length; i++){
    Console.Write(Convert.ToString(resMatrix[i]) + ' ');
}