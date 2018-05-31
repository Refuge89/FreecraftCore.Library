using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_CHAT_PLAYER_AMBIGUOUS)]
[WireDataContractAttribute]
public sealed class SMSG_CHAT_PLAYER_AMBIGUOUS_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_CHAT_PLAYER_AMBIGUOUS_DTO_PROXY()
    {
    }
}