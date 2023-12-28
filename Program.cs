
/*1. 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. While loop dan foydalaning!*/

/*int i=1,sum=0;
while(i<1000)
{
  if(i%2==1)
  {
    sum+=i;
  }
  i++;
}
System.Console.WriteLine($"sum = {sum}");*/

/*2. Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!*/

//array massivi static tarzda e'lon qilindi.
/*int[] array={3,2,7,4,1};
int max=array[0],min=array[0];

for(int i=1;i<array.Length;i++)
{
  if(array[i]>max)
  {
    max=array[i];
  }
  if(array[i]<min)
  {
    min=array[i];
  }
}
System.Console.WriteLine($"{max} * {min} = {max*min}");*/

/* 3.Consolga int tipidagi butun son kiritilgan => int x
x! (x factorial) ni hisoblaydigan dastur tuzing.*/

int x;
System.Console.Write("x=");
x=int.Parse(Console.ReadLine());

//1-usul
/*int i=1,p=1;
while(i<=x)
{
  p*=i;
  i++;
}
System.Console.WriteLine($"{x} factorial = {p} ga teng");*/

//2-usul
int p=1;
for(int i=1;i<=x;i++)
{
  p*=i;
}
System.Console.WriteLine($"{x} factorial = {p} ga teng");