using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	public struct TileColorCache
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400374F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte Color;

		[global::Cpp2ILInjected.Token(Token = "0x4003750")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public bool FullBright;

		[global::Cpp2ILInjected.Token(Token = "0x4003751")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public bool Invisible;
	}
}
