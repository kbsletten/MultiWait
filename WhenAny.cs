using System;
using System.Threading.Tasks;

namespace MultiWait
{
    public static partial class Tasks
    {
        public static async Task<(T1, T2)> WhenAny<T1, T2>(Task<T1> task1, Task<T2> task2)
        {
            var task = await Task.WhenAny(task1, task2).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2));
        }
        public static async Task<(T1, T2, T3)> WhenAny<T1, T2, T3>(Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            var task = await Task.WhenAny(task1, task2, task3).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3));
        }
        public static async Task<(T1, T2, T3, T4)> WhenAny<T1, T2, T3, T4>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4));
        }
        public static async Task<(T1, T2, T3, T4, T5)> WhenAny<T1, T2, T3, T4, T5>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6)> WhenAny<T1, T2, T3, T4, T5, T6>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7)> WhenAny<T1, T2, T3, T4, T5, T6, T7>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11), task12 == task ? task12.Result : default(T12));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11), task12 == task ? task12.Result : default(T12), task13 == task ? task13.Result : default(T13));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11), task12 == task ? task12.Result : default(T12), task13 == task ? task13.Result : default(T13), task14 == task ? task14.Result : default(T14));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11), task12 == task ? task12.Result : default(T12), task13 == task ? task13.Result : default(T13), task14 == task ? task14.Result : default(T14), task15 == task ? task15.Result : default(T15));
        }
        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16)
        {
            var task = await Task.WhenAny(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15, task16).ConfigureAwait(continueOnCapturedContext: false);
            return (task1 == task ? task1.Result : default(T1), task2 == task ? task2.Result : default(T2), task3 == task ? task3.Result : default(T3), task4 == task ? task4.Result : default(T4), task5 == task ? task5.Result : default(T5), task6 == task ? task6.Result : default(T6), task7 == task ? task7.Result : default(T7), task8 == task ? task8.Result : default(T8), task9 == task ? task9.Result : default(T9), task10 == task ? task10.Result : default(T10), task11 == task ? task11.Result : default(T11), task12 == task ? task12.Result : default(T12), task13 == task ? task13.Result : default(T13), task14 == task ? task14.Result : default(T14), task15 == task ? task15.Result : default(T15), task16 == task ? task16.Result : default(T16));
        }
    }
}
