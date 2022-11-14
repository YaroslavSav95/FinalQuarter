Console.Write("Сколько элементов в массиве? ");
int N = int.Parse(Console.ReadLine());
string[]arrayOne=new string[N];
string[]arrayTwo=new string[arrayOne.Length];
Enter(arrayOne);
ChangeArray(arrayOne,arrayTwo);
Print(arrayTwo);
void ChangeArray(string[]arrayOne,string[]arrayTwo)
{
    int count=0;
    for(int i=0;i<arrayOne.Length;i++)
    {
        if(arrayOne[i].Length<=3)
        {
            arrayTwo[count]=arrayOne[i];
            count++;
        }
    }
}
void Print(string[]array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void Enter(string[]arrayOne)
{
    for (int i=0;i<arrayOne.Length;i++)
    {
        Console.Write("Заполните массив. ");
        arrayOne[i]= Console.ReadLine();
    }
}