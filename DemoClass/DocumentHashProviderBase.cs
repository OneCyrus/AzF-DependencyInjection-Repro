namespace DemoClass
{
    public abstract class DocumentHashProviderBase
        : IDocumentHashProvider
    {
        internal DocumentHashProviderBase(HashFormat format)
        {
            Format = format;
        }

        public abstract string Name { get; }

        public HashFormat Format { get; }
    }
}
