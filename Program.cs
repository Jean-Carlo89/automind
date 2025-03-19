


class Program
{
    static List<User> users = new List<User>();

    static void Main(string[] args)
    {
        bool is_running = true;
        while (is_running)
        {
            Console.WriteLine("\n--- Bem vindo ao Sistema de Usuários ---");
            Console.WriteLine("1. Cadastrar Usuário");

            string chosen_option = Console.ReadLine();

            switch (chosen_option)
            {
                case "1":
                    AddUser();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;

            }
        }
    }

    static void AddUser()
    {
        Console.WriteLine("\n  Cadastrar Usuário");

        Console.Write("Nome: ");
        string name = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.Write("Idade: ");
        int age = Console.ReadLine();

        User new_user = new User(name, email, age);

        users.Add(new_user);

        Console.WriteLine("Usuário cadastrado!");
    }

    static void ListUsrs()
    {
        Console.WriteLine("\n Lista de Usuários ");

        if (users.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
        }
        else
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }

}

class User
{
    public string name { get; set; }
    public string email { get; set; }
    public int age { get; set; }

    public User(string name, string email, int age)
    {
        this.name = name;
        this.email = email;
        this.age = age;
    }

    // returns user info**
    public override string ToString()
    {
        return $"Nome: {nome}, E-mail: {email}, Idade: {age}";
    }

}