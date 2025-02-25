
## Задачи
1. Даны два целых знаковых четырехбайтовых числа и две позиции битов i и j (i<=j). Реализовать алгоритм InsertNumber вставки первых (j - i + 1) битов второго числа в первое так, чтобы биты второго числа занимали позиции с бита i по бит j (биты нумеруются справа налево). Разработать модульные тесты (NUnit и MS Unit Test - ([DDT](https://msdn.microsoft.com/en-us/library/ms182527.aspx)))) для тестирования метода. **(deadline - 23.03.2019, 24.00)** 
2. Реализовать *рекурсивный* алгоритм поиска максимального элемента в неотсортированном целочисленом массиве. Разработать модульные тесты NUnit для тестирования метода. **(deadline - 22.03.2019, 24.00)** 
3. Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null. Разработать модульные тесты NUnit. (**Padawans Task #11**) **(deadline - 23.03.2019, 24.00)** 
4. Реализовать метод FilterArrayByKey который принимает массив целых чисел и фильтрует его таким образом, чтобы на выходе остались только числа, содержащие заданную цифру (LINQ-запросы не использовать!) Например, для цифры 7, метод FilterArrayByKey для набора {7,1,2,3,4,5,6,7,68,69,70,15,17} возвращает набор {7,7,70,17}. Разработать модульные тесты NUnit и MS Unit Test для тестирования метода. **(deadline - 24.03.2019, 18.00)** 

## Реализация (Done)
1. - [Решение](https://github.com/arinkarus/NET1.S.2019.Chemrukova.02/blob/master/BitOperations/BitsManipulation.cs) 
   - [MS Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.02/blob/master/BitOperations.Tests.MS/BitsManipulationTests.cs)
   - [NUnit Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.02/blob/master/BitOperations.Tests.NUnit/BitsManipulationTests.cs)
2. - [Решение](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts/ArrayExtension.cs)
   - [NUnit Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts.Tests.NUnit/ArrayExtensionTests.cs)
3. - [Решение](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts/ArrayExtension.cs)
   - [NUnit Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts.Tests.NUnit/ArrayExtensionTests.cs)
4. - [Решение](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts/ArrayExtension.cs)
   - [NUnit Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts.Tests.NUnit/ArrayExtensionTests.cs)
   - [MS Tests](https://github.com/arinkarus/NET1.S.2019.Chemrukova.01/blob/master/Sorts.Tests.MS/ArrayExtensionTests.cs)
