using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_CHANGE_PERSONAL_ARENA_RATING)]
[WireDataContractAttribute]
public sealed class CMSG_CHANGE_PERSONAL_ARENA_RATING_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_CHANGE_PERSONAL_ARENA_RATING_DTO_PROXY()
    {
    }
}