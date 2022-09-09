using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerLibrary.Interfaces
{
    public interface IValueGenerator
    {
        object Generate(Type typeToGenerate, GeneratorContext context);
        // Позволяет реализовывать сколь угодно сложную логику определения,
        // подходит ли генератор. Таким образом можно работать с генераторами
        // коллекций аналогично генераторам примитивных типов.
        bool CanGenerate(Type type);

        object Generate(Type type);
    }
}
