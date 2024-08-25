using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000286")]
	internal class WebConnectionTunnel
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000415")]
		public HttpWebRequest Request
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E115F4", Offset = "0x1E115F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000416")]
		public Uri ConnectUri
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E115FC", Offset = "0x1E115FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10078", Offset = "0x1E10078", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000417")]
		public bool Success
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11604", Offset = "0x1E11604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1160C", Offset = "0x1E1160C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000418")]
		public bool CloseConnection
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11618", Offset = "0x1E11618", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11620", Offset = "0x1E11620", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000419")]
		public int StatusCode
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1162C", Offset = "0x1E1162C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11634", Offset = "0x1E11634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700041A")]
		public string StatusDescription
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1163C", Offset = "0x1E1163C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11644", Offset = "0x1E11644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700041B")]
		public string[] Challenge
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1164C", Offset = "0x1E1164C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11654", Offset = "0x1E11654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700041C")]
		public WebHeaderCollection Headers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1165C", Offset = "0x1E1165C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11664", Offset = "0x1E11664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700041D")]
		public Version ProxyVersion
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1166C", Offset = "0x1E1166C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11674", Offset = "0x1E11674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700041E")]
		public byte[] Data
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1167C", Offset = "0x1E1167C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60011E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11684", Offset = "0x1E11684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E100A4", Offset = "0x1E100A4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebConnectionTunnel.<Initialize>d__42) }, MemberParameters = new object[] { typeof(ref WebConnectionTunnel.<Initialize>d__42) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1168C", Offset = "0x1E1168C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionTunnel.<Initialize>d__42), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebConnectionTunnel.<ReadHeaders>d__43) }, MemberParameters = new object[] { typeof(ref WebConnectionTunnel.<ReadHeaders>d__43) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60011E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E11794", Offset = "0x1E11794", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionTunnel.<ReadHeaders>d__43), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void FlushContents(Stream stream, int contentLength)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly HttpWebRequest <Request>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Uri <ConnectUri>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private HttpWebRequest connectRequest;

		[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool <Success>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool <CloseConnection>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int <StatusCode>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string <StatusDescription>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string[] <Challenge>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebHeaderCollection <Headers>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Version <ProxyVersion>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] <Data>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000287")]
		private enum NtlmAuthState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000DD9")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000DDA")]
			Challenge,
			[global::Cpp2ILInjected.Token(Token = "0x4000DDB")]
			Response
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000288")]
		[StructLayout(3)]
		private struct <Initialize>d__42 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E11820", Offset = "0x1E11820", Length = "0xC18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Version),
				typeof(Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionTunnel), Member = "ReadHeaders", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<ValueTuple<WebHeaderCollection, byte[], int>>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<ValueTuple<object, object, int>>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.ConfiguredTaskAwaiter),
				typeof(WebConnectionTunnel.<Initialize>d__42)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.ConfiguredTaskAwaiter),
				typeof(ref WebConnectionTunnel.<Initialize>d__42)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebConnectionTunnel.<Initialize>d__42)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebConnectionTunnel.<Initialize>d__42)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(HttpStatusCode),
				typeof(WebHeaderCollection)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 74)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E12438", Offset = "0x1E12438", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DDC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000DDD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000DDE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebConnectionTunnel <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Stream stream;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private bool <have_auth>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, byte[], int>>.ConfiguredTaskAwaiter <>u__2;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000289")]
		[StructLayout(3)]
		private struct <ReadHeaders>d__43 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60011EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E12444", Offset = "0x1E12444", Length = "0x6EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "ReadLine", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref int),
				typeof(int),
				typeof(ref string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
			{
				typeof(char),
				typeof(StringSplitOptions)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionTunnel), Member = "FlushContents", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, object, int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "SetResult", MemberParameters = new object[] { typeof(ValueTuple<object, object, int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(WebConnectionTunnel.<ReadHeaders>d__43)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref WebConnectionTunnel.<ReadHeaders>d__43)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E12B30", Offset = "0x1E12B30", Length = "0x1058")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, object, int>>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000DE4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Stream stream;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebConnectionTunnel <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000DE9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private byte[] <retBuffer>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000DEA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private int <status>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4000DEB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private byte[] <buffer>5__4;

			[global::Cpp2ILInjected.Token(Token = "0x4000DEC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private MemoryStream <ms>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x4000DED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
