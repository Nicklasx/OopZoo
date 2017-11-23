using System;

class Zoo
{
    private string zooName;

    public Zoo(string zooName)
    {
        this.zooName = zooName;
    }

    public string Describe()
    {
        return "Velkommen til " + ZooName;
    }

    public string ZooName
    {
        get { return zooName; }
        set { zooName = value; }
    }
}
