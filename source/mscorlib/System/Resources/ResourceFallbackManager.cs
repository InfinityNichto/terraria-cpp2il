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
	[global::Cpp2ILInjected.Token(Token = "0x20004A9")]
	internal class ResourceFallbackManager : global::System.Collections.Generic.IEnumerable<global::System.Globalization.CultureInfo>, global::System.Collections.IEnumerable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60022CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75D70", Offset = "0x1B75D70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40012F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Globalization.CultureInfo m_startingCulture;

		[global::Cpp2ILInjected.Token(Token = "0x40012FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Globalization.CultureInfo m_neutralResourcesCulture;

		[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_useParents;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20004AA")]
		private sealed class <GetEnumerator>d__5 : global::System.Collections.Generic.IEnumerator<global::System.Globalization.CultureInfo>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60022CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75DD4", Offset = "0x1B75DD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__5(int <>1__state)
			{
				throw null;
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60022D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75DFC", Offset = "0x1B75DFC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Globalization.CultureInfo <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ResourceFallbackManager <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private bool <reachedNeutralResourcesCulture>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4001300")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private global::System.Globalization.CultureInfo <currentCulture>5__3;
		}
	}
}
