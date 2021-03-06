﻿using FreecraftCore.Serializer;

namespace FreecraftCore
{
	/// <summary>
	/// Sent to the connecting user before the character list.
	/// Sent with <see cref="NetworkOperationCode.SMSG_ADDON_INFO"/>.
	/// </summary>
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_ADDON_INFO)]
	public sealed class AddonInfoEvent : GamePacketPayload
	{
		public override bool isValid => true;

		[ReadToEnd]
		[WireMember(1)]
		public byte[] Data { get; }

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		protected AddonInfoEvent()
		{
			
		}
	}
}
