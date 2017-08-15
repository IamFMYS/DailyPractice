using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace GetAwaiterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task t = new Task(() => { });
            //t.GetAwaiter();
            Main2();
            Console.ReadKey();
        }
        static async void Async2()
        {
            await Task.Run(() => { Thread.Sleep(500); Console.WriteLine("bbb"); });
            Console.WriteLine("ccc");
        }

        static async void VoidAsync()
        {
            Console.WriteLine("before awaiting");
            await Task.Delay(5);
            Console.WriteLine("after awaiting");
        }
        static async Task TaskAsync()
        {
            Console.WriteLine("before awaiting.");
            await Task.Delay(5);
            Console.WriteLine("after awaiting.");
        }
        static async Task<int> GenericTaskAsync()
        {
            Console.WriteLine("before awaiting.");
            await Task.Delay(5);
            Console.WriteLine("after awaiting.");
            return 1;
        }

        public static void Main2()
        {
            MyAwaitable();
        }
        public static async void MyAwaitable()
        {
            Console.WriteLine("before awaiting");
            var awaitable = new Awaitable<int>();
            await awaitable;
            Console.WriteLine("after awaiting");
        }
    }

    public class Awaitable<T>
    {
        public Awaiter<T> GetAwaiter()
        {
            return new Awaiter<T>();
        }
    }
    public class Awaiter<T> : INotifyCompletion
    {
        public void OnCompleted(Action continuation)
        {
            continuation?.Invoke(); //???
        }
        public bool IsCompleted { get; set; }
        public T GetResult()
        {
            return default(T);
        }
    }
}
