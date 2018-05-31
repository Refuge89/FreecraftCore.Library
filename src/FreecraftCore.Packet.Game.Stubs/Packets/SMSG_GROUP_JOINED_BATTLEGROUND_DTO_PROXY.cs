using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_GROUP_JOINED_BATTLEGROUND)]
[WireDataContractAttribute]
public sealed class SMSG_GROUP_JOINED_BATTLEGROUND_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_GROUP_JOINED_BATTLEGROUND_DTO_PROXY()
    {
    }
}