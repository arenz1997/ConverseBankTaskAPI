namespace ConverseBankTaskAPI.Interfaces
{
    public interface IPhotoSaver
    {
        public string SaveData(byte[] PhotoInfo, string Destination);
    }
}
