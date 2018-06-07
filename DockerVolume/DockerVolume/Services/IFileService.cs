namespace DockerVolume.Services
{
    public interface IFileService
    {
        string Read();
        void Write(string text);
    }
}
