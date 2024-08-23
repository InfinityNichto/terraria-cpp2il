using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000385 RID: 901
	[global::Cpp2ILInjected.Token(Token = "0x200042F")]
	public readonly struct HandleRef
	{
		// Token: 0x06001F0B RID: 7947 RVA: 0x00019C28 File Offset: 0x00017E28
		[global::Cpp2ILInjected.Token(Token = "0x600214C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FA08", Offset = "0x1B6FA08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = "Microsoft.Win32.SafeHandles.SafeProcessHandle")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessWaitHandle", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Win32.SafeHandles.SafeProcessHandle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public HandleRef(object wrapper, global::System.IntPtr handle)
		{
			throw null;
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001F0C RID: 7948 RVA: 0x00019C2B File Offset: 0x00017E2B
		[global::Cpp2ILInjected.Token(Token = "0x17000456")]
		public global::System.IntPtr Handle
		{
			[global::Cpp2ILInjected.Token(Token = "0x600214D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6FA10", Offset = "0x1B6FA10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000EFB RID: 3835
		[global::Cpp2ILInjected.Token(Token = "0x40011F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _wrapper;

		// Token: 0x04000EFC RID: 3836
		[global::Cpp2ILInjected.Token(Token = "0x40011F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly global::System.IntPtr _handle;
	}
}
