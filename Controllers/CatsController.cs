namespace catNet.Controllers;

[ApiController]
[Route("api/cats")]

public class CatsController : ControllerBase
{
    private readonly CatsService catsService;

    public CatsController(CatsService catsService)
    {
        this.catsService = catsService;
    }

    [HttpGet]
    public ActionResult<List<Cat>> GetCats()
    {
        try
        {
            List<Cat> cats = catsService.GetCats();
            return Ok(cats);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpGet("{catId}")]
    public ActionResult<Cat> GetCatById(string catId)
    {
        try
        {
            Cat cat = catsService.GetCatById(catId);
            return Ok(cat);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}