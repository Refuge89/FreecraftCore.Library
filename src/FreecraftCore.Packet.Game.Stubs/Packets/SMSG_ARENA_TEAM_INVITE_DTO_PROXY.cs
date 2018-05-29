using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_ARENA_TEAM_INVITE)]
[WireDataContractAttribute]
public sealed class SMSG_ARENA_TEAM_INVITE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
{
    [ReadToEndAttribute]
    [WireMemberAttribute(1)]
    private byte[] _Data;
    public byte[] Data
    {
        get
        {
            return Data;
        }

        set
        {
            Data = value;
        }
    }

    public SMSG_ARENA_TEAM_INVITE_DTO_PROXY()
    {
    }
}