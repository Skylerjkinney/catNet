namespace catNet.Services;

public class CatsService(CatsRepository repo)
{
    private readonly CatsRepository repo = repo;

    internal List<Cat> GetCats()
    {
        List<Cat> cats = repo.GetCats();
        return cats;
    }

    internal Cat GetCatById(string catId)
    {
        Cat cat = repo.GetCatById(catId);
        if (cat == null) throw new Exception($"could not find kitty at {catId}");
        return cat;
    }
}