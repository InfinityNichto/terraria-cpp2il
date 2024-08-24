using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x020003AE RID: 942
	[global::Cpp2ILInjected.Token(Token = "0x200054D")]
	public class TileObjectDrawModule
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x0002A51E File Offset: 0x0002871E
		[global::Cpp2ILInjected.Token(Token = "0x60032F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1331774", Offset = "0x1331774", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawXOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipVertical", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileObjectDrawModule(TileObjectDrawModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x04003255 RID: 12885
		[global::Cpp2ILInjected.Token(Token = "0x4003BF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int xOffset;

		// Token: 0x04003256 RID: 12886
		[global::Cpp2ILInjected.Token(Token = "0x4003BF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int yOffset;

		// Token: 0x04003257 RID: 12887
		[global::Cpp2ILInjected.Token(Token = "0x4003BF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool flipHorizontal;

		// Token: 0x04003258 RID: 12888
		[global::Cpp2ILInjected.Token(Token = "0x4003BF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool flipVertical;

		// Token: 0x04003259 RID: 12889
		[global::Cpp2ILInjected.Token(Token = "0x4003BF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int stepDown;
	}
}
