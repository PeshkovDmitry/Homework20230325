// Задача 41. Пользователь вводит с клавиатуры М чисел.
// Подсчитайте, сколько чисел больше 0 ввел пользователь

int[] InputArray() {
    int [] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); 
    return array;
} 

void ReleaseArray(int[] a) {
    int count = 0;
    foreach (int x in a) {
        if (x > 0) count++;
    }
    Console.WriteLine($"->{count}"); 
}

Console.Clear(); 
int[] array = InputArray();
ReleaseArray(array);