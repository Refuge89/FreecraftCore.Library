﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FreecraftCore
{
	/// <summary>
	/// Contract for an authentication user account repository.
	/// For <see cref="Account"/>s.
	/// </summary>
	public interface IAuthenticationUserAccountRepository : IDisposable
	{
		/// <summary>
		/// Checks if an account is in the database with the provided
		/// <see cref="accountName"/>.
		/// </summary>
		/// <param name="accountName">The account name to check for.</param>
		/// <returns>Indicates if an account is in the database with the provided account name.</returns>
		Task<bool> DoesAccountExists(string accountName);
	}
}