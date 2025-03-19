


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
            Console.WriteLine("2. Listar usuários");
            string chosen_option = Console.ReadLine() ?? "default_value";



            switch (chosen_option)
            {
                case "1":
                    AddUser();
                    break;

                case "2":
                    ListUsers();
                    break;

                case "default_value":
                    Console.WriteLine("Opção inválida. Tente novamente.");
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
        //---------- Nome
        string name;
        do
        {
            Console.Write("Nome: ");
            name = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Nome inválido. O nome não pode ser vazio. Tente novamente.");
            }
        } while (string.IsNullOrWhiteSpace(name));


        //-------------- Email

        string email;
        do
        {
            Console.Write("Email: ");
            email = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Email inválido. O email não pode ser vazio. Tente novamente.");
            }
        } while (string.IsNullOrWhiteSpace(email));

        //-------

        //----------- Idade


        string age_input;

        int age = 0;
        bool valid_age = false;
        do
        {
            Console.Write("Idade: ");
            age_input = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(age_input))
            {
                Console.WriteLine("Idade inválido. A idade não pode ser vazio. Tente novamente.");
                continue;
            }



            if (!int.TryParse(age_input, out age))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                continue;
            }

            if (age <= 0)
            {
                Console.WriteLine("Entrada inválida. Digite um número positivo.");

                continue;
            }

            valid_age = true;
        } while (!valid_age);





        User new_user = new User(name, email, age);

        users.Add(new_user);

        Console.WriteLine("Usuário cadastrado!");
    }

    static void ListUsers()
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
        return $"Nome: {this.name}, E-mail: {this.email}, Idade: {this.age}";
    }

}