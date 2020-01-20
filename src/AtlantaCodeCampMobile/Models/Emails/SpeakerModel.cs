using System.Reflection;

namespace AtlantaCodeCampMobile.Models.Emails
{
  public class SpeakerModel : EmailModel
  {
    //public Speaker Speaker { get; internal set; }
    public string SpeakerUrl { get; internal set; }
    public EventInfo Event { get; internal set; }
  }
}
