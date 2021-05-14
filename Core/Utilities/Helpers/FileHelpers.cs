using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelpers
    {
        public static string Add (IFormFile file)
        {
            string sourcePath = Path.GetTempFileName();
            if (file.Length>0)
            {
                using (var stream = new FileStream(sourcePath,FileMode.Create))
                {
                    file.CopyTo(stream);
                }             
            }
            string destFileName = CreateNewFilePath(file);
            File.Move(sourcePath, destFileName);
            return destFileName;

        }

        private static string CreateNewFilePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            string path = Environment.CurrentDirectory + @"\wwwroot\images";
            string newPath = Guid.NewGuid().ToString() + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }

        public static IResult Delete (string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }
    }

}
