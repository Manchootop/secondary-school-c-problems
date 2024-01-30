
class Stationaryphone : ICallable
{
    public string Website { get; set; }
    public string Number { get; set; }

    public Stationaryphone(string website, string number)
    {
        this.Website = website;
        this.Number = number;
    }
}
//todo withg 7 digits call