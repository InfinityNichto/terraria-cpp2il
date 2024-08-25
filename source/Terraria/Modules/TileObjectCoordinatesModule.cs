using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x200054C")]
	public class TileObjectCoordinatesModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x133115C", Offset = "0x133115C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinateWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinatePadding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawStyleOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TileObjectCoordinatesModule(TileObjectCoordinatesModule copyFrom = null, int[] drawHeight = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int width;

		[global::Cpp2ILInjected.Token(Token = "0x4003BED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int[] heights;

		[global::Cpp2ILInjected.Token(Token = "0x4003BEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int padding;

		[global::Cpp2ILInjected.Token(Token = "0x4003BEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Point16 paddingFix;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int styleWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int styleHeight;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool calculated;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int drawStyleOffset;
	}
}
