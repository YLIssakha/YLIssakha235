class Contact 
{
    private string firstname, lastname;
    private int phonenumber;

    public Contact(string firstname, string lastname)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.phonenumber = 0;
    }

    public void SetPhoneNumber(int phonenumber)
    {
        this.phonenumber = phonenumber;
    }

    //public void SetPhoneNumber(string phonenumber)
    //{
      //  this.phonenumber = Convert.ToInt32(phonenumber);
    //}


}

class City
{
    private Contact  mayor;
    private string name;

    public City( string name)
    {
        this.name = name;
        mayor = null;

    }

    public Contact Mayor
    {
        get { return mayor;}
        set { mayor = value;}

    }
}