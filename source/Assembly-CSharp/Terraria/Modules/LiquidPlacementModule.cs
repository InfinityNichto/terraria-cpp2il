using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Enums;

namespace Terraria.Modules
{
	// Token: 0x020003AA RID: 938
	[global::Cpp2ILInjected.Token(Token = "0x2000549")]
	public class LiquidPlacementModule
	{
		// Token: 0x06002E8D RID: 11917 RVA: 0x0002A512 File Offset: 0x00028712
		[global::Cpp2ILInjected.Token(Token = "0x60032EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13302A8", Offset = "0x13302A8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LiquidPlacementModule(LiquidPlacementModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x04003243 RID: 12867
		[global::Cpp2ILInjected.Token(Token = "0x4003BE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public LiquidPlacement water;

		// Token: 0x04003244 RID: 12868
		[global::Cpp2ILInjected.Token(Token = "0x4003BE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public LiquidPlacement lava;
	}
}
