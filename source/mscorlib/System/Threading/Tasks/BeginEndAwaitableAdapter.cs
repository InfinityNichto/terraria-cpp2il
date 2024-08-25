using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000223")]
	internal sealed class BeginEndAwaitableAdapter : RendezvousAwaitable<global::System.IAsyncResult>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4A88", Offset = "0x1CA4A88", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<GetWebResponseTaskAsync>d__112", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RendezvousAwaitable<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BeginEndAwaitableAdapter()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4B08", Offset = "0x1CA4B08", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static BeginEndAwaitableAdapter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A33")]
		public static readonly global::System.AsyncCallback Callback;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000224")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001314")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4BCC", Offset = "0x1CA4BCC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001315")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4C28", Offset = "0x1CA4C28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001316")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4C30", Offset = "0x1CA4C30", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RendezvousAwaitable<>), Member = "SetResult", MemberParameters = new object[] { "TResult" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <.cctor>b__2_0(global::System.IAsyncResult asyncResult)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A34")]
			public static readonly BeginEndAwaitableAdapter.<>c <>9;
		}
	}
}
