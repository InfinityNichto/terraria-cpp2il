using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x020003AC RID: 940
	[global::Cpp2ILInjected.Token(Token = "0x200054B")]
	public class TileObjectBaseModule
	{
		// Token: 0x06002E8F RID: 11919 RVA: 0x0002A518 File Offset: 0x00028718
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

		// Token: 0x04003246 RID: 12870
		[global::Cpp2ILInjected.Token(Token = "0x4003BE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int width;

		// Token: 0x04003247 RID: 12871
		[global::Cpp2ILInjected.Token(Token = "0x4003BE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int height;

		// Token: 0x04003248 RID: 12872
		[global::Cpp2ILInjected.Token(Token = "0x4003BE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Point16 origin;

		// Token: 0x04003249 RID: 12873
		[global::Cpp2ILInjected.Token(Token = "0x4003BE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public TileObjectDirection direction;

		// Token: 0x0400324A RID: 12874
		[global::Cpp2ILInjected.Token(Token = "0x4003BE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int randomRange;

		// Token: 0x0400324B RID: 12875
		[global::Cpp2ILInjected.Token(Token = "0x4003BEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool flattenAnchors;

		// Token: 0x0400324C RID: 12876
		[global::Cpp2ILInjected.Token(Token = "0x4003BEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int[] specificRandomStyles;
	}
}
