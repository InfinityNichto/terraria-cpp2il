using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000293 RID: 659
	[global::Cpp2ILInjected.Token(Token = "0x2000354")]
	public static class MessageBox
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0002581A File Offset: 0x00023A1A
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0002581D File Offset: 0x00023A1D
		[global::Cpp2ILInjected.Token(Token = "0x17000268")]
		public static bool IsVisible
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015E3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9CC94", Offset = "0xA9CC94", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015E4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9CCDC", Offset = "0xA9CCDC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00025820 File Offset: 0x00023A20
		[global::Cpp2ILInjected.Token(Token = "0x60015E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9CD28", Offset = "0xA9CD28", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int?>), Member = "Start", MemberTypeParameters = new object[] { typeof(MessageBox.<Show>d__4) }, MemberParameters = new object[] { typeof(ref MessageBox.<Show>d__4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Task<int?> Show(string title, string description, IEnumerable<string> buttons)
		{
			throw null;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00025823 File Offset: 0x00023A23
		[global::Cpp2ILInjected.Token(Token = "0x60015E6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9CE20", Offset = "0xA9CE20", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Cancel(int? result)
		{
			throw null;
		}

		// Token: 0x04001E16 RID: 7702
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40023F0")]
		private static bool <IsVisible>k__BackingField;

		// Token: 0x02000820 RID: 2080
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000355")]
		[StructLayout(3)]
		private struct <Show>d__4 : IAsyncStateMachine
		{
			// Token: 0x06004930 RID: 18736 RVA: 0x0002EFA9 File Offset: 0x0002D1A9
			[global::Cpp2ILInjected.Token(Token = "0x60015E7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9CEAC", Offset = "0xA9CEAC", Length = "0x2A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06004931 RID: 18737 RVA: 0x0002EFAC File Offset: 0x0002D1AC
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60015E8")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9D154", Offset = "0xA9D154", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04007D98 RID: 32152
			[global::Cpp2ILInjected.Token(Token = "0x40023F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04007D99 RID: 32153
			[global::Cpp2ILInjected.Token(Token = "0x40023F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x04007D9A RID: 32154
			[global::Cpp2ILInjected.Token(Token = "0x40023F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public IEnumerable<string> buttons;
		}
	}
}
