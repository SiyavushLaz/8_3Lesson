using System;

class Program {
    static void Main(string[] args) {
        int[,] arr = {{5, 3, 8}, {9, 1, 4}, {6, 2, 7}}; // исходный массив

        // перебираем каждую строку массива
        for (int i = 0; i < arr.GetLength(0); i++) {
            // сортируем элементы текущей строки по убыванию
            for (int j = 0; j < arr.GetLength(1); j++) {
                for (int k = j + 1; k < arr.GetLength(1); k++) {
                    if (arr[i, k] > arr[i, j]) {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }

        // выводим отсортированный массив
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++) {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

