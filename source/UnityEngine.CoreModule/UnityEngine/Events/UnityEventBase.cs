using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200013F RID: 319
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000167")]
	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x00002EF0 File Offset: 0x000010F0
		[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91DD8", Offset = "0x1F91DD8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, , >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, , , >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCallGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected UnityEventBase()
		{
			throw null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00002EF3 File Offset: 0x000010F3
		[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91E70", Offset = "0x1F91E70", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "ClearPersistent", ReturnType = typeof(void))]
		private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00002EF6 File Offset: 0x000010F6
		[global::Cpp2ILInjected.Token(Token = "0x60006B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91EB0", Offset = "0x1F91EB0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "ClearPersistent", ReturnType = typeof(void))]
		private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0600067B RID: 1659
		[global::Cpp2ILInjected.Token(Token = "0x60006B7")]
		protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

		// Token: 0x0600067C RID: 1660
		[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		// Token: 0x0600067D RID: 1661 RVA: 0x00002EF9 File Offset: 0x000010F9
		[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91030", Offset = "0x1F91030", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new object[] { typeof(UnityEventBase) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(PersistentListenerMode),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal MethodInfo FindMethod(PersistentCall call)
		{
			throw null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002EFC File Offset: 0x000010FC
		[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91ED0", Offset = "0x1F91ED0", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new object[] { typeof(PersistentCall) }, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			throw null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002EFF File Offset: 0x000010FF
		[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F91E90", Offset = "0x1F91E90", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "ClearPersistent", ReturnType = typeof(void))]
		private void DirtyPersistentCalls()
		{
			throw null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002F02 File Offset: 0x00001102
		[global::Cpp2ILInjected.Token(Token = "0x60006BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92288", Offset = "0x1F92288", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(InvokableCallList),
			typeof(UnityEventBase)
		}, ReturnType = typeof(void))]
		private void RebuildPersistentCallsIfNeeded()
		{
			throw null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002F05 File Offset: 0x00001105
		[global::Cpp2ILInjected.Token(Token = "0x60006BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F922B0", Offset = "0x1F922B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = "AddListener", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T0>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "AddListener", MemberParameters = new object[] { typeof(BaseInvokableCall) }, ReturnType = typeof(void))]
		internal void AddCall(BaseInvokableCall call)
		{
			throw null;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002F08 File Offset: 0x00001108
		[global::Cpp2ILInjected.Token(Token = "0x60006BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F922B8", Offset = "0x1F922B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = "RemoveListener", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T0>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "RemoveListener", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		protected void RemoveListener(object targetObj, MethodInfo method)
		{
			throw null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002F0B File Offset: 0x0000110B
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F922C0", Offset = "0x1F922C0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = "Invoke", MemberParameters = new object[] { "T0" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(InvokableCallList),
			typeof(UnityEventBase)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "PrepareInvoke", ReturnType = typeof(List<BaseInvokableCall>))]
		internal List<BaseInvokableCall> PrepareInvoke()
		{
			throw null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002F0E File Offset: 0x0000110E
		[global::Cpp2ILInjected.Token(Token = "0x60006C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F922EC", Offset = "0x1F922EC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002F11 File Offset: 0x00001111
		[global::Cpp2ILInjected.Token(Token = "0x60006C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92368", Offset = "0x1F92368", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEventBaseExtensions", Member = "FindMethod", MemberParameters = new object[]
		{
			typeof(UnityEventBase),
			typeof(string),
			typeof(object),
			typeof(PersistentListenerMode),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		public static MethodInfo GetValidMethodInfo(object obj, string functionName, Type[] argumentTypes)
		{
			throw null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002F14 File Offset: 0x00001114
		[global::Cpp2ILInjected.Token(Token = "0x60006C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92110", Offset = "0x1F92110", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, >), Member = "FindMethod_Impl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<>), Member = "FindMethod_Impl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, , >), Member = "FindMethod_Impl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent<, , , >), Member = "FindMethod_Impl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "FindMethod_Impl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes)
		{
			throw null;
		}

		// Token: 0x0400060C RID: 1548
		[global::Cpp2ILInjected.Token(Token = "0x4000663")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InvokableCallList m_Calls;

		// Token: 0x0400060D RID: 1549
		[FormerlySerializedAs("m_PersistentListeners")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000664")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PersistentCallGroup m_PersistentCalls;

		// Token: 0x0400060E RID: 1550
		[global::Cpp2ILInjected.Token(Token = "0x4000665")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_CallsDirty;
	}
}
