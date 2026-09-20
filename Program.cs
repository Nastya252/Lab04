int age = 20;
if (age >= 21) {
    Console.WriteLine("Доступ разрешён");
}
Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18){
    Console.WriteLine("Доступ разрешён");
} else {
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия {18 - age}");
}

int age = 14;
if (age < 13) {
    Console.WriteLine("Ребёнок");
} else if (age < 18) {
    Console.WriteLine("Подросток");
} else if (age < 60 && age > 18) {
    Console.WriteLine("Взрослый");
} else {
    Console.WriteLine("Пенсионер");
}

int age = 16;
double height = 1.55;
bool adult = true;
if ((age >= 14 && height >= 1.5) || adult) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}

/*
Задача В. Программа считывает три числа 
и выводит наибольшее из них.
*/
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a<b) {
    max = b;
}
if (c > max) {
    max = c;
}
Console.WriteLine("Наибольшее число: " + max);


/*
Задача Г. Программа считывает год и определяет, 
является ли он високосным
(год високосный, если делится на 4, 
но не делится на 100 — либо если делится на 400)
*/
Console.Write("Введите год ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
    Console.WriteLine("Год високосный");
} else {
    Console.WriteLine("Год не високосный");
}


// /*
// Вариант 3. Время года по номеру месяца
// Вход: номер месяца (1–12).
// Выход: вывести название сезона: зима (12, 1, 2), весна (3–5), лето (6–8), осень (9–
// 11). Если число вне диапазона — «Неверный месяц».
// Подсказка:используйте switch или if–else if.
// */
Console.Write("Введите номер месяца ");
int month = int.Parse(Console.ReadLine());
if (month == 12 || month == 1 || month == 2) {
    Console.WriteLine("Зима");
}
if (month == 3 || month == 4 || month == 5) {
    Console.WriteLine("Весна");
}
if (month == 6 || month == 7 || month == 8) {
    Console.WriteLine("Лето");
}
if (month == 9 || month == 10 || month == 11) {
    Console.WriteLine("Осень");
}

// /*
// Вариант 6. Оценка по баллам
// Вход: количество баллов (0–100).
// Выход: 90–100 — «Отлично», 75–89 — «Хорошо», 60–74 —
// «Удовлетворительно», меньше 60 — «Неудовлетворительно». Если больше 100 
// или меньше 0 — «Неверное значение».
// Подсказка:цепочка else if.
// */
Console.Write("Введите количество баллов ");
int grade = int.Parse(Console.ReadLine());
if (100>=grade && grade>=90){
    Console.WriteLine("Отлично");
}
else if (89>=grade && grade>=75){
    Console.WriteLine("Хорошо");
}
else if (74>=grade && grade>=60){
    Console.WriteLine("Удовлетворительно");
}
else if (60>grade){
    Console.WriteLine("Неудовлетворительно");
}
else {
    Console.WriteLine("Неверное значение");
}