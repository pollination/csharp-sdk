
namespace PollinationSDK
{
    public interface IPollinationObject
    {
        string ToString(bool detailed);
        string ToJson(bool indented = false);
        OpenAPIGenBaseModel Duplicate();
    } 

    
}

