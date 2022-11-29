﻿using System;
using InspectorLib;

namespace belomestnovInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp func = new FunctionInsp();

            func.GetInspector("Васильев Василий Иванович");//Вывод главного инспектора
            func.GetСarInspection("Автоинспекция г. Чита");//Вывод названия автоинспекции
            func.SetInspector("");//Изменение ФИО главного инспектора
            func.GenerateNumber(8, 'Е');//Вывод госномера
            func.GetWorker();//Вывод списка сотрудников автоинспекции
            func.AddWorker();//Добавление сотрудника автоинспекци
        }
    }
}
