using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace FrontEnd;

[Route("api/[controller]")]
[ApiController]
public class FrontEndController : ControllerBase
{
    private readonly IBackEnd1Repository _backEnd1Repository;
    private readonly IBackEnd2Repository _backEnd2Repository;
    public FrontEndController(IBackEnd1Repository backEnd1Repository, IBackEnd2Repository backEnd2Repository)            
    {
        _backEnd1Repository = backEnd1Repository ?? throw new ArgumentNullException(nameof(backEnd1Repository));
        _backEnd2Repository = backEnd2Repository ?? throw new ArgumentNullException(nameof(backEnd2Repository));
    }

    [HttpGet]
    public async Task<string> GetBackEndData()
    {
        try
        {
            var backEnd1Result = await _backEnd1Repository.GetBackEnd1Data();
            var backEnd2Result = await _backEnd2Repository.GetBackEnd2Data();

            return  $"BackEnd1: {backEnd1Result} BackEnd2: {backEnd2Result}";
        }
        catch (Exception)
        {
            return "Error encountered when loading data.";
        }
    }

    [HttpPost]
    public async Task Post()
    {
        await _backEnd1Repository.WriteBackEnd1Data(42);
        await _backEnd2Repository.WriteBackEnd2Data(117);
    }

}
