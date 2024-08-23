using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x0200020B RID: 523
	[global::Cpp2ILInjected.Token(Token = "0x20002FA")]
	public class LingerOption
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x0000611C File Offset: 0x0000431C
		[global::Cpp2ILInjected.Token(Token = "0x6001409")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32A40", Offset = "0x1E32A40", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Linger", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LingerOption(bool enable, int seconds)
		{
			throw null;
		}

		// Token: 0x17000460 RID: 1120
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0000611F File Offset: 0x0000431F
		[global::Cpp2ILInjected.Token(Token = "0x17000489")]
		public bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600140A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32A74", Offset = "0x1E32A74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x00006122 File Offset: 0x00004322
		[global::Cpp2ILInjected.Token(Token = "0x1700048A")]
		public int LingerTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600140B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32A80", Offset = "0x1E32A80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000C31 RID: 3121
		[global::Cpp2ILInjected.Token(Token = "0x400102A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool enabled;

		// Token: 0x04000C32 RID: 3122
		[global::Cpp2ILInjected.Token(Token = "0x400102B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int lingerTime;
	}
}
