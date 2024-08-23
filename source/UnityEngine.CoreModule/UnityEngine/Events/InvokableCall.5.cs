using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x02000139 RID: 313
	[global::Cpp2ILInjected.Token(Token = "0x2000161")]
	internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x00002EA5 File Offset: 0x000010A5
		[global::Cpp2ILInjected.Token(Token = "0x600069B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1712020", Offset = "0x1712020", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public InvokableCall(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002EA8 File Offset: 0x000010A8
		[global::Cpp2ILInjected.Token(Token = "0x600069C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1712154", Offset = "0x1712154", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002EAB File Offset: 0x000010AB
		[global::Cpp2ILInjected.Token(Token = "0x600069D")]
		[global::Cpp2ILInjected.Address(RVA = "0x17123BC", Offset = "0x17123BC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Find(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x040005FB RID: 1531
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UnityAction<T1, T2, T3, T4> Delegate;
	}
}
