using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.UI
{
	// Token: 0x020004C8 RID: 1224
	[global::Cpp2ILInjected.Token(Token = "0x2000714")]
	public class LegacyGameInterfaceLayer : GameInterfaceLayer
	{
		// Token: 0x060035C3 RID: 13763 RVA: 0x0002B9A6 File Offset: 0x00029BA6
		[global::Cpp2ILInjected.Token(Token = "0x6003C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C7CC", Offset = "0x148C7CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetupDrawInterfaceLayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameInterfaceLayer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InterfaceScaleType)
		}, ReturnType = typeof(void))]
		public LegacyGameInterfaceLayer(string name, GameInterfaceDrawMethod drawMethod, InterfaceScaleType scaleType = InterfaceScaleType.Game)
		{
			throw null;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0002B9A9 File Offset: 0x00029BA9
		[global::Cpp2ILInjected.Token(Token = "0x6003C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x148C7F8", Offset = "0x148C7F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override bool DrawSelf()
		{
			throw null;
		}

		// Token: 0x0400669C RID: 26268
		[global::Cpp2ILInjected.Token(Token = "0x4007B63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private GameInterfaceDrawMethod _drawMethod;
	}
}
