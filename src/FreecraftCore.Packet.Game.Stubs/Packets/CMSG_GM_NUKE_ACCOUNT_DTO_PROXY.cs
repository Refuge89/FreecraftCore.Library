using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.CMSG_GM_NUKE_ACCOUNT)]
[WireDataContractAttribute]
public sealed class CMSG_GM_NUKE_ACCOUNT_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public CMSG_GM_NUKE_ACCOUNT_DTO_PROXY()
    {
    }
}