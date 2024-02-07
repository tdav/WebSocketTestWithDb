using App.Models;
using Microsoft.AspNetCore.Http;

namespace App.Repository.Services.v1
{
    public interface IFileService
    {
        ValueTask<Answer<string>> PostFile(IFormFile fileForm);
    }

    public class FileService : IFileService
    {
        public async ValueTask<Answer<string>> PostFile(IFormFile fileForm)
        {
            if (fileForm == null || fileForm.FileName == "") return new Answer<string>(false, "Юборилган файл келмади", null);
            if (fileForm.Length > 200000) return new Answer<string>(false, "Файл хажми 200KBдан катта булмасин...", null);

            var path = $"{AppDomain.CurrentDomain.BaseDirectory}wwwroot{Path.DirectorySeparatorChar}store{Path.DirectorySeparatorChar}";

            var fileName = fileForm.FileName.Replace(' ', '_');
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            using (var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                await fileForm.CopyToAsync(stream);
            }

            var fileUrl = $"/store/{fileName}";

            return new Answer<string>(true, "", fileUrl);
        }
    }
}
