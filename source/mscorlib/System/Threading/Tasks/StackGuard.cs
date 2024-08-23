using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001BE RID: 446
	[global::Cpp2ILInjected.Token(Token = "0x200023C")]
	internal class StackGuard
	{
		// Token: 0x06001245 RID: 4677 RVA: 0x00017855 File Offset: 0x00015A55
		[global::Cpp2ILInjected.Token(Token = "0x60013EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC934", Offset = "0x1CAC934", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "TryEnsureSufficientExecutionStack", ReturnType = typeof(bool))]
		internal bool TryBeginInliningScope()
		{
			throw null;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00017858 File Offset: 0x00015A58
		[global::Cpp2ILInjected.Token(Token = "0x60013F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAC974", Offset = "0x1CAC974", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnwrapPromise<>), Member = "Invoke", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal void EndInliningScope()
		{
			throw null;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0001785B File Offset: 0x00015A5B
		[global::Cpp2ILInjected.Token(Token = "0x60013F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA6A5C", Offset = "0x1CA6A5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StackGuard()
		{
			throw null;
		}

		// Token: 0x0400083A RID: 2106
		[global::Cpp2ILInjected.Token(Token = "0x4000A9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_inliningDepth;
	}
}
