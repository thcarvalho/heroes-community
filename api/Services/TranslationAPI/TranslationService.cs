using Google.Api.Gax.ResourceNames;
using Google.Cloud.Translate.V3;

namespace api.Services.TranslationAPI
{
  public class TranslationService : ITranslationService
  {
    public Translation TranslateText(string text)
    {
      TranslationServiceClient client = TranslationServiceClient.Create();
      TranslateTextRequest request = new TranslateTextRequest
      {
        Contents = { text },
        TargetLanguageCode = "pt-BR",
        Parent = new ProjectName("heroes-community").ToString()
      };
      TranslateTextResponse response = client.TranslateText(request);

      return response.Translations[0];
    }
  }
}