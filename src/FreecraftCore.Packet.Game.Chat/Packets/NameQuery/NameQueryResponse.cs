﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreecraftCore.API.Common;
using FreecraftCore.Packet.Common;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore.Packet
{
	[WireDataContract]
	[GamePayloadOperationCode(NetworkOperationCode.SMSG_NAME_QUERY_RESPONSE)]
	[ProtocolGrouping(ProtocolCode.Game)] //TODO: Change this protocol to something more specific
	public class NameQueryResponse : GamePacketPayload
	{
		/// <inheritdoc />
		public override bool isValid { get; } = true;

		[WireMember(1)]
		public ObjectGuid TargetGuid { get; private set; }

		public NameQueryResponse([NotNull] ObjectGuid targetGuid)
		{
			if (targetGuid == null)
				throw new ArgumentNullException(nameof(targetGuid));

			TargetGuid = targetGuid;
		}

		protected NameQueryResponse()
		{
			//serializer ctor
		}
	}
}
