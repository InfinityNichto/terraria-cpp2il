using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000A9 RID: 169
	[ExtensionOfNativeClass]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
	public class MonoBehaviour : Behaviour
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0000267D File Offset: 0x0000087D
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CCE8", Offset = "0x1F7CCE8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsInvoking()
		{
			throw null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002680 File Offset: 0x00000880
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CD60", Offset = "0x1F7CD60", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CancelInvoke()
		{
			throw null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002683 File Offset: 0x00000883
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CDD8", Offset = "0x1F7CDD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Invoke(string methodName, float time)
		{
			throw null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002686 File Offset: 0x00000886
		[global::Cpp2ILInjected.Token(Token = "0x6000329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CE8C", Offset = "0x1F7CE8C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002689 File Offset: 0x00000889
		[global::Cpp2ILInjected.Token(Token = "0x600032A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CF44", Offset = "0x1F7CF44", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CancelInvoke(string methodName)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000268C File Offset: 0x0000088C
		[global::Cpp2ILInjected.Token(Token = "0x600032B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CFCC", Offset = "0x1F7CFCC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsInvoking(string methodName)
		{
			throw null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000268F File Offset: 0x0000088F
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x600032C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D054", Offset = "0x1F7D054", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Coroutine StartCoroutine(string methodName)
		{
			throw null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002692 File Offset: 0x00000892
		[global::Cpp2ILInjected.Token(Token = "0x600032D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D05C", Offset = "0x1F7D05C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
		{
			throw null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002695 File Offset: 0x00000895
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D1F8", Offset = "0x1F7D1F8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoBehaviour), Member = "StartCoroutine_Auto", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button", Member = "OnSubmit", MemberParameters = new object[] { "UnityEngine.EventSystems.BaseEventData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Hide", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetCaretActive", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "OnPointerDown", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1", Member = "StartTween", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			throw null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002698 File Offset: 0x00000898
		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D32C", Offset = "0x1F7D32C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		public Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			throw null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000269B File Offset: 0x0000089B
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D330", Offset = "0x1F7D330", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1", Member = "StopTween", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void StopCoroutine(IEnumerator routine)
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000269E File Offset: 0x0000089E
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D464", Offset = "0x1F7D464", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar.<ClickRepeat>d__58", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void StopCoroutine(Coroutine routine)
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803
		[global::Cpp2ILInjected.Token(Token = "0x6000332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D598", Offset = "0x1F7D598", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void StopCoroutine(string methodName);

		// Token: 0x06000324 RID: 804
		[global::Cpp2ILInjected.Token(Token = "0x6000333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D5DC", Offset = "0x1F7D5DC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void StopAllCoroutines();

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000325 RID: 805
		// (set) Token: 0x06000326 RID: 806
		[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
		public extern bool useGUILayout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000334")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7D618", Offset = "0x1F7D618", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000335")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7D654", Offset = "0x1F7D654", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000026A1 File Offset: 0x000008A1
		[global::Cpp2ILInjected.Token(Token = "0x6000336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D698", Offset = "0x1F7D698", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void print(object message)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808
		[FreeFunction("CancelInvoke")]
		[global::Cpp2ILInjected.Token(Token = "0x6000337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CD9C", Offset = "0x1F7CD9C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_CancelInvokeAll([NotNull("NullExceptionObject")] MonoBehaviour self);

		// Token: 0x06000329 RID: 809
		[FreeFunction("IsInvoking")]
		[global::Cpp2ILInjected.Token(Token = "0x6000338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CD24", Offset = "0x1F7CD24", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool Internal_IsInvokingAll([NotNull("NullExceptionObject")] MonoBehaviour self);

		// Token: 0x0600032A RID: 810
		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x6000339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CE30", Offset = "0x1F7CE30", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void InvokeDelayed([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName, float time, float repeatRate);

		// Token: 0x0600032B RID: 811
		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x600033A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CF88", Offset = "0x1F7CF88", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CancelInvoke([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName);

		// Token: 0x0600032C RID: 812
		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x600033B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D010", Offset = "0x1F7D010", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool IsInvoking([NotNull("NullExceptionObject")] MonoBehaviour self, string methodName);

		// Token: 0x0600032D RID: 813
		[FreeFunction]
		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D168", Offset = "0x1F7D168", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool IsObjectMonoBehaviour([NotNull("NullExceptionObject")] Object obj);

		// Token: 0x0600032E RID: 814
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D1A4", Offset = "0x1F7D1A4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Coroutine StartCoroutineManaged(string methodName, object value);

		// Token: 0x0600032F RID: 815
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D2E8", Offset = "0x1F7D2E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Coroutine StartCoroutineManaged2(IEnumerator enumerator);

		// Token: 0x06000330 RID: 816
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D554", Offset = "0x1F7D554", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void StopCoroutineManaged(Coroutine routine);

		// Token: 0x06000331 RID: 817
		[global::Cpp2ILInjected.Token(Token = "0x6000340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D420", Offset = "0x1F7D420", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void StopCoroutineFromEnumeratorManaged(IEnumerator routine);

		// Token: 0x06000332 RID: 818
		[global::Cpp2ILInjected.Token(Token = "0x6000341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D6EC", Offset = "0x1F7D6EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern string GetScriptClassName();

		// Token: 0x06000333 RID: 819 RVA: 0x000026A4 File Offset: 0x000008A4
		[global::Cpp2ILInjected.Token(Token = "0x6000342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7D728", Offset = "0x1F7D728", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		public MonoBehaviour()
		{
			throw null;
		}
	}
}
