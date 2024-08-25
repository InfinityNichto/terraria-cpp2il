using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E3")]
	public class PlayerDifficultyID
	{
		[global::Cpp2ILInjected.Token(Token = "0x600356D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C77E8", Offset = "0x13C77E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerDifficultyID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40068C7")]
		public const byte SoftCore = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40068C8")]
		public const byte MediumCore = 1;

		[global::Cpp2ILInjected.Token(Token = "0x40068C9")]
		public const byte Hardcore = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40068CA")]
		public const byte Creative = 3;
	}
}
