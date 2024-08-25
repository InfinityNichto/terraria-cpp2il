using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F6")]
	internal abstract class ProxyChain : IEnumerable<Uri>, IEnumerable, IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F274C8", Offset = "0x1F274C8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyScriptChain), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebProxy),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DirectProxy), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StaticProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmptyWebProxy), Member = "System.Net.IAutoWebProxy.GetProxies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(ProxyChain))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "System.Net.IAutoWebProxy.GetProxies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(ProxyChain))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected ProxyChain(Uri destination)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27550", Offset = "0x1F27550", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyChain), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyChain), Member = "get_Enumerator", ReturnType = typeof(IEnumerator<Uri>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<Uri> GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F275F0", Offset = "0x1F275F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<Uri>))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F275F4", Offset = "0x1F275F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000286")]
		internal IEnumerator<Uri> Enumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F275F8", Offset = "0x1F275F8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<Uri>))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000287")]
		internal Uri Destination
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F27610", Offset = "0x1F27610", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27618", Offset = "0x1F27618", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void Abort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2761C", Offset = "0x1F2761C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool HttpAbort(HttpWebRequest request, WebException webException)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000288")]
		internal HttpAbortDelegate HttpAbortDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F27638", Offset = "0x1F27638", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpAbortDelegate), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000C66")]
		protected abstract bool GetNextProxy(out Uri proxy);

		[global::Cpp2ILInjected.Token(Token = "0x4000AA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<Uri> m_Cache;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_CacheComplete;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ProxyChain.ProxyEnumerator m_MainEnumerator;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Uri m_Destination;

		[global::Cpp2ILInjected.Token(Token = "0x4000AA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private HttpAbortDelegate m_HttpAbortDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x20001F7")]
		private class ProxyEnumerator : IEnumerator<Uri>, IDisposable, IEnumerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F275C0", Offset = "0x1F275C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ProxyEnumerator(ProxyChain chain)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000289")]
			public Uri Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C68")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F276B8", Offset = "0x1F276B8", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyChain.ProxyEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700028A")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C69")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F27764", Offset = "0x1F27764", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProxyChain.ProxyEnumerator), Member = "get_Current", ReturnType = typeof(Uri))]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F27768", Offset = "0x1F27768", Length = "0x2A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F27A08", Offset = "0x1F27A08", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000C6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F27A18", Offset = "0x1F27A18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000AA6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ProxyChain m_Chain;

			[global::Cpp2ILInjected.Token(Token = "0x4000AA7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private bool m_Finished;

			[global::Cpp2ILInjected.Token(Token = "0x4000AA8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int m_CurrentIndex;

			[global::Cpp2ILInjected.Token(Token = "0x4000AA9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool m_TriedDirect;
		}
	}
}
