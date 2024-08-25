using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005CF")]
	public static class InvasionID
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600354E")]
		[global::Cpp2ILInjected.Address(RVA = "0x138E700", Offset = "0x138E700", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static InvasionID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4004DF8")]
		public const short CachedInvasions = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4004DF9")]
		public const short CachedFrostMoon = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFA")]
		public const short CachedPumpkinMoon = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFB")]
		public const short CachedOldOnesArmy = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFC")]
		public const short None = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFD")]
		public const short GoblinArmy = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFE")]
		public const short SnowLegion = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4004DFF")]
		public const short PirateInvasion = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4004E00")]
		public const short MartianMadness = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4004E01")]
		public static readonly short Count;
	}
}
