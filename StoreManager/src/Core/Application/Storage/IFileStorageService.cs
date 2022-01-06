using StoreManager.Application.Common.Interfaces;
using StoreManager.Domain.Common;
using StoreManager.Shared.DTOs.Storage;

namespace StoreManager.Application.Storage
{
    public interface IFileStorageService : ITransientService
    {
        public Task<string> UploadAsync<T>(FileUploadRequest request, FileType supportedFileType)
        where T : class;
    }
}