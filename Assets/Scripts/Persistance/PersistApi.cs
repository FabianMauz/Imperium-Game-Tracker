namespace Persistance
{
    public interface PersistApi
    {
        void saveResultOfMatch(string matchIdentificator, int difficulty);
        int loadResultOfMatch(string matchIdentificator);
    }
}
