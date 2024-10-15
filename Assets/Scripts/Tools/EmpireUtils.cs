using Domain;

public class EmpireUtils
{
    public static Empire getEmpireFromString(string id)
    {
        return id switch
        {
            "KE" => Empire.CELTS,
            "RO" => Empire.ROM,
            "AG" => Empire.AGYPT,
            "AT" => Empire.ATLANTIS,
            "AV" => Empire.AVALON,
            "KA" => Empire.CARTHAGS,
            "GR" => Empire.GREEK,
            "MA" => Empire.MACEDONIEN,
            "MAU" => Empire.MAURYA,
            "MI" => Empire.MINOES,
            "OL" => Empire.OLMECS,
            "PE" => Empire.PERSIAN,
            "QU" => Empire.QUIN,
            "SK" => Empire.SCYTHES,
            "UT" => Empire.UTOPISTS,
            "WI" => Empire.VIKINGS,
            _ => throw new System.Exception("No empire found of" + id)
        };
    }

    public string getStringOfEmpire(Empire empire)
    {
        return empire switch
        {
            Empire.CELTS => "KE",
            Empire.ROM => "RO",
            Empire.AGYPT => "AG",
            Empire.ATLANTIS => "AT",
            Empire.AVALON => "AV",
            Empire.CARTHAGS => "KA",
            Empire.GREEK => "GR",
            Empire.MACEDONIEN => "MA",
            Empire.MAURYA => "MAU",
            Empire.MINOES => "MI",
            Empire.OLMECS => "OL",
            Empire.PERSIAN => "PE",
            Empire.QUIN => "QU",
            Empire.SCYTHES => "SK",
            Empire.UTOPISTS => "UT",
            Empire.VIKINGS => "WI",
            _ => throw new System.Exception("No id found of" + empire)
        };
    }
}
