﻿using FreecraftCore.Serializer;

namespace FreecraftCore
{
	//TODO: Check mangos 1.12.1 for other possible LoginProof results. Also, we need to implement 1.12.1 result. Only have 3.3.5 at the moment.
	/// <summary>
	/// Contract for all proof results.
	/// </summary>
	[WireDataContract(WireDataContractAttribute.KeyType.Byte)] //the type information is sent as a byte
	[WireDataContractBaseType(0, typeof(LogonProofSuccess))] //0 in the stream means success
	[WireDataContractBaseType(4, typeof(LogonProofFailure))] //4 means token failure.
	public abstract class LogonProofResult
	{
		/// <summary>
		/// Indicates the result of the proof.
		/// </summary>
		public abstract AuthenticationResult Result { get; }

		protected LogonProofResult()
		{
			
		}
	}
}
