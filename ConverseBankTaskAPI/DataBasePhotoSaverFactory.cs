using ConverseBankTaskAPI.Interfaces;

namespace ConverseBankTaskAPI
{
    public class DataBasePhotoSaverFactory : IPhotoSaverFactory
    {
        public IPhotoSaver CreatePhotoSaver()
        {
            return new DataBasePhotoSaver();
        }
    }
}
