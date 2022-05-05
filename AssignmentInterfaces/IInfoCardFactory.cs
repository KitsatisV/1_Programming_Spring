public interface IInfoCardFactory
{
    IInfoCard CreateNewInfoCard(string category);
    IInfoCard CreateInfoCard(string initialDetails);
    string[] CategoriesSupported { get; }
    string GetDescription(string category);
}
