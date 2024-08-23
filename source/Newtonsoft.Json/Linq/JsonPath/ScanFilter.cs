using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000AF RID: 175
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
	internal class ScanFilter : PathFilter
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00003A3A File Offset: 0x00001C3A
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00003A3D File Offset: 0x00001C3D
		[global::Cpp2ILInjected.Token(Token = "0x170001C8")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24628", Offset = "0x1D24628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24630", Offset = "0x1D24630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00003A40 File Offset: 0x00001C40
		[global::Cpp2ILInjected.Token(Token = "0x60009F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D24638", Offset = "0x1D24638", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00003A43 File Offset: 0x00001C43
		[global::Cpp2ILInjected.Token(Token = "0x60009F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D21558", Offset = "0x1D21558", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ScanFilter()
		{
			throw null;
		}

		// Token: 0x040002DD RID: 733
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x02000135 RID: 309
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000BA5 RID: 2981 RVA: 0x0000426B File Offset: 0x0000246B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D246A0", Offset = "0x1D246A0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScanFilter), Member = "ExecuteFilter", MemberParameters = new object[]
			{
				typeof(IEnumerable<JToken>),
				typeof(bool)
			}, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <ExecuteFilter>d__4(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x0000426E File Offset: 0x0000246E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D246DC", Offset = "0x1D246DC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x00004271 File Offset: 0x00002471
			[global::Cpp2ILInjected.Token(Token = "0x60009F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24708", Offset = "0x1D24708", Length = "0x484")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x00004274 File Offset: 0x00002474
			[global::Cpp2ILInjected.Token(Token = "0x60009F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24B8C", Offset = "0x1D24B8C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00004277 File Offset: 0x00002477
			[global::Cpp2ILInjected.Token(Token = "0x170001C9")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009F9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D24C3C", Offset = "0x1D24C3C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000BAA RID: 2986 RVA: 0x0000427A File Offset: 0x0000247A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24C44", Offset = "0x1D24C44", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0000427D File Offset: 0x0000247D
			[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009FB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D24C7C", Offset = "0x1D24C7C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000BAC RID: 2988 RVA: 0x00004280 File Offset: 0x00002480
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24C84", Offset = "0x1D24C84", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00004283 File Offset: 0x00002483
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24D20", Offset = "0x1D24D20", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScanFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000468 RID: 1128
			[global::Cpp2ILInjected.Token(Token = "0x40003E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000469 RID: 1129
			[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x0400046A RID: 1130
			[global::Cpp2ILInjected.Token(Token = "0x40003EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400046B RID: 1131
			[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x0400046C RID: 1132
			[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x0400046D RID: 1133
			[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public ScanFilter <>4__this;

			// Token: 0x0400046E RID: 1134
			[global::Cpp2ILInjected.Token(Token = "0x40003EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private JToken <root>5__1;

			// Token: 0x0400046F RID: 1135
			[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private JToken <value>5__2;

			// Token: 0x04000470 RID: 1136
			[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
