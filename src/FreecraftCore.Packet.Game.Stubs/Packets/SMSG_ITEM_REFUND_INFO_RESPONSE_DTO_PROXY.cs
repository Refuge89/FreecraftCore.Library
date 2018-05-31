using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_ITEM_REFUND_INFO_RESPONSE)]
[WireDataContractAttribute]
public sealed class SMSG_ITEM_REFUND_INFO_RESPONSE_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_ITEM_REFUND_INFO_RESPONSE_DTO_PROXY()
    {
    }
}