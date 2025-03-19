using system;

class Main
{
    statitc List<>

}

class User
{
    public string name { get; set}
    public string email { get; set}
    public int age { get; set}

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