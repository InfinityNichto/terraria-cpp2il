using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x020003A8 RID: 936
	[global::Cpp2ILInjected.Token(Token = "0x2000547")]
	public class AnchorTypesModule
	{
		// Token: 0x06002E8B RID: 11915 RVA: 0x0002A50C File Offset: 0x0002870C
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

		// Token: 0x0400323D RID: 12861
		[global::Cpp2ILInjected.Token(Token = "0x4003BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int[] tileValid;

		// Token: 0x0400323E RID: 12862
		[global::Cpp2ILInjected.Token(Token = "0x4003BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int[] tileInvalid;

		// Token: 0x0400323F RID: 12863
		[global::Cpp2ILInjected.Token(Token = "0x4003BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int[] tileAlternates;

		// Token: 0x04003240 RID: 12864
		[global::Cpp2ILInjected.Token(Token = "0x4003BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int[] wallValid;
	}
}
