using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000044 RID: 68
	[global::Cpp2ILInjected.Token(Token = "0x200005F")]
	public abstract class CriticalHandleMinusOneIsInvalid : global::System.Runtime.InteropServices.CriticalHandle
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00014B01 File Offset: 0x00012D01
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6B78", Offset = "0x1AC6B78", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeCredentialReference", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.CriticalHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		protected CriticalHandleMinusOneIsInvalid()
		{
			throw null;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00014B04 File Offset: 0x00012D04
		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000224")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6BB4", Offset = "0x1AC6BB4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}
	}
}
