namespace FrontEnd;

public interface IBackEnd1Repository
{
    Task<int> GetBackEnd1Data();
    Task WriteBackEnd1Data(int valueToPost);
}
