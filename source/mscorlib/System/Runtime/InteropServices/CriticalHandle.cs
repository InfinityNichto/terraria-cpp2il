using System;
using System.Runtime.ConstrainedExecution;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A3 RID: 931
	[global::Cpp2ILInjected.Token(Token = "0x200044D")]
	public abstract class CriticalHandle : global::System.Runtime.ConstrainedExecution.CriticalFinalizerObject, global::System.IDisposable
	{
		// Token: 0x06001F39 RID: 7993 RVA: 0x00019CA3 File Offset: 0x00017EA3
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x600217A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B704A4", Offset = "0x1B704A4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.CriticalHandleMinusOneIsInvalid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CriticalHandle(global::System.IntPtr invalidHandleValue)
		{
			throw null;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00019CA6 File Offset: 0x00017EA6
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600217B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B704D8", Offset = "0x1B704D8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00019CA9 File Offset: 0x00017EA9
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600217C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70578", Offset = "0x1B70578", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CriticalHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Cleanup()
		{
			throw null;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00019CAC File Offset: 0x00017EAC
		[global::Cpp2ILInjected.Token(Token = "0x600217D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70664", Offset = "0x1B70664", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void FireCustomerDebugProbe()
		{
			throw null;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00019CAF File Offset: 0x00017EAF
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x600217E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7066C", Offset = "0x1B7066C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void SetHandle(global::System.IntPtr handle)
		{
			throw null;
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00019CB2 File Offset: 0x00017EB2
		[global::Cpp2ILInjected.Token(Token = "0x17000458")]
		public bool IsClosed
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x600217F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B70674", Offset = "0x1B70674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001F3F RID: 7999
		[global::Cpp2ILInjected.Token(Token = "0x17000459")]
		public abstract bool IsInvalid
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6002180")]
			get;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00019CB5 File Offset: 0x00017EB5
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7067C", Offset = "0x1B7067C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SSPIHandleCache", Member = "CacheCredential", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00019CB8 File Offset: 0x00017EB8
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7068C", Offset = "0x1B7068C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CriticalHandle), Member = "Cleanup", ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001F42 RID: 8002
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6002183")]
		protected abstract bool ReleaseHandle();

		// Token: 0x04000F86 RID: 3974
		[global::Cpp2ILInjected.Token(Token = "0x400127B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected global::System.IntPtr handle;

		// Token: 0x04000F87 RID: 3975
		[global::Cpp2ILInjected.Token(Token = "0x400127C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _isClosed;
	}
}
