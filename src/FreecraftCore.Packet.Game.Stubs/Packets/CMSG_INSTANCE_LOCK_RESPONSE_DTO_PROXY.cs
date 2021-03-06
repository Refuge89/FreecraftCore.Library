using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_INSTANCE_LOCK_RESPONSE)]
[WireDataContractAttribute]
public sealed class CMSG_INSTANCE_LOCK_RESPONSE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_INSTANCE_LOCK_RESPONSE_DTO_PROXY()
    {
    }
}