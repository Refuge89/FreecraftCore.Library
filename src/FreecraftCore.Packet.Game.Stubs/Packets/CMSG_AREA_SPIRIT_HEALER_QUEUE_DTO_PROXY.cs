using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_AREA_SPIRIT_HEALER_QUEUE)]
[WireDataContractAttribute]
public sealed class CMSG_AREA_SPIRIT_HEALER_QUEUE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_AREA_SPIRIT_HEALER_QUEUE_DTO_PROXY()
    {
    }
}