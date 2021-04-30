using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class AsyncEncryptionCollection : IAsyncEnumerable<string?>
{
    public async IAsyncEnumerator<string> GetAsyncEnumerator(
        CancellationToken cancellationToken = default)
    {
        yield return "hi?";
    }
    static public async void Main()
    {
        AsyncEncryptionCollection collection = new AsyncEncryptionCollection();
        await foreach (string fileName in collection)
        {
            Console.WriteLine(fileName);
        }
    }
}

// public class AsyncSynchronizationContext : SynchronizationContext
// {
// public Exception? Exception { get; set; }
// public ManualResetEventSlim ResetEvent { get;} = new ManualResetEventSlim();
// public override void Send(SendOrPostCallback callback, object? state)
// {
// notification invoked...(Thread ID: {
// Thread.CurrentThread.ManagedThreadId})");
//           callback(state);
// }
// catch (Exception exception) {
//           Exception = exception;
// #if !WithOutUsingResetEvent
//           ResetEvent.Set();
// #endif }
// }
// try
// {
//     Console.WriteLine($@"Send
//  public override void Post(SendOrPostCallback callback, object? state)
// {
// notification invoked...(Thread ID: {
// Thread.CurrentThread.ManagedThreadId})");
//           callback(state);
// }
// catch (Exception exception) {
//           Exception = exception;
// #if !WithOutUsingResetEvent
//           ResetEvent.Set();
// #endif }
// } }
// public static class Program {
// static bool EventTriggered { get; set; }
// public const string ExpectedExceptionMessage = "Expected Exception";
// public static void Main() {
//       SynchronizationContext?
// originalSynchronizationContext =
//           SynchronizationContext.Current;
// try
//       {
//           AsyncSynchronizationContext
// synchronizationContext =
// new
// AsyncSynchronizationContext();
// try
// {
//     Console.WriteLine($@"Post

//  SynchronizationContext.SetSynchronizationConte
// xt(
//               synchronizationContex      t);
// await OnEvent(typeof(Program), EventArgs.Empty);
// #if WithOutUsingResetEvent
//           Task.Delay(1000).Wait();  //
// #else
// synchronizationContext.ResetEvent.Wait();
// #endif
// != null)
// if(synchronizationContext.Exception {
//               Console.WriteLine($@"Throwing
// expected exception....(Thread ID: {
// Thread.CurrentThread.ManagedThreadId})");
// System.Runtime.ExceptionServices.ExceptionDisp
// atchInfo.Capture(
// synchronizationContext.Exception).Throw();
//           }
// }
// catch(Exception exception) {
//           Console.WriteLine($@"{exception}
// thrown as expected.(Thread ID: {
// Thread.CurrentThread.ManagedThreadId})");
//       }
// finally
// {

// SynchronizationContext.SetSynchronizationConte
// xt(
//               originalSynchronizationContext);
// } }
// private static async void OnEvent(object sender, EventArgs eventArgs)
//   {
//       Console.WriteLine($@"Invoking
// Task.Run...(Thread ID: {
// Thread.CurrentThread.ManagedThreadId})"); await Task.Run(()=>
// {
// {
// EventTriggered = true;
//           Console.WriteLine($@"Running task...
// (Thread ID: {
// Thread.CurrentThread.ManagedThreadId})"); throw new
// Exception(ExpectedExceptionMessage);
//       });
// } }




// public class Program
// {
//     static public async IAsyncEnumerable<string>
//         EncryptFilesAsync(
//             string directoryPath = null,
//             string searchPattern = "*",
//             [EnumeratorCancellation]
//         CancellationToken cancellationToken = default)
//         {

//         }

// public static void Green(string word)
// {
//     Console.BackgroundColor = ConsoleColor.Green;
//     Console.Write(word);
//     Console.ResetColor();
// }
// public static void Main()
// {
//     const int repetitions = 1000;

//     Task task1 = Task.Run(() =>
//     {
//         Green("1");
//         for (int count = 0; count < repetitions; count++)
//         {
//             Console.ForegroundColor = ConsoleColor.White;
//             Console.BackgroundColor = ConsoleColor.Blue;
//         }
//     });
//     Task task2 = Task.Run(() =>
//     {
//         Green("2");
//         for (int count = 0; count < repetitions; count++)
//         {
//             Console.ForegroundColor = ConsoleColor.Black;
//             Console.BackgroundColor = ConsoleColor.Yellow;
//         }
//     });
//     Task task3 = Task.Run(() =>
//     {
//         Green("3");
//         for (int count = 0; count < repetitions; count++)
//         {
//             Console.ForegroundColor = ConsoleColor.White;
//             Console.BackgroundColor = ConsoleColor.Red;
//         }
//     });

//     Task task4 = Task.Run(() =>
//     {
//         Green("4");
//         for (int count = 0; count < repetitions; count++)
//         {
//             Console.Write('+');
//         }
//     });
//     Task task5 = Task.Run(() =>
//     {
//         Green("5");
//         for (int count = 0; count < repetitions; count++)
//         {
//             Console.Write('-');
//         }
//     });
// task1.Wait();
// task2.Wait();
// task3.Wait();
// task4.Wait();
// task5.Wait();
// }
// }