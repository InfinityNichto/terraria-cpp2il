using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000164 RID: 356
	[global::Cpp2ILInjected.Token(Token = "0x20001B6")]
	public sealed class AsyncLocal<T> : IAsyncLocal
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x000170CC File Offset: 0x000152CC
		[global::Cpp2ILInjected.Token(Token = "0x60010A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F5644", Offset = "0x17F5644", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentUICulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentCulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncLocal(global::System.Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
		{
			throw null;
		}

		// Token: 0x1700014F RID: 335
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x000170CF File Offset: 0x000152CF
		[global::Cpp2ILInjected.Token(Token = "0x17000185")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x17F566C", Offset = "0x17F566C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentUICulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Thread), Member = "set_CurrentCulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "SetLocalValue", MemberParameters = new object[]
			{
				typeof(IAsyncLocal),
				typeof(object),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000170D2 File Offset: 0x000152D2
		[global::Cpp2ILInjected.Token(Token = "0x60010AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x17F56E0", Offset = "0x17F56E0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
		{
			throw null;
		}

		// Token: 0x040006FC RID: 1788
		[global::Cpp2ILInjected.Token(Token = "0x40008FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
	}
}
