namespace FrontEnd;

public interface IBackEnd2Repository
{
    Task<int> GetBackEnd2Data();

    Task WriteBackEnd2Data(int valueToPost);
}
