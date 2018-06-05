namespace DockerVolume.Services
{
    interface IFileService
    {
        string Read();
        void Write(string text);
    }
}
