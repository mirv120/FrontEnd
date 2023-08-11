using NUnit.Framework;
using FrontEnd;
using NSubstitute;
using Microsoft.Extensions.Configuration;

namespace FrontEndTests;

public class FrontEndControllerTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void FrontEndController_GetBackEndData_ReturnsExpectedString()
    {
        var backEnd1Repository = Substitute.For<IBackEnd1Repository>();
        var backEnd2Repository = Substitute.For<IBackEnd2Repository>();

        backEnd1Repository.GetBackEnd1Data().Returns(42);
        backEnd2Repository.GetBackEnd2Data().Returns(117);

        var frontEndController = new FrontEndController(backEnd1Repository, backEnd2Repository);

        Task<string> result = frontEndController.GetBackEndData();
        result.Wait();

        Assert.That(result.Result, Is.EqualTo("BackEnd1: 42 BackEnd2: 117"));
    }
}