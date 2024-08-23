using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003EF RID: 1007
	[global::Cpp2ILInjected.Token(Token = "0x20004A9")]
	internal class ResourceFallbackManager : global::System.Collections.Generic.IEnumerable<global::System.Globalization.CultureInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002053 RID: 8275 RVA: 0x00019F88 File Offset: 0x00018188
		[global::Cpp2ILInjected.Token(Token = "0x60022CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75CE8", Offset = "0x1B75CE8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "InternalGetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ResourceFallbackManager(global::System.Globalization.CultureInfo startingCulture, global::System.Globalization.CultureInfo neutralResourcesCulture, bool useParents)
		{
			throw null;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00019F8B File Offset: 0x0001818B
		[global::Cpp2ILInjected.Token(Token = "0x60022CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75D70", Offset = "0x1B75D70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00019F8E File Offset: 0x0001818E
		[global::Cpp2ILInjected.Token(Token = "0x60022CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75D74", Offset = "0x1B75D74", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourceManager), Member = "InternalGetResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.Generic.IEnumerator<global::System.Globalization.CultureInfo> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000FE9 RID: 4073
		[global::Cpp2ILInjected.Token(Token = "0x40012F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Globalization.CultureInfo m_startingCulture;

		// Token: 0x04000FEA RID: 4074
		[global::Cpp2ILInjected.Token(Token = "0x40012FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Globalization.CultureInfo m_neutralResourcesCulture;

		// Token: 0x04000FEB RID: 4075
		[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_useParents;

		// Token: 0x02000605 RID: 1541
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20004AA")]
		private sealed class <GetEnumerator>d__5 : global::System.Collections.Generic.IEnumerator<global::System.Globalization.CultureInfo>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06004150 RID: 16720 RVA: 0x0001FE86 File Offset: 0x0001E086
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60022CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75DD4", Offset = "0x1B75DD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__5(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06004151 RID: 16721 RVA: 0x0001FE89 File Offset: 0x0001E089
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60022D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75DFC", Offset = "0x1B75DFC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06004152 RID: 16722 RVA: 0x0001FE8C File Offset: 0x0001E08C
			[global::Cpp2ILInjected.Token(Token = "0x60022D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75E00", Offset = "0x1B75E00", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_HasInvariantCultureName", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x06004153 RID: 16723 RVA: 0x0001FE8F File Offset: 0x0001E08F
			[global::Cpp2ILInjected.Token(Token = "0x17000481")]
			private global::System.Globalization.CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60022D2")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B75FA8", Offset = "0x1B75FA8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004154 RID: 16724 RVA: 0x0001FE92 File Offset: 0x0001E092
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60022D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75FB0", Offset = "0x1B75FB0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x06004155 RID: 16725 RVA: 0x0001FE95 File Offset: 0x0001E095
			[global::Cpp2ILInjected.Token(Token = "0x17000482")]
			private object System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60022D4")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B75FE8", Offset = "0x1B75FE8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04001998 RID: 6552
			[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04001999 RID: 6553
			[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Globalization.CultureInfo <>2__current;

			// Token: 0x0400199A RID: 6554
			[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ResourceFallbackManager <>4__this;

			// Token: 0x0400199B RID: 6555
			[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool <reachedNeutralResourcesCulture>5__2;

			// Token: 0x0400199C RID: 6556
			[global::Cpp2ILInjected.Token(Token = "0x4001300")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private global::System.Globalization.CultureInfo <currentCulture>5__3;
		}
	}
}
