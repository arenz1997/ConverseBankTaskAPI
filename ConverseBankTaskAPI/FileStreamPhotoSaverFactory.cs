using ConverseBankTaskAPI.Interfaces;

namespace ConverseBankTaskAPI
{
    public class FileStreamPhotoSaverFactory : IPhotoSaverFactory
    {
        public IPhotoSaver CreatePhotoSaver()
        {
            return new FileStreamPhotoSaver();
        }
    }
}
