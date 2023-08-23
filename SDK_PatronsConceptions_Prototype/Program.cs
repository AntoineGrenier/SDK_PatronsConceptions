// Original person
var originalPerson = new Person
{
    Name = "Alice",
    Address = new Address { Street = "123 Main St", City = "Wonderland" }
};

// Creating a cloned person using prototype pattern
var clonedPerson = (Person)originalPerson.Clone();

// Modifying the cloned person's address
clonedPerson.Address.Street = "456 Secondary Ave";
clonedPerson.Address.City = "Dreamland";

// Outputting both original and cloned persons
Console.WriteLine(originalPerson);
Console.WriteLine(clonedPerson);

class Address : ICloneable
{
    public string Street { get; set; }
    public string City { get; set; }

    public object Clone()
    {
        return MemberwiseClone(); // Shallow copy
    }

    public override string ToString()
    {
        return $"Address: {Street}, {City}";
    }
}

class Person : ICloneable
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public object Clone()
    {
        Person clonedPerson = (Person)MemberwiseClone(); // Shallow copy
        clonedPerson.Address = (Address)Address.Clone();  // Deep copy for Address
        return clonedPerson;
    }

    public override string ToString()
    {
        return $"Person: {Name}, {Address}";
    }
}