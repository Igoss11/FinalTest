## Выбор специализации. Контрольная работа.

**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись именно массивами.

**Алгоритм выполнения:**
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл Readme.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах).

**Решение:**
1. Рисуем блок-схему в draw.io.
2. Задаем массив на вход с данными и массив на выход.
3. Объявляем метод, в котором проверяется длина элементов массива. Задаем цикл проверки <=3.
4. Если длина элементов массива совпадает, то элемент первого массива заносится в переменную count во втором массиве.
5. Переменная count во втором массиве увеличивается на 1 и возвращается к циклу for.
6. Выводим массив на выход.