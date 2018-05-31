using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_IGNORE_DIMINISHING_RETURNS_CHEAT)]
[WireDataContractAttribute]
public sealed class SMSG_IGNORE_DIMINISHING_RETURNS_CHEAT_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_IGNORE_DIMINISHING_RETURNS_CHEAT_DTO_PROXY()
    {
    }
}