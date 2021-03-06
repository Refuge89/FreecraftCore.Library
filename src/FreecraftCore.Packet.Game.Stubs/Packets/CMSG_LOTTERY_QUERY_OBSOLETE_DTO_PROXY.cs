using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_LOTTERY_QUERY_OBSOLETE)]
[WireDataContractAttribute]
public sealed class CMSG_LOTTERY_QUERY_OBSOLETE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_LOTTERY_QUERY_OBSOLETE_DTO_PROXY()
    {
    }
}