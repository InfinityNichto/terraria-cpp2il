using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x02000136 RID: 310
	[global::Cpp2ILInjected.Token(Token = "0x200015E")]
	internal class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000652 RID: 1618 RVA: 0x00002E7E File Offset: 0x0000107E
		// (remove) Token: 0x06000653 RID: 1619 RVA: 0x00002E81 File Offset: 0x00001081
		[global::Cpp2ILInjected.Token(Token = "0x14000006")]
		protected event UnityAction<T1> Delegate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600068E")]
			[global::Cpp2ILInjected.Address(RVA = "0x170FF1C", Offset = "0x170FF1C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600068F")]
			[global::Cpp2ILInjected.Address(RVA = "0x170FFC8", Offset = "0x170FFC8", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002E84 File Offset: 0x00001084
		[global::Cpp2ILInjected.Token(Token = "0x6000690")]
		[global::Cpp2ILInjected.Address(RVA = "0x1710074", Offset = "0x1710074", Length = "0x114")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public InvokableCall(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002E87 File Offset: 0x00001087
		[global::Cpp2ILInjected.Token(Token = "0x6000691")]
		[global::Cpp2ILInjected.Address(RVA = "0x1710188", Offset = "0x1710188", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public InvokableCall(UnityAction<T1> action)
		{
			throw null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002E8A File Offset: 0x0000108A
		[global::Cpp2ILInjected.Token(Token = "0x6000692")]
		[global::Cpp2ILInjected.Address(RVA = "0x17101C8", Offset = "0x17101C8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002E8D File Offset: 0x0000108D
		[global::Cpp2ILInjected.Token(Token = "0x6000693")]
		[global::Cpp2ILInjected.Address(RVA = "0x17102E4", Offset = "0x17102E4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Invoke(T1 args0)
		{
			throw null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002E90 File Offset: 0x00001090
		[global::Cpp2ILInjected.Token(Token = "0x6000694")]
		[global::Cpp2ILInjected.Address(RVA = "0x1710338", Offset = "0x1710338", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Find(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x040005F8 RID: 1528
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UnityAction<T1> Delegate;
	}
}
