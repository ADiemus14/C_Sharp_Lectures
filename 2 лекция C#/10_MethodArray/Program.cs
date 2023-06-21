/* Допустим, у нас есть массив array, в котором n элементов.
 Найдём элемент,
  совпадающий с некоторым значением, который определяет пользователей.*/



int [] array = {1, 12, 31, 4, 15, 18, 17, 18 };

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
         break;
    }

    index++;
}
