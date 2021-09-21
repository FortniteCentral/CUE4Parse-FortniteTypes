using System;
using CUE4Parse.FileProvider.Vfs;

namespace CUE4Parse.Utilities
{
    public class UtilityExtensions
    {
        private static IVfsFileProvider _provider;

        public UtilityExtensions(IVfsFileProvider provider)
        {
            _provider = provider ?? throw new NullReferenceException("Provider is null.");
        }
    }
}