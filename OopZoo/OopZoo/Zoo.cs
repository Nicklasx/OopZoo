using System;

class Zoo
{
    private string zooName;

    public Zoo(string zooName)
    {
        this.zooName = zooName;
    }

    public string Velkomst()
    {
        return "Velkommen til " + ZooName + 
            " vil du ind og se på nogen dyr?";
    }

    public string ZooName
    {
        get { return zooName; }
        set { zooName = value; }
    }
}
