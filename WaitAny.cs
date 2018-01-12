// https://github.com/kbsletten/MultiWait
// Copyright (c) 2018 Kyle Sletten
// Licensed under the MIT license
// https://github.com/kbsletten/MultiWait/blob/master/LICENSE
using System;
using System.Threading.Tasks;

namespace MultiWait
{
    public static partial class Tasks
    {
        public static (T1, T2) WaitAny<T1, T2>(Task<T1> task1, Task<T2> task2)
        {
            var task = 1 + Task.WaitAny(task1, task2);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2));
        }
        public static (T1, T2, T3) WaitAny<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3));
        }
        public static (T1, T2, T3, T4) WaitAny<T1, T2, T3, T4>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4));
        }
        public static (T1, T2, T3, T4, T5) WaitAny<T1, T2, T3, T4, T5>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5));
        }
        public static (T1, T2, T3, T4, T5, T6) WaitAny<T1, T2, T3, T4, T5, T6>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6));
        }
        public static (T1, T2, T3, T4, T5, T6, T7) WaitAny<T1, T2, T3, T4, T5, T6, T7>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11), task == 12 ? task12.Result : default(T12));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11), task == 12 ? task12.Result : default(T12), task == 13 ? task13.Result : default(T13));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11), task == 12 ? task12.Result : default(T12), task == 13 ? task13.Result : default(T13), task == 14 ? task14.Result : default(T14));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11), task == 12 ? task12.Result : default(T12), task == 13 ? task13.Result : default(T13), task == 14 ? task14.Result : default(T14), task == 15 ? task15.Result : default(T15));
        }
        public static (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) WaitAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16)
        {
            var task = 1 + Task.WaitAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15, task16);
            return (task == 1 ? task1.Result : default(T1), task == 2 ? task2.Result : default(T2), task == 3 ? task3.Result : default(T3), task == 4 ? task4.Result : default(T4), task == 5 ? task5.Result : default(T5), task == 6 ? task6.Result : default(T6), task == 7 ? task7.Result : default(T7), task == 8 ? task8.Result : default(T8), task == 9 ? task9.Result : default(T9), task == 10 ? task10.Result : default(T10), task == 11 ? task11.Result : default(T11), task == 12 ? task12.Result : default(T12), task == 13 ? task13.Result : default(T13), task == 14 ? task14.Result : default(T14), task == 15 ? task15.Result : default(T15), task == 16 ? task16.Result : default(T16));
        }
    }
}
