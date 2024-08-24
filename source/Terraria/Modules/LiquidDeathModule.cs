using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Modules
{
	// Token: 0x020003A9 RID: 937
	[global::Cpp2ILInjected.Token(Token = "0x2000548")]
	public class LiquidDeathModule
	{
		// Token: 0x06002E8C RID: 11916 RVA: 0x0002A50F File Offset: 0x0002870F
		[global::Cpp2ILInjected.Token(Token = "0x60032EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x133001C", Offset = "0x133001C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LiquidDeathModule(LiquidDeathModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x04003241 RID: 12865
		[global::Cpp2ILInjected.Token(Token = "0x4003BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool water;

		// Token: 0x04003242 RID: 12866
		[global::Cpp2ILInjected.Token(Token = "0x4003BE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		public bool lava;
	}
}
