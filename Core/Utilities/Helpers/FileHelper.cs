﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string Add(IFormFile file, string path)
        {
            var sourcepath = Path.GetTempFileName();

            if (file.Length > 0) using (var stream = new FileStream(sourcepath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(sourcepath, path);
            return path;
        }

        public void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
                
        }

        public string Update(string pathToUpdate, IFormFile file, string path)
        {

            if (path.Length > 0) using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Delete(pathToUpdate);
            return path;
        }
    }
}