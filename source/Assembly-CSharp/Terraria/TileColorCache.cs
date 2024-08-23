using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	// Token: 0x02000349 RID: 841
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	public struct TileColorCache
	{
		// Token: 0x060027FD RID: 10237 RVA: 0x0002922E File Offset: 0x0002742E
		[global::Cpp2ILInjected.Token(Token = "0x6002AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175510", Offset = "0x1175510", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "UseBlockColors", MemberParameters = new object[] { typeof(TileColorCache) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_sTileHeader", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetSTileHeader", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void ApplyToBlock(Tile tile)
		{
			throw null;
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00029231 File Offset: 0x00027431
		[global::Cpp2ILInjected.Token(Token = "0x6002AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1175584", Offset = "0x1175584", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tile), Member = "UseWallColors", MemberParameters = new object[] { typeof(TileColorCache) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "wallColor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "fullbrightWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "invisibleWall", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void ApplyToWall(Tile tile)
		{
			throw null;
		}

		// Token: 0x04002F6F RID: 12143
		[global::Cpp2ILInjected.Token(Token = "0x400374F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte Color;

		// Token: 0x04002F70 RID: 12144
		[global::Cpp2ILInjected.Token(Token = "0x4003750")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public bool FullBright;

		// Token: 0x04002F71 RID: 12145
		[global::Cpp2ILInjected.Token(Token = "0x4003751")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public bool Invisible;
	}
}
