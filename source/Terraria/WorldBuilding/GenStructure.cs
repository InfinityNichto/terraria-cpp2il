using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000364 RID: 868
	[global::Cpp2ILInjected.Token(Token = "0x20004E2")]
	public abstract class GenStructure : GenBase
	{
		// Token: 0x06002C50 RID: 11344
		[global::Cpp2ILInjected.Token(Token = "0x6003056")]
		public abstract bool Place(Point origin, StructureMap structures);

		// Token: 0x06002C51 RID: 11345 RVA: 0x00029F18 File Offset: 0x00028118
		[global::Cpp2ILInjected.Token(Token = "0x6003057")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FA97C", Offset = "0x12FA97C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenStructure()
		{
			throw null;
		}
	}
}
