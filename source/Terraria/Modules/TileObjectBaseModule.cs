using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x200054B")]
	public class TileObjectBaseModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13309A4", Offset = "0x13309A4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Direction", MemberParameters = new object[] { typeof(TileObjectDirection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_RandomStyleRange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_SpecificRandomStyles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_FlattenAnchors", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TileObjectBaseModule(TileObjectBaseModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int width;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int height;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Point16 origin;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public TileObjectDirection direction;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int randomRange;

		[global::Cpp2ILInjected.Token(Token = "0x4003BEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool flattenAnchors;

		[global::Cpp2ILInjected.Token(Token = "0x4003BEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int[] specificRandomStyles;
	}
}
