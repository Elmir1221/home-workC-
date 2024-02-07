using System.Reflection;
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


int n = 1;
int m = 13;
int Sum = 0;

for(int i=1; i<=13; i++)
{

    if(i%2==1)
    {

        Sum += i;


    }
}


Console.WriteLine(Sum);
