using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x0200013E RID: 318
	[global::Cpp2ILInjected.Token(Token = "0x2000166")]
	internal class InvokableCallList
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x00002EDE File Offset: 0x000010DE
		[global::Cpp2ILInjected.Token(Token = "0x60006AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91834", Offset = "0x1F91834", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(InvokableCallList),
			typeof(UnityEventBase)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			throw null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00002EE1 File Offset: 0x000010E1
		[global::Cpp2ILInjected.Token(Token = "0x60006AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F918DC", Offset = "0x1F918DC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new object[] { typeof(BaseInvokableCall) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddListener(BaseInvokableCall call)
		{
			throw null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00002EE4 File Offset: 0x000010E4
		[global::Cpp2ILInjected.Token(Token = "0x60006B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91984", Offset = "0x1F91984", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAll", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void RemoveListener(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00002EE7 File Offset: 0x000010E7
		[global::Cpp2ILInjected.Token(Token = "0x60006B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91BD0", Offset = "0x1F91BD0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "DirtyPersistentCalls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void ClearPersistent()
		{
			throw null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002EEA File Offset: 0x000010EA
		[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91C84", Offset = "0x1F91C84", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(List<BaseInvokableCall>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public List<BaseInvokableCall> PrepareInvoke()
		{
			throw null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002EED File Offset: 0x000010ED
		[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91D24", Offset = "0x1F91D24", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public InvokableCallList()
		{
			throw null;
		}

		// Token: 0x04000608 RID: 1544
		[global::Cpp2ILInjected.Token(Token = "0x400065F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<BaseInvokableCall> m_PersistentCalls;

		// Token: 0x04000609 RID: 1545
		[global::Cpp2ILInjected.Token(Token = "0x4000660")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<BaseInvokableCall> m_RuntimeCalls;

		// Token: 0x0400060A RID: 1546
		[global::Cpp2ILInjected.Token(Token = "0x4000661")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<BaseInvokableCall> m_ExecutingCalls;

		// Token: 0x0400060B RID: 1547
		[global::Cpp2ILInjected.Token(Token = "0x4000662")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_NeedsUpdate;
	}
}
