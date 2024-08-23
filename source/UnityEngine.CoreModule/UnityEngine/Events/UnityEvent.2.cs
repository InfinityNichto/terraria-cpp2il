using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000143 RID: 323
	[global::Cpp2ILInjected.Token(Token = "0x200016B")]
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00002F20 File Offset: 0x00001120
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18960B4", Offset = "0x18960B4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic.CullStateChangedEvent", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Toggle.ToggleEvent", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEvent()
		{
			throw null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002F23 File Offset: 0x00001123
		[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18960C0", Offset = "0x18960C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new object[] { typeof(BaseInvokableCall) }, ReturnType = typeof(void))]
		public void AddListener(UnityAction<T0> call)
		{
			throw null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00002F26 File Offset: 0x00001126
		[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x18960F8", Offset = "0x18960F8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "get_Method", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		public void RemoveListener(UnityAction<T0> call)
		{
			throw null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002F29 File Offset: 0x00001129
		[global::Cpp2ILInjected.Token(Token = "0x60006CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1896130", Offset = "0x1896130", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			throw null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002F2C File Offset: 0x0000112C
		[global::Cpp2ILInjected.Token(Token = "0x60006CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1896214", Offset = "0x1896214", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002F2F File Offset: 0x0000112F
		[global::Cpp2ILInjected.Token(Token = "0x60006CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1896274", Offset = "0x1896274", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			throw null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002F32 File Offset: 0x00001132
		[global::Cpp2ILInjected.Token(Token = "0x60006D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x189631C", Offset = "0x189631C", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(List<BaseInvokableCall>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Invoke(T0 arg0)
		{
			throw null;
		}

		// Token: 0x04000610 RID: 1552
		[global::Cpp2ILInjected.Token(Token = "0x4000667")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
