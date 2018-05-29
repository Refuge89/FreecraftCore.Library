using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_OPEN_LFG_DUNGEON_FINDER)]
[WireDataContractAttribute]
public sealed class SMSG_OPEN_LFG_DUNGEON_FINDER_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_OPEN_LFG_DUNGEON_FINDER_DTO_PROXY()
    {
    }
}