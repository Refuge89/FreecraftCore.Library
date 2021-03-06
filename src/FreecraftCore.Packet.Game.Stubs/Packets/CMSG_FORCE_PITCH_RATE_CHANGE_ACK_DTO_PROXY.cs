using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_FORCE_PITCH_RATE_CHANGE_ACK)]
[WireDataContractAttribute]
public sealed class CMSG_FORCE_PITCH_RATE_CHANGE_ACK_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_FORCE_PITCH_RATE_CHANGE_ACK_DTO_PROXY()
    {
    }
}