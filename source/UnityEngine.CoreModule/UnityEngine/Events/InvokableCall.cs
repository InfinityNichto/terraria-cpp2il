using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x02000135 RID: 309
	[global::Cpp2ILInjected.Token(Token = "0x200015D")]
	internal class InvokableCall : BaseInvokableCall
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600064B RID: 1611 RVA: 0x00002E69 File Offset: 0x00001069
		// (remove) Token: 0x0600064C RID: 1612 RVA: 0x00002E6C File Offset: 0x0000106C
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		private event UnityAction Delegate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000687")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90984", Offset = "0x1F90984", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(MethodInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "GetDelegate", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(BaseInvokableCall))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000688")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90A20", Offset = "0x1F90A20", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002E6F File Offset: 0x0000106F
		[global::Cpp2ILInjected.Token(Token = "0x6000689")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90ABC", Offset = "0x1F90ABC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new object[] { typeof(UnityEventBase) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "GetDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public InvokableCall(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002E72 File Offset: 0x00001072
		[global::Cpp2ILInjected.Token(Token = "0x600068A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90BA4", Offset = "0x1F90BA4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		public InvokableCall(UnityAction action)
		{
			throw null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002E75 File Offset: 0x00001075
		[global::Cpp2ILInjected.Token(Token = "0x600068B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90BD0", Offset = "0x1F90BD0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00002E78 File Offset: 0x00001078
		[global::Cpp2ILInjected.Token(Token = "0x600068C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90C04", Offset = "0x1F90C04", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = "Invoke", MemberParameters = new object[] { "T0" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Invoke()
		{
			throw null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00002E7B File Offset: 0x0000107B
		[global::Cpp2ILInjected.Token(Token = "0x600068D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90C38", Offset = "0x1F90C38", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Find(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x040005F7 RID: 1527
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private UnityAction Delegate;
	}
}
