namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;
    private string _sender;
    private string _location1;
    private string _location2;
    private string _souvenirs;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetLocation1()
    {
      return _location1;
    }

    public void SetLocation1(string newLocation1)
    {
      _location1 = newLocation1;
    }

    public string GetLocation2()
    {
      return _location2;
    }

    public void SetLocation2(string newLocation2)
    {
      _location2 = newLocation2;
    }

    public string GetSouvenirs()
    {
      return _souvenirs;
    }

    public void SetSouvenirs(string newSouvenirs)
    {
      _souvenirs = newSouvenirs;
    }

  }
}
