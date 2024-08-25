using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000648")]
	public struct PlayerMovementAccsCache
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x141CFD4", Offset = "0x141CFD4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_BlockExtraJumps", ReturnType = typeof(bool))]
		public void CopyFrom(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60036DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D060", Offset = "0x141D060", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PasteInto(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40077E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _readyToPaste;

		[global::Cpp2ILInjected.Token(Token = "0x40077E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		private bool _mountPreventedFlight;

		[global::Cpp2ILInjected.Token(Token = "0x40077E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private bool _mountPreventedExtraJumps;

		[global::Cpp2ILInjected.Token(Token = "0x40077E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int rocketTime;

		[global::Cpp2ILInjected.Token(Token = "0x40077E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float wingTime;

		[global::Cpp2ILInjected.Token(Token = "0x40077E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int rocketDelay;

		[global::Cpp2ILInjected.Token(Token = "0x40077E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int rocketDelay2;

		[global::Cpp2ILInjected.Token(Token = "0x40077E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool jumpAgainCloud;

		[global::Cpp2ILInjected.Token(Token = "0x40077E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
		private bool jumpAgainSandstorm;

		[global::Cpp2ILInjected.Token(Token = "0x40077EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
		private bool jumpAgainBlizzard;

		[global::Cpp2ILInjected.Token(Token = "0x40077EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17")]
		private bool jumpAgainFart;

		[global::Cpp2ILInjected.Token(Token = "0x40077EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool jumpAgainSail;

		[global::Cpp2ILInjected.Token(Token = "0x40077ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool jumpAgainUnicorn;
	}
}
