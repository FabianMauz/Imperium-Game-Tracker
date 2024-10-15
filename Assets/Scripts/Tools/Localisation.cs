using Domain;

public class Localisation
{
    public static string getEmpireName(Empire empire, Language language)
    {
        return empire switch
        {
            Empire.CELTS => "Kelten",
            Empire.ROM => "Römer",
            Empire.AGYPT => "Ägypter",
            Empire.ATLANTIS => "Atlanter",
            Empire.AVALON => "Avalonier",
            Empire.CARTHAGS => "Karthager",
            Empire.GREEK => "Griechen",
            Empire.MACEDONIEN => "Makedonier",
            Empire.MAURYA => "Maurya",
            Empire.MINOES => "Minoer",
            Empire.OLMECS => "Olmeken",
            Empire.PERSIAN => "Perser",
            Empire.QUIN => "Quin",
            Empire.SCYTHES => "Skythen",
            Empire.UTOPISTS => "Utopisten",
            Empire.VIKINGS => "Wikinger",
            _ => throw new System.Exception("No name found of" + empire)
        };
    }
}
