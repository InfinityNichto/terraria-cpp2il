using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002DA RID: 730
	[global::Cpp2ILInjected.Token(Token = "0x20003D9")]
	internal static class CompModSwitches
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00007097 File Offset: 0x00005297
		[global::Cpp2ILInjected.Token(Token = "0x170005F5")]
		public static BooleanSwitch CommonDesignerServices
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E61EC4", Offset = "0x1E61EC4", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BooleanSwitch), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0000709A File Offset: 0x0000529A
		[global::Cpp2ILInjected.Token(Token = "0x170005F6")]
		public static TraceSwitch EventLog
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E61F90", Offset = "0x1E61F90", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000ED8 RID: 3800
		[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
		private static BooleanSwitch commonDesignerServices;

		// Token: 0x04000ED9 RID: 3801
		[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
		private static TraceSwitch eventLog;
	}
}
