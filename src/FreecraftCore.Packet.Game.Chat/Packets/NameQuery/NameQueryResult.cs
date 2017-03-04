﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreecraftCore.API.Common;
using FreecraftCore.Serializer;
using JetBrains.Annotations;

namespace FreecraftCore.Packet
{
	/// <summary>
	/// Name query result base object.
	/// </summary>
	[WireDataContractBaseType(1, typeof(UnknownNameQueryResult))]
	[WireDataContractBaseType(1, typeof(KnownNameQueryResult))]
	[WireDataContract(WireDataContractAttribute.KeyType.Byte)]
	public abstract class NameQueryResult
	{
		/// <summary>
		/// The GUID requested in the name query request.
		/// </summary>
		[WireMember(1)]
		public PackedGuid RequestedGuid { get; private set; }

		/// <summary>
		/// Indicates if the query was successful.
		/// </summary>
		public abstract bool Successful { get; }

		/// <summary>
		/// Represents the name of the object IF it was successful.
		/// If <see cref="Successful"/> is false than <see cref="Name"/> will be null.
		/// </summary>
		[CanBeNull]
		public abstract string Name { get; }

		protected NameQueryResult()
		{
			//serializer ctor
		}
	}
}
