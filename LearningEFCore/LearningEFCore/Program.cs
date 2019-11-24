using LearningEFCore.Entities;
using LearningEFCore.Infrastructure;
using LearningEFCore.SavingData;
using System;
using System.Linq;

namespace LearningEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveManyToMany.Run();
        }
    }
}
