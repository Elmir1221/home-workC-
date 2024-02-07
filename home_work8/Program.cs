//Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.


int n = 5;
int m = 15;
int Count = 0;

for(int i = n; i <= m; i++)
{
    if(i%2 == 0)
    {
        Count++;
    
    }

}
Console.WriteLine(Count);