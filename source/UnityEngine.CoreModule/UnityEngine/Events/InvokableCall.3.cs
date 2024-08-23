using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x02000137 RID: 311
	[global::Cpp2ILInjected.Token(Token = "0x200015F")]
	internal class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x00002E93 File Offset: 0x00001093
		[global::Cpp2ILInjected.Token(Token = "0x6000695")]
		[global::Cpp2ILInjected.Address(RVA = "0x171199C", Offset = "0x171199C", Length = "0x134")]
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

		// Token: 0x0600065A RID: 1626 RVA: 0x00002E96 File Offset: 0x00001096
		[global::Cpp2ILInjected.Token(Token = "0x6000696")]
		[global::Cpp2ILInjected.Address(RVA = "0x1711AD0", Offset = "0x1711AD0", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002E99 File Offset: 0x00001099
		[global::Cpp2ILInjected.Token(Token = "0x6000697")]
		[global::Cpp2ILInjected.Address(RVA = "0x1711C68", Offset = "0x1711C68", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Find(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x040005F9 RID: 1529
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UnityAction<T1, T2> Delegate;
	}
}
