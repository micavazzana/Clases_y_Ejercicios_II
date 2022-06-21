﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public class FilesException : Exception
    {
        public FilesException(): base("Error al manejar los archivos")
        {
        }
        public FilesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
