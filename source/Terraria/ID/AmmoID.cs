using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x2000594")]
	public static class AmmoID
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60034C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1381698", Offset = "0x1381698", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static AmmoID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40041A2")]
		public static int None;

		[global::Cpp2ILInjected.Token(Token = "0x40041A3")]
		public static int Gel;

		[global::Cpp2ILInjected.Token(Token = "0x40041A4")]
		public static int Arrow;

		[global::Cpp2ILInjected.Token(Token = "0x40041A5")]
		public static int Coin;

		[global::Cpp2ILInjected.Token(Token = "0x40041A6")]
		public static int FallenStar;

		[global::Cpp2ILInjected.Token(Token = "0x40041A7")]
		public static int Bullet;

		[global::Cpp2ILInjected.Token(Token = "0x40041A8")]
		public static int Sand;

		[global::Cpp2ILInjected.Token(Token = "0x40041A9")]
		public static int Dart;

		[global::Cpp2ILInjected.Token(Token = "0x40041AA")]
		public static int Rocket;

		[global::Cpp2ILInjected.Token(Token = "0x40041AB")]
		public static int Solution;

		[global::Cpp2ILInjected.Token(Token = "0x40041AC")]
		public static int Flare;

		[global::Cpp2ILInjected.Token(Token = "0x40041AD")]
		public static int Snowball;

		[global::Cpp2ILInjected.Token(Token = "0x40041AE")]
		public static int StyngerBolt;

		[global::Cpp2ILInjected.Token(Token = "0x40041AF")]
		public static int CandyCorn;

		[global::Cpp2ILInjected.Token(Token = "0x40041B0")]
		public static int JackOLantern;

		[global::Cpp2ILInjected.Token(Token = "0x40041B1")]
		public static int Stake;

		[global::Cpp2ILInjected.Token(Token = "0x40041B2")]
		public static int NailFriendly;

		[global::Cpp2ILInjected.Token(Token = "0x2000595")]
		public class Sets
		{
			[global::Cpp2ILInjected.Token(Token = "0x60034CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x138170C", Offset = "0x138170C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60034CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1381714", Offset = "0x1381714", Length = "0x664")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			static Sets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40041B3")]
			public static Dictionary<int, Dictionary<int, int>> SpecificLauncherAmmoProjectileMatches;
		}
	}
}
