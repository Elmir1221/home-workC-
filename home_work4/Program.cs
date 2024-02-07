//Verilmish arrayin icindeki tek ededlerin cemini tapin.


int[] nums = {1,2,3,4,5,6 };
int Count = 0;
for (int i = 0; i <= nums.Length; i++)
{

    if (i % 2 == 1)
    {

        Count += i;

    }
        
     

}

Console.WriteLine(Count);


