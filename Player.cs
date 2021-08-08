public class Player
{
    //Variables
    private string name;
    private int age;
    private string gender;
    private int birthYear;

    //Encapsulation
    public string Name
    {
        get{return name;}
        set
        {
            if(value == "Bozo" || value == "Clown")
            {
                name = "N/A";
            }
            else
            {
                name = value;
            }
        }
    }
    public int Age { get => age; set => age = value; }
    public string Gender { get => gender; set => gender = value; }
    public int BirthYear { get => birthYear; set => birthYear = value; }


    //Constructor
    public Player(string n, int a, string g, int b)
    {
        this.Name = n;
        this.Age = a;
        this.Gender = g;
        this.BirthYear = b;
    }

    //Methods
    public virtual string toString()
    {
        return $"Player Name: {name}  Player Age: {age}  Gender: {gender}  BirthYear: {BirthYear}";
    }
}