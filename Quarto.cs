class Quarto

{

    public string Name { get; set; }
    public string Email { get; set; }
    public int Room { get; set; }

    public Quarto (string name, string email) {
        Name = name;
        Email = email;
       

    }
    public override string ToString () 
    {
        return $"{Name} , {Email} ";
    }

}