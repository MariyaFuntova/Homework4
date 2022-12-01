int [] GetRandomArray (int length)
{
    int [] array = new int [length];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number.Next(0,999);
    }
    return array;
}    
    
void printArray ( int [] array)
{
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if ( i < array.Length - 1)
            {
                Console.Write(" , ");
            }            
        }
        Console.Write("]");
}
int [] array = GetRandomArray(8);
printArray(array);

  
        
    
