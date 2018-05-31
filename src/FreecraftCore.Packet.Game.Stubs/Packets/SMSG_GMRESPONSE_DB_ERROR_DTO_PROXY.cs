using FreecraftCore;
using FreecraftCore.Serializer;

[GamePayloadOperationCodeAttribute(NetworkOperationCode.SMSG_GMRESPONSE_DB_ERROR)]
[WireDataContractAttribute]
public sealed class SMSG_GMRESPONSE_DB_ERROR_DTO_PROXY : GamePacketPayload, IUnimplementedGamePacketPayload
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

    public SMSG_GMRESPONSE_DB_ERROR_DTO_PROXY()
    {
    }
}