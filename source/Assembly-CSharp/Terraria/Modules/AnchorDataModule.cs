using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x020003A7 RID: 935
	[global::Cpp2ILInjected.Token(Token = "0x2000546")]
	public class AnchorDataModule
	{
		// Token: 0x06002E8A RID: 11914 RVA: 0x0002A509 File Offset: 0x00028709
		[global::Cpp2ILInjected.Token(Token = "0x60032E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x132EFD8", Offset = "0x132EFD8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AnchorDataModule(AnchorDataModule copyFrom = null)
		{
			throw null;
		}

		// Token: 0x04003238 RID: 12856
		[global::Cpp2ILInjected.Token(Token = "0x4003BD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AnchorData top;

		// Token: 0x04003239 RID: 12857
		[global::Cpp2ILInjected.Token(Token = "0x4003BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public AnchorData bottom;

		// Token: 0x0400323A RID: 12858
		[global::Cpp2ILInjected.Token(Token = "0x4003BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public AnchorData left;

		// Token: 0x0400323B RID: 12859
		[global::Cpp2ILInjected.Token(Token = "0x4003BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public AnchorData right;

		// Token: 0x0400323C RID: 12860
		[global::Cpp2ILInjected.Token(Token = "0x4003BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool wall;
	}
}
