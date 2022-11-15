# Описание проекта "Приложение Калькулятор"
Данный проект, написан на языке с# с использованием Windows Forms, предоставляет стандартные функции калькулятора, такие как: сложение, деление, умножение и вычитание(при необходимости функции можно дополнять).

![image](https://user-images.githubusercontent.com/109080032/202016398-ab30689b-e4ea-475a-93b7-00abf0867710.png)
# Классы и методы
Данный проект содержит данные классы:
+ Calculation 
+ FormCalculator
+ CalculationsTests 

 Рассмотрим каждый класс подробней.
 
    В классе "Calculation", размещены основные методы, которые отвечают за обработку знаков и операндов операций. Так же, в этом классе располагаются методы, которые отвечают за арифметические операции.
    В классе "FormCalculator", располагаются методы, необходимые для работы с Windows Forms.
    В классе "CalculationsTests", располагаются методы, необходимые для тестирования программы.
    
 # Демонстрация работы приложения
https://user-images.githubusercontent.com/109080032/202012331-db0bcb99-67b4-4ecb-a050-5c35654ef36c.mp4
Как мы видим на данном видео, все функции работают исправно и выполнены по тз.

## Инструкция по работе с приложением

Для выполнения арифметических операций необходимо :
+ Выбрать первое число;
+ Далее, выбрать необходимую кнопку арифметического действия(+, - , * , ÷);
+ Затем, выбираем второе число;
+ Для вывода результата - нажать кнопку (=);

Для того, чтобы очистить результат или неправильно выбранное число, необходимо восспользоваться конопкой (C).
+ Для смены знака числа на противоположный,наобходимо нажать кнопку (+/-);
    
# Тестирование программы
В данном проекте реализованы 6 метовов тестирования.
Пример метода по тестированию:
```
[Fact]
        public void TestSubtractResultMinusFour()
        {
            Calculation calculation = new();
            string result = calculation.ProcessStatement("", "4-5");
            Assert.Equal("-1", result);
        }
```
Данный метод проверяют работоспособность вычитания чисел.
Остальные методы тестирования сделаны по аналогии.

Для того, чтобы проверить исправность всех тестов, необходимо:
 1) перейти на вкладку "Тест" на панели инструментов. 
 2) Далее выбираем "Запуск всех тестов"
![image](https://user-images.githubusercontent.com/109080032/202014086-fc235fcc-8383-4054-a131-8b8f96d1d2cc.png)


После запуска всех тестов, мы можем увидеть, что все тесты выполнены успешно.
![image](https://user-images.githubusercontent.com/109080032/202016331-b4568020-dd84-477d-9acc-0f038cfbc63a.png)

