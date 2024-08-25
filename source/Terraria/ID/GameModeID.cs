using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005CA")]
	internal class GameModeID
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003549")]
		[global::Cpp2ILInjected.Address(RVA = "0x138E48C", Offset = "0x138E48C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameModeID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40049AC")]
		public const short Normal = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40049AD")]
		public const short Expert = 1;

		[global::Cpp2ILInjected.Token(Token = "0x40049AE")]
		public const short Master = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40049AF")]
		public const short Creative = 3;
	}
}
