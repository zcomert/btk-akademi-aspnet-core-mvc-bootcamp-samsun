namespace Entities.RequestParameters
{
    public class ProductRequestParameters
        : RequestParameters
    {
        // Auto-implemented property
        public uint MinPrice { get; set; } = uint.MinValue;
        public uint MaxPrice { get; set; } = uint.MaxValue;
        public bool IsValidPrice => MaxPrice > MinPrice;

    }
}
