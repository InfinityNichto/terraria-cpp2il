using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	// Token: 0x02000378 RID: 888
	[global::Cpp2ILInjected.Token(Token = "0x2000506")]
	public sealed class OldAttribute : Attribute
	{
		// Token: 0x06002CE3 RID: 11491 RVA: 0x0002A0CE File Offset: 0x000282CE
		[global::Cpp2ILInjected.Token(Token = "0x6003118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303398", Offset = "0x1303398", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OldAttribute()
		{
			throw null;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x0002A0D1 File Offset: 0x000282D1
		[global::Cpp2ILInjected.Token(Token = "0x6003119")]
		[global::Cpp2ILInjected.Address(RVA = "0x13033EC", Offset = "0x13033EC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OldAttribute(string message)
		{
			throw null;
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x0002A0D4 File Offset: 0x000282D4
		[global::Cpp2ILInjected.Token(Token = "0x17000624")]
		public string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x600311A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303414", Offset = "0x1303414", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04003196 RID: 12694
		[global::Cpp2ILInjected.Token(Token = "0x4003AEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string message;
	}
}
