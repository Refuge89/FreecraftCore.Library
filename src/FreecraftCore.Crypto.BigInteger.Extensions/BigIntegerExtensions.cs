﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Org.BouncyCastle.Math;

namespace FreecraftCore.Crypto
{
	public static class BigIntegerExtensions
	{
		/// <summary>
		/// Header for Array types.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ArrayHeader
		{
			public UIntPtr type;
			public UIntPtr length;
		}

		//From JackPoz's 3.3.5 bot: https://github.com/jackpoz/BotFarm
		/// <summary>
		/// Returns <see cref="BigInteger"/> in byteform but truncates
		/// the final field if it's 0.
		/// (The MSB)
		/// </summary>
		/// <param name="bigInt"></param>
		/// <returns></returns>
		public static unsafe byte[] ToCleanByteArray(this BigInteger bigInt)
		{
			byte[] array = bigInt.ToByteArray();
			if (array.Length == 0 || array[array.Length - 1] != 0)
				return array;

			//Remove following 0 from end (clean)
			fixed (void* bytePtr = &array[0])
			{
				//Grabs the header for the array
				ArrayHeader* arrayHeader = (ArrayHeader*)bytePtr - 1;

				//Hacks the array length to be one less than the original size.
				arrayHeader->length = (UIntPtr)(array.Length - 1);
			}

			return array;
		}
		
		//Bouncy has this implemented
		/*public static BigInteger ModPow(this BigInteger number, BigInteger exp, BigInteger modulus)
		{
			return BigInteger.ModPow(number, exp, modulus);
		}*/

		//From Jackpoz's 3.3.5 bot
		/// <summary>
		/// places a non-negative value (0) at the MSB, then converts to a BigInteger.
		/// This ensures a non-negative value without changing the binary representation.
		/// </summary>
		public static BigInteger ToBigInteger(this byte[] array, BigIntegerSign sign = BigIntegerSign.Positive) //WoW expects positive BigInteger
		{
			//This can't be hacked like with ToCleanArray
			byte[] temp;
			if ((array[array.Length - 1] & 0x80) == 0x80)
			{
				temp = new byte[array.Length + 1];
				temp[array.Length] = 0;

				//Copies the contents of the array into temp
				//There is no way to memory hack this
				Array.Copy(array, temp, array.Length);
			}
			else
				temp = array;

			//Properly signs based on the provided optional
			//WoW expects mostly unsigned but Bouncy will default to including negatives
			return sign == BigIntegerSign.Default ? new BigInteger(temp) : new BigInteger((int) sign, temp);
		}
	}
}
