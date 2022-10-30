// 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно 

int[,,] Array = new int[3,3,3]; // Объявление массива размером 3х3х3
void fillArray(int[,,] array)
{
    int num1 = 10;
    int num2 = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
         for (int k = 0; k < array.GetLength(2); k++)
            {   if (num1 >= 99 && num2<-9)
                {  
                   array[i, j, k] = num2++;
                }
                if (num1>=10 && num1<100)
                {
                    array[i, j, k] = num1++;
                }
                
            }
        

}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) "); // вывод элементов массива и вывод их позиций
                
            }
            Console.WriteLine();
        }
        
    }
}


fillArray(Array);
printArray(Array);
