using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000456 RID: 1110
	[global::Cpp2ILInjected.Token(Token = "0x2000652")]
	public abstract class AEntitySource_Tile : IEntitySource
	{
		// Token: 0x060031D3 RID: 12755 RVA: 0x0002AEAB File Offset: 0x000290AB
		[global::Cpp2ILInjected.Token(Token = "0x60036F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D46C", Offset = "0x141D46C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public AEntitySource_Tile(int tileCoordsX, int tileCoordsY)
		{
			throw null;
		}

		// Token: 0x04006412 RID: 25618
		[global::Cpp2ILInjected.Token(Token = "0x4007802")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Point TileCoords;
	}
}
