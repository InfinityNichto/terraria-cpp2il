using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000043 RID: 67
	[global::Cpp2ILInjected.Token(Token = "0x200005E")]
	public abstract class SafeHandleMinusOneIsInvalid : global::System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00014AFB File Offset: 0x00012CFB
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC6AF4", Offset = "0x1AC6AF4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected SafeHandleMinusOneIsInvalid(bool ownsHandle)
		{
			throw null;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00014AFE File Offset: 0x00012CFE
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC6B38", Offset = "0x1AC6B38", Length = "0x40")]
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
