using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000149 RID: 329
	[global::Cpp2ILInjected.Token(Token = "0x2000171")]
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x00002F47 File Offset: 0x00001147
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92464", Offset = "0x1F92464", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button.ButtonClickedEvent", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEvent()
		{
			throw null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002F4A File Offset: 0x0000114A
		[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9246C", Offset = "0x1F9246C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent), Member = "GetDelegate", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCallList), Member = "AddListener", MemberParameters = new object[] { typeof(BaseInvokableCall) }, ReturnType = typeof(void))]
		public void AddListener(UnityAction call)
		{
			throw null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002F4D File Offset: 0x0000114D
		[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F924F4", Offset = "0x1F924F4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			throw null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00002F50 File Offset: 0x00001150
		[global::Cpp2ILInjected.Token(Token = "0x60006E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92558", Offset = "0x1F92558", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002F53 File Offset: 0x00001153
		[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F92490", Offset = "0x1F92490", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new object[] { typeof(UnityAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static BaseInvokableCall GetDelegate(UnityAction action)
		{
			throw null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002F56 File Offset: 0x00001156
		[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F925C0", Offset = "0x1F925C0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button", Member = "Press", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(List<BaseInvokableCall>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInvokableCall), Member = "AllowInvoke", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Invoke()
		{
			throw null;
		}

		// Token: 0x04000613 RID: 1555
		[global::Cpp2ILInjected.Token(Token = "0x400066A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object[] m_InvokeArray;
	}
}
