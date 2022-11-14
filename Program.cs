string[]arrayOne=new string[5]{"array","5","ten","11","rock-n-roll"};
string[]arrayTwo=new string[arrayOne.Length];
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