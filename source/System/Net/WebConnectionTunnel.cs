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
	// Token: 0x020001B7 RID: 439
	[global::Cpp2ILInjected.Token(Token = "0x2000286")]
	internal class WebConnectionTunnel
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00005C21 File Offset: 0x00003E21
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00005C24 File Offset: 0x00003E24
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

		// Token: 0x06001002 RID: 4098 RVA: 0x00005C27 File Offset: 0x00003E27
		[global::Cpp2ILInjected.Token(Token = "0x60011D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E10078", Offset = "0x1E10078", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
		{
			throw null;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00005C2A File Offset: 0x00003E2A
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x00005C2D File Offset: 0x00003E2D
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00005C30 File Offset: 0x00003E30
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00005C33 File Offset: 0x00003E33
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00005C36 File Offset: 0x00003E36
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00005C39 File Offset: 0x00003E39
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00005C3C File Offset: 0x00003E3C
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00005C3F File Offset: 0x00003E3F
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00005C42 File Offset: 0x00003E42
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00005C45 File Offset: 0x00003E45
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x00005C48 File Offset: 0x00003E48
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00005C4B File Offset: 0x00003E4B
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00005C4E File Offset: 0x00003E4E
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00005C51 File Offset: 0x00003E51
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00005C54 File Offset: 0x00003E54
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00005C57 File Offset: 0x00003E57
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

		// Token: 0x06001013 RID: 4115 RVA: 0x00005C5A File Offset: 0x00003E5A
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

		// Token: 0x06001014 RID: 4116 RVA: 0x00005C5D File Offset: 0x00003E5D
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

		// Token: 0x06001015 RID: 4117 RVA: 0x00005C60 File Offset: 0x00003E60
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

		// Token: 0x04000A85 RID: 2693
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly HttpWebRequest <Request>k__BackingField;

		// Token: 0x04000A86 RID: 2694
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DCD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Uri <ConnectUri>k__BackingField;

		// Token: 0x04000A87 RID: 2695
		[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private HttpWebRequest connectRequest;

		// Token: 0x04000A88 RID: 2696
		[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private WebConnectionTunnel.NtlmAuthState ntlmAuthState;

		// Token: 0x04000A89 RID: 2697
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool <Success>k__BackingField;

		// Token: 0x04000A8A RID: 2698
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool <CloseConnection>k__BackingField;

		// Token: 0x04000A8B RID: 2699
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int <StatusCode>k__BackingField;

		// Token: 0x04000A8C RID: 2700
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string <StatusDescription>k__BackingField;

		// Token: 0x04000A8D RID: 2701
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string[] <Challenge>k__BackingField;

		// Token: 0x04000A8E RID: 2702
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000A8F RID: 2703
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Version <ProxyVersion>k__BackingField;

		// Token: 0x04000A90 RID: 2704
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] <Data>k__BackingField;

		// Token: 0x02000432 RID: 1074
		[global::Cpp2ILInjected.Token(Token = "0x2000287")]
		private enum NtlmAuthState
		{
			// Token: 0x040012CF RID: 4815
			[global::Cpp2ILInjected.Token(Token = "0x4000DD9")]
			None,
			// Token: 0x040012D0 RID: 4816
			[global::Cpp2ILInjected.Token(Token = "0x4000DDA")]
			Challenge,
			// Token: 0x040012D1 RID: 4817
			[global::Cpp2ILInjected.Token(Token = "0x4000DDB")]
			Response
		}

		// Token: 0x02000433 RID: 1075
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000288")]
		[StructLayout(3)]
		private struct <Initialize>d__42 : IAsyncStateMachine
		{
			// Token: 0x06001E6F RID: 7791 RVA: 0x000083CC File Offset: 0x000065CC
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

			// Token: 0x06001E70 RID: 7792 RVA: 0x000083CF File Offset: 0x000065CF
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60011EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E12438", Offset = "0x1E12438", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040012D2 RID: 4818
			[global::Cpp2ILInjected.Token(Token = "0x4000DDC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012D3 RID: 4819
			[global::Cpp2ILInjected.Token(Token = "0x4000DDD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040012D4 RID: 4820
			[global::Cpp2ILInjected.Token(Token = "0x4000DDE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebConnectionTunnel <>4__this;

			// Token: 0x040012D5 RID: 4821
			[global::Cpp2ILInjected.Token(Token = "0x4000DDF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Stream stream;

			// Token: 0x040012D6 RID: 4822
			[global::Cpp2ILInjected.Token(Token = "0x4000DE0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			// Token: 0x040012D7 RID: 4823
			[global::Cpp2ILInjected.Token(Token = "0x4000DE1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private bool <have_auth>5__2;

			// Token: 0x040012D8 RID: 4824
			[global::Cpp2ILInjected.Token(Token = "0x4000DE2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040012D9 RID: 4825
			[global::Cpp2ILInjected.Token(Token = "0x4000DE3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, byte[], int>>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000434 RID: 1076
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000289")]
		[StructLayout(3)]
		private struct <ReadHeaders>d__43 : IAsyncStateMachine
		{
			// Token: 0x06001E71 RID: 7793 RVA: 0x000083D2 File Offset: 0x000065D2
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

			// Token: 0x06001E72 RID: 7794 RVA: 0x000083D5 File Offset: 0x000065D5
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

			// Token: 0x040012DA RID: 4826
			[global::Cpp2ILInjected.Token(Token = "0x4000DE4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012DB RID: 4827
			[global::Cpp2ILInjected.Token(Token = "0x4000DE5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder;

			// Token: 0x040012DC RID: 4828
			[global::Cpp2ILInjected.Token(Token = "0x4000DE6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x040012DD RID: 4829
			[global::Cpp2ILInjected.Token(Token = "0x4000DE7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Stream stream;

			// Token: 0x040012DE RID: 4830
			[global::Cpp2ILInjected.Token(Token = "0x4000DE8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public WebConnectionTunnel <>4__this;

			// Token: 0x040012DF RID: 4831
			[global::Cpp2ILInjected.Token(Token = "0x4000DE9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private byte[] <retBuffer>5__2;

			// Token: 0x040012E0 RID: 4832
			[global::Cpp2ILInjected.Token(Token = "0x4000DEA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private int <status>5__3;

			// Token: 0x040012E1 RID: 4833
			[global::Cpp2ILInjected.Token(Token = "0x4000DEB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private byte[] <buffer>5__4;

			// Token: 0x040012E2 RID: 4834
			[global::Cpp2ILInjected.Token(Token = "0x4000DEC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private MemoryStream <ms>5__5;

			// Token: 0x040012E3 RID: 4835
			[global::Cpp2ILInjected.Token(Token = "0x4000DED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
