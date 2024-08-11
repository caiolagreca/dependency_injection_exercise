using DependencyInjectionExercise.Models;

namespace DependencyInjectionExercise.Services
{
    public interface ITransientService
    {
        List<Product> GetAll();
    }

    public class ServiceInjection : ITransientService
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {Id = 1, Name = "Pen Drive"},
                new Product {Id = 2, Name = "CD" },
                new Product {Id = 3, Name = "Disket" },
                new Product {Id = 4, Name = "HD" },
            };
        }
    }
}
