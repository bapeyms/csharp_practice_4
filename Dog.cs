namespace csharp_practice_4;

public class Dog
{
    private string _name;
    private ushort _age;
    
    public Dog(string name)
    {
        this._name = name;
        this._age = 0;
    }

    public Dog(string name, ushort age)
    {
        this._name = name;
        this._age = age;
    }
    
    public void SetAge(ushort age)
    {
        this._age = age;
    }
    
    public override string ToString()
    {
        return $"Dog : {this._name} Age: {this._age}";
    }
}