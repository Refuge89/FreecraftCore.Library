using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_DEL_VOICE_IGNORE)]
[WireDataContractAttribute]
public sealed class CMSG_DEL_VOICE_IGNORE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_DEL_VOICE_IGNORE_DTO_PROXY()
    {
    }
}