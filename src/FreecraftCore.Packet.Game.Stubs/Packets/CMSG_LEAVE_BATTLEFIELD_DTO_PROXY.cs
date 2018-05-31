using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_LEAVE_BATTLEFIELD)]
[WireDataContractAttribute]
public sealed class CMSG_LEAVE_BATTLEFIELD_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_LEAVE_BATTLEFIELD_DTO_PROXY()
    {
    }
}