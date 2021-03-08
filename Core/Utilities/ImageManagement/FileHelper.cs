using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace Core.Utilities.ImageManagement
{
    public class FileHelper
    {
        public static Guid Guid { get; set; }
        
        public static string Add(IFormFile formFile, string sourcePath)
        {
            Guid = Guid.NewGuid();
            var filePath = Path.Combine(sourcePath + Guid.ToString() + ".jpeg");
            
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            return filePath;
        }

        public static string Update(IFormFile formFile, string sourcePath)
        {
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }

            return sourcePath;
        }
        public static void Delete(string sourcePath)
        {
            try
            {
                File.Delete(sourcePath);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

    }
}
