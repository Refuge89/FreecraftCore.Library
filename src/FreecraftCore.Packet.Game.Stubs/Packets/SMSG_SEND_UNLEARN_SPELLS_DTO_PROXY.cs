using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_SEND_UNLEARN_SPELLS)]
[WireDataContractAttribute]
public sealed class SMSG_SEND_UNLEARN_SPELLS_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_SEND_UNLEARN_SPELLS_DTO_PROXY()
    {
    }
}