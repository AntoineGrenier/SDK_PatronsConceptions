// Using the builder pattern to create a Person object
Person person = new PersonBuilder()
    .SetFirstName("John")
    .SetLastName("Doe")
    .SetAge(30)
    .Build();

Console.WriteLine(person);

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}

class PersonBuilder
{
    private Person person = new Person();

    public PersonBuilder SetFirstName(string firstName)
    {
        person.FirstName = firstName;
        return this;
    }

    public PersonBuilder SetLastName(string lastName)
    {
        person.LastName = lastName;
        return this;
    }

    public PersonBuilder SetAge(int age)
    {
        person.Age = age;
        return this;
    }

    public Person Build()
    {
        return person;
    }
}