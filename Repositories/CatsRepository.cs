namespace catNet.Repositories;

public class CatsRepository
{
    private readonly List<Cat> FAKEDB = [
        new Cat("Mini", "tuxedo", "Black and White", true, 2),
        new Cat("Juniper", "tabby", "Brown", true, .5),
        new Cat("Mr.MeowStache", "cute", "grey", true, .75),
    ];

    internal List<Cat> GetCats()
    {
        return FAKEDB;
    }
    internal Cat GetCatById(string catId)
    {
        Cat cat = FAKEDB.Find(cat => cat.Id == catId);
        return cat;
    }
}