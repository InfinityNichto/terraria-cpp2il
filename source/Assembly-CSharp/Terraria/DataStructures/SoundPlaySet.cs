using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000475 RID: 1141
	[global::Cpp2ILInjected.Token(Token = "0x2000676")]
	public class SoundPlaySet
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x0002AF4D File Offset: 0x0002914D
		[global::Cpp2ILInjected.Token(Token = "0x6003738")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3AC", Offset = "0x141E3AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundPlaySet()
		{
			throw null;
		}

		// Token: 0x04006430 RID: 25648
		[global::Cpp2ILInjected.Token(Token = "0x4007829")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int IntendedCooldown;

		// Token: 0x04006431 RID: 25649
		[global::Cpp2ILInjected.Token(Token = "0x400782A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SoundType;

		// Token: 0x04006432 RID: 25650
		[global::Cpp2ILInjected.Token(Token = "0x400782B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int SoundStyle;
	}
}
