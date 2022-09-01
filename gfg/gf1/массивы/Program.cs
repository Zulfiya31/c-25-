int[] array = {1,2,5,7,19,6,1,33};
void PrintArray(int[]array)
{
    int count = array.Length;
    for ( int i=0; i<count; i++){
        Console.Write(array[i]+ ",");
    }
    Console.WriteLine();
}
PrintArray(array);
// ВВеденные 8 чисел