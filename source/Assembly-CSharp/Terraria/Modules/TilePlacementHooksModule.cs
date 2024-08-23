using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x020003B1 RID: 945
	[global::Cpp2ILInjected.Token(Token = "0x2000550")]
	public class TilePlacementHooksModule
	{
		// Token: 0x06002E94 RID: 11924 RVA: 0x0002A527 File Offset: 0x00028727
		[global::Cpp2ILInjected.Token(Token = "0x60032F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1330500", Offset = "0x1330500", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TilePlacementHooksModule(TilePlacementHooksModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x04003262 RID: 12898
		[global::Cpp2ILInjected.Token(Token = "0x4003C01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public PlacementHook check;

		// Token: 0x04003263 RID: 12899
		[global::Cpp2ILInjected.Token(Token = "0x4003C02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public PlacementHook postPlaceEveryone;

		// Token: 0x04003264 RID: 12900
		[global::Cpp2ILInjected.Token(Token = "0x4003C03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public PlacementHook postPlaceMyPlayer;

		// Token: 0x04003265 RID: 12901
		[global::Cpp2ILInjected.Token(Token = "0x4003C04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public PlacementHook placeOverride;
	}
}
