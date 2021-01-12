using Google.Cloud.Translate.V3;

namespace api.Services.TranslationAPI
{
  public interface ITranslationService
  {
    Translation TranslateText(string text);
  }
}