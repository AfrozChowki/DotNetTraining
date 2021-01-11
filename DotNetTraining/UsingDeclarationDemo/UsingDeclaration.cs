using System;

namespace DotNetTraining.UsingDeclarationDemo
{
    class UsingDeclaration : IDisposable
    {
        public UsingDeclaration()
        {
            Console.WriteLine("Resource created...");
        }
        public void Dispose()
        {
            Console.WriteLine("Resource disposed..");
        }
    }
}