using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000676")]
	public class SoundPlaySet
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003738")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3AC", Offset = "0x141E3AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundPlaySet()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007829")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int IntendedCooldown;

		[global::Cpp2ILInjected.Token(Token = "0x400782A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SoundType;

		[global::Cpp2ILInjected.Token(Token = "0x400782B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int SoundStyle;
	}
}
