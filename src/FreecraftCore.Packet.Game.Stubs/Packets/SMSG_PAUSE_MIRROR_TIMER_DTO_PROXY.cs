using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_PAUSE_MIRROR_TIMER)]
[WireDataContractAttribute]
public sealed class SMSG_PAUSE_MIRROR_TIMER_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_PAUSE_MIRROR_TIMER_DTO_PROXY()
    {
    }
}