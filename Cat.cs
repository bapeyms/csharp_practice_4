namespace csharp_practice_4;

public struct Cat
{
    private string _name;
    private ushort _age;
    public Cat(string name)
    {
        this._name = name;
        this._age = 0;
    }

    public Cat(string name, ushort age)
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
        return $"Cat : {this._name} Age: {this._age}";
    }
}