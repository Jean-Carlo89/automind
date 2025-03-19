using system;

class Main
{


}

class Usuario
{
    public string name { get; set}
    public string email { get; set}
    public int age { get; set}

    public Usuario(string name, string email, int age)
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