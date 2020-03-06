namespace ServiceImpl
{
    using System;
    using ServiceInterfaces;

    public class SampleService : ISampleService
    {
        public string GetCurrentDate()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}
