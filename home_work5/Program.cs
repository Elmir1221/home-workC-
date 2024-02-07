//Verilmish arrayin icindeki cut ededlerin sayini tapin.


int[] nums = { 1, 2, 3, 4, 5, 6 };
int Count = 0;

for (int i=0; i<= nums.Length; i++)
{
    if (i % 2 == 0) 
    {
        Count+=i ;
    
    
    }
        
    

}
Console.WriteLine(Count);