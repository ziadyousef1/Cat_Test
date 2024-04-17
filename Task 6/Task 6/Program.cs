namespace Task_6
{
    internal class Program
    {
        /*Async programming is one way of implementing concurrency. 
        Multithreading, specifically using the thread pool, is utilized for CPU-bound tasks or parallel processing.

        Another type of concurrency is asynchronous programming, which employs promises (or futures). 
       Future types are represented by Task or Task<TResult>.

         Async programming is typically employed for I/O-bound operations(network requests or database access).
       */
        static async Task Main(string[] args)
        {

            Console.WriteLine("Fetching data from the remote server.....");
            string data = await FetchDataAsync();
            Console.WriteLine("Data received: " + data);
        }

        static async Task<string> FetchDataAsync()
        {
           
            await Task.Delay(2000); 

            return "Data";
        }
    }
}