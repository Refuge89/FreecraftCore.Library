using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_PAGE_TEXT_QUERY)]
[WireDataContractAttribute]
public sealed class CMSG_PAGE_TEXT_QUERY_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
{
    [ReadToEndAttribute]
    [WireMemberAttribute(1)]
    private byte[] _Data;
    public byte[] Data
    {
        get
        {
            return _Data;
        }

        set
        {
            _Data = value;
        }
    }

    public CMSG_PAGE_TEXT_QUERY_DTO_PROXY()
    {
    }
}