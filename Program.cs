// NIVEL 1
class Animal
{
    private string nombre;
    private int edad;

    public Animal(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public int GetEdad()
    {
        return edad;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}


// NIVEL 2
class Mamifero : Animal
{
    private bool tienePelo;

    public Mamifero(string nombre, int edad, bool tienePelo)
        : base(nombre, edad)
    {
        this.tienePelo = tienePelo;
    }

    public void Amamantar()
    {
        Console.WriteLine(GetNombre() + " puede amamantar.");
    }
}


// NIVEL 2
class Reptil : Animal
{
    private bool venenoso;

    public Reptil(string nombre, int edad, bool venenoso)
        : base(nombre, edad)
    {
        this.venenoso = venenoso;
    }

    public void Arrastrarse()
    {
        Console.WriteLine(GetNombre() + " se está desplazando.");
    }
}


// NIVEL 3
class Leon : Mamifero
{
    public Leon(string nombre, int edad)
        : base(nombre, edad, true)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine(GetNombre() + " ruge.");
    }

    public void Caminar()
    {
        Console.WriteLine(GetNombre() + " camina por tierra.");
    }
}


// NIVEL 3 - MAMÍFERO ACUÁTICO
class Delfin : Mamifero
{
    public Delfin(string nombre, int edad)
        : base(nombre, edad, false)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine(GetNombre() + " emite silbidos.");
    }

    public void Nadar()
    {
        Console.WriteLine(GetNombre() + " está nadando.");
    }
}


// NIVEL 3
class Cocodrilo : Reptil
{
    public Cocodrilo(string nombre, int edad)
        : base(nombre, edad, false)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine(GetNombre() + " gruñe.");
    }

    public void Nadar()
    {
        Console.WriteLine(GetNombre() + " está nadando.");
    }
}


// NIVEL 3
class Serpiente : Reptil
{
    public Serpiente(string nombre, int edad, bool venenosa)
        : base(nombre, edad, venenosa)
    {
    }

    public override void HacerSonido()
    {
        Console.WriteLine(GetNombre() + " sisea.");
    }

    public void Arrastrarse()
    {
        Console.WriteLine(GetNombre() + " se arrastra.");
    }
}


// PROGRAMA PRINCIPAL
class Program
{
    static void Main(string[] args)
    {
        Leon leon = new Leon("Simba", 5);
        Delfin delfin = new Delfin("Flipper", 8);
        Cocodrilo cocodrilo = new Cocodrilo("Coco", 12);
        Serpiente serpiente = new Serpiente("Kaa", 4, true);

        leon.MostrarInfo();
        leon.HacerSonido();

        Console.WriteLine();

        delfin.MostrarInfo();
        delfin.HacerSonido();
        delfin.Nadar();

        Console.WriteLine();

        cocodrilo.MostrarInfo();
        cocodrilo.HacerSonido();
        cocodrilo.Nadar();

        Console.WriteLine();

        serpiente.MostrarInfo();
        serpiente.HacerSonido();

        // POLIMORFISMO
        Console.WriteLine("\n--- Sonidos de los animales ---");

        Animal[] animales = { leon, delfin, cocodrilo, serpiente };

        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }
    }
}
