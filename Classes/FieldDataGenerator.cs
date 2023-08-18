using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconstructor.Classes
{
    public enum GenerationType
    {
        Random, // рандомно взять данные
        Foreach, // взять от заданного до заданного
        Forloop, // сгенерить от заданного до заданного
    }
    public abstract class FieldDataGenerator
    {
        protected GenerationType typeOfGeneration;
        protected List<string> source;
        protected string wrapper = "'";
        protected int counter { get; private set; }

        public FieldDataGenerator(GenerationType type) 
        {
            typeOfGeneration = type;
            counter = 1;
        }
        public void Clear()
        {
            counter = 1;
        }
        public string Generate()
        {
            switch (typeOfGeneration)
            {
                case GenerationType.Random:
                    return RandomGenerate();
                case GenerationType.Foreach:
                    Increment();
                    return ForEachGenerate();
                case GenerationType.Forloop:
                default:
                    Increment();
                    return ForLoopGenerate(); 
            }
        }
        protected string RandomGenerate()
        {
            Random random = new Random();
            return source[random.Next(source.Count)];
        }
        private void Increment()
        {
            counter++;
        }
        protected virtual string ForEachGenerate()
        {
            return source[counter];
        }
        protected virtual string ForLoopGenerate()
        {
            return counter.ToString();
        }
    }
}
