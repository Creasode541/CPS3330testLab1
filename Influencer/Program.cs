// Michael Banko - CPS 3330 Midterm SP24

// create influencer class
class Influencer {
    // create local fields
    private string name;
    private string expertise;
    private int followers;

    // getters and setters for each local field
    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Expertise {
        get { return expertise; }
        set { expertise = value; }
    }

    public int Followers {
        get { return followers; }
        set { followers = value; }
    }

    // constructor 1 - default constructor
    public Influencer() {
        name = "Unknown";
        expertise = "General";
        followers = 0;
    }

    // constructor 2 - constructor with pass through values
    public Influencer(string name, string expertise, int followers) {
        this.name = name;
        this.expertise = expertise;
        this.followers = followers;
    }

    // constructor 3 - constructor that sets value in the input field
    public Influencer(string name) : this(name, "General", 0) {
    }

    // destructor
    ~Influencer() {
        Console.WriteLine($"Influencer {name} has been self-destructed.");
    }

    // object initializer
    public Influencer(string name, string expertise)
    {
        this.name = name;
        this.expertise = expertise;
    }

    // method to output influencer properties
    public void ShowcaseInfluencer() {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Expertise: {expertise}");
        Console.WriteLine($"Followers: {followers}");
        Console.WriteLine();
    }

    // overload of the + operator
    public static Influencer operator +(Influencer influencer1, Influencer influencer2) {
        string newName = $"{influencer1.name} & {influencer2.name}";
        string newExpertise = influencer1.expertise == influencer2.expertise ? influencer1.expertise : "Mixed";
        int newFollowers = influencer1.followers + influencer2.followers;
        return new Influencer(newName, newExpertise, newFollowers);
    }
}

class Program {
    static void Main(string[] args) {
        // making influencers while testing different constructors
        Influencer influencer1 = new Influencer("John Doe", "Technology", 100000);
        Influencer influencer2 = new Influencer("Jane Smith", "Fashion", 50000);
        Influencer influencer3 = new Influencer("Mike Johnson");
        Influencer influencer4 = new Influencer { Name = "Alice Brown", Expertise = "Fitness", Followers = 75000 };

        // showcasing the properties of each influencer
        Console.WriteLine("Influencer 1:");
        influencer1.ShowcaseInfluencer();

        Console.WriteLine("Influencer 2:");
        influencer2.ShowcaseInfluencer();

        Console.WriteLine("Influencer 3:");
        influencer3.ShowcaseInfluencer();

        Console.WriteLine("Influencer 4:");
        influencer4.ShowcaseInfluencer();

        // testing overload of +
        Influencer mergedInfluencer = influencer1 + influencer2;
        Console.WriteLine("Merged Influencer:");
        mergedInfluencer.ShowcaseInfluencer();
    }
}
