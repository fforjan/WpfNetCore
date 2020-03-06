using System;

namespace WpfNetCore.Services
{
    public class SampleService : ISampleService
    {
        public string GetCurrentDate()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
