namespace DemoClass
{
    public class MD5DocumentHashProvider
        : DocumentHashProviderBase
    {
        public MD5DocumentHashProvider()
            : this(HashFormat.Base64)
        {
        }

        public MD5DocumentHashProvider(HashFormat format)
            : base(format)
        {
        }

        public override string Name => "md5Hash";
    }
}
