using ALXCSharpCourse.Models;

namespace ALXCSharpCourse.Demo
{
    public class ClassesDemo
    {
        public static void Run()
        {
            // NazwaKlasy nazwaObiektu = new NazwaKlasy();
            Dog westieDog = new Dog();
            westieDog.Name = "Skiper";
            westieDog.Race = "West Highland White Terrier";
            westieDog.Present();
            westieDog.Bark();
            westieDog.Bite();

            Dog labradorDog = new Dog();
            labradorDog.Name = "Borys";
            labradorDog.Race = "Labrador Retriever";
            labradorDog.Present();
            labradorDog.Bark();
            labradorDog.Bite();

            Dog goldenDog = new Dog 
            {
                Name = "Misio",
                Race = "Golden Retriever"
            };
            goldenDog.Present();
            goldenDog.Bark();
            goldenDog.Bite();

            Dog borderColieDog = new Dog("Java","Border Colie");
            borderColieDog.Present();
            borderColieDog.Bark();
            borderColieDog.Bite();

            Dog.Run();
        }
    }
}
