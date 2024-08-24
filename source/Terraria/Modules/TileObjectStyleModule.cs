using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x020003AF RID: 943
	[global::Cpp2ILInjected.Token(Token = "0x200054E")]
	public class TileObjectStyleModule
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x0002A521 File Offset: 0x00028721
		[global::Cpp2ILInjected.Token(Token = "0x60032F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1331BD0", Offset = "0x1331BD0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Style", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleWrapLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleWrapLimitVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_styleLineSkipVisualOverride", MemberParameters = new object[] { typeof(int?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleLineSkip", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_StyleMultiplier", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileObjectStyleModule(TileObjectStyleModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x0400325A RID: 12890
		[global::Cpp2ILInjected.Token(Token = "0x4003BF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int style;

		// Token: 0x0400325B RID: 12891
		[global::Cpp2ILInjected.Token(Token = "0x4003BFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public bool horizontal;

		// Token: 0x0400325C RID: 12892
		[global::Cpp2ILInjected.Token(Token = "0x4003BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int styleWrapLimit;

		// Token: 0x0400325D RID: 12893
		[global::Cpp2ILInjected.Token(Token = "0x4003BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int styleMultiplier;

		// Token: 0x0400325E RID: 12894
		[global::Cpp2ILInjected.Token(Token = "0x4003BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int styleLineSkip;

		// Token: 0x0400325F RID: 12895
		[global::Cpp2ILInjected.Token(Token = "0x4003BFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int? styleWrapLimitVisualOverride;

		// Token: 0x04003260 RID: 12896
		[global::Cpp2ILInjected.Token(Token = "0x4003BFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int? styleLineSkipVisualoverride;
	}
}
