namespace csharp_practice_4;

internal class Document
{
    // auto-property
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    private ushort _pages;
    public ushort Pages
    {
        get
        {
            return (ushort)(this._pages * 100);
        }
        set
        {
            if (value > 0) 
                _pages = value;
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}