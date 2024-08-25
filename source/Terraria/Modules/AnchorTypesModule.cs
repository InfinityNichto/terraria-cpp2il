using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000547")]
	public class AnchorTypesModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x132F8A0", Offset = "0x132F8A0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "SetupBaseObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorValidWalls", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AnchorTypesModule(AnchorTypesModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int[] tileValid;

		[global::Cpp2ILInjected.Token(Token = "0x4003BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int[] tileInvalid;

		[global::Cpp2ILInjected.Token(Token = "0x4003BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int[] tileAlternates;

		[global::Cpp2ILInjected.Token(Token = "0x4003BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int[] wallValid;
	}
}
