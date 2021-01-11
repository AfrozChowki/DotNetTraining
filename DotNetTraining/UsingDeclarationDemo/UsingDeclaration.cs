using System;
using System.Threading.Tasks;

namespace DotNetTraining.UsingDeclarationDemo
{
    class UsingDeclaration : IDisposable, IAsyncDisposable
    {
        public UsingDeclaration()
        {
            Console.WriteLine("Resource created...");
        }
        public void Dispose()
        {
            Console.WriteLine("Resource disposed..");
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();
            Console.WriteLine("Resource disposed asyncronously..");
        }

        /// <summary>
        /// Method to dispose common disposable items, which can be used directly or overriden in child class
        /// </summary>
        /// <returns></returns>
        protected virtual async ValueTask DisposeAsyncCore()
        {
            Console.WriteLine("Resource disposed asyncronously with core method..");
        }
    }
}