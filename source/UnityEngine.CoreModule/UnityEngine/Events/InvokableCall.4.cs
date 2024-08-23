using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x02000138 RID: 312
	[global::Cpp2ILInjected.Token(Token = "0x2000160")]
	internal class InvokableCall<T1, T2, T3> : BaseInvokableCall
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x00002E9C File Offset: 0x0000109C
		[global::Cpp2ILInjected.Token(Token = "0x6000698")]
		[global::Cpp2ILInjected.Address(RVA = "0x1711CA8", Offset = "0x1711CA8", Length = "0x134")]
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

		// Token: 0x0600065D RID: 1629 RVA: 0x00002E9F File Offset: 0x0000109F
		[global::Cpp2ILInjected.Token(Token = "0x6000699")]
		[global::Cpp2ILInjected.Address(RVA = "0x1711DDC", Offset = "0x1711DDC", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002EA2 File Offset: 0x000010A2
		[global::Cpp2ILInjected.Token(Token = "0x600069A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1711FE0", Offset = "0x1711FE0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Find(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x040005FA RID: 1530
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UnityAction<T1, T2, T3> Delegate;
	}
}
