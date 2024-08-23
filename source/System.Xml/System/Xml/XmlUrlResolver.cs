using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000087 RID: 135
	[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0000442A File Offset: 0x0000262A
		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		private static XmlDownloadManager DownloadManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1230", Offset = "0x1DB1230", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUrlResolver.<GetEntityAsync>d__15), Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0000442D File Offset: 0x0000262D
		[global::Cpp2ILInjected.Token(Token = "0x60007BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB12FC", Offset = "0x1DB12FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateDefaultResolver", ReturnType = typeof(XmlResolver))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetTempResolver", ReturnType = typeof(XmlResolver))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlUrlResolver()
		{
			throw null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00004430 File Offset: 0x00002630
		[global::Cpp2ILInjected.Token(Token = "0x60007BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1304", Offset = "0x1DB1304", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = "get_DownloadManager", ReturnType = typeof(XmlDownloadManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDownloadManager), Member = "GetStream", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw null;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00004433 File Offset: 0x00002633
		[global::Cpp2ILInjected.Token(Token = "0x60007BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1474", Offset = "0x1DB1474", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			throw null;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00004436 File Offset: 0x00002636
		[global::Cpp2ILInjected.Token(Token = "0x60007BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1478", Offset = "0x1DB1478", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(XmlUrlResolver.<GetEntityAsync>d__15) }, MemberParameters = new object[] { typeof(ref XmlUrlResolver.<GetEntityAsync>d__15) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw null;
		}

		// Token: 0x0400027A RID: 634
		[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
		private static object s_DownloadManager;

		// Token: 0x0400027B RID: 635
		[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ICredentials _credentials;

		// Token: 0x0400027C RID: 636
		[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IWebProxy _proxy;

		// Token: 0x0400027D RID: 637
		[global::Cpp2ILInjected.Token(Token = "0x40003E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RequestCachePolicy _cachePolicy;

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
		[StructLayout(3)]
		private struct <GetEntityAsync>d__15 : IAsyncStateMachine
		{
			// Token: 0x06000CBF RID: 3263 RVA: 0x00005399 File Offset: 0x00003599
			[global::Cpp2ILInjected.Token(Token = "0x60007BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1584", Offset = "0x1DB1584", Length = "0x354")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = "get_DownloadManager", ReturnType = typeof(XmlDownloadManager))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDownloadManager), Member = "GetStreamAsync", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(ICredentials),
				typeof(IWebProxy),
				typeof(RequestCachePolicy)
			}, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(XmlUrlResolver.<GetEntityAsync>d__15)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref XmlUrlResolver.<GetEntityAsync>d__15)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x0000539C File Offset: 0x0000359C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60007C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB18D8", Offset = "0x1DB18D8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400065A RID: 1626
			[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400065B RID: 1627
			[global::Cpp2ILInjected.Token(Token = "0x40003EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<object> <>t__builder;

			// Token: 0x0400065C RID: 1628
			[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Type ofObjectToReturn;

			// Token: 0x0400065D RID: 1629
			[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Uri absoluteUri;

			// Token: 0x0400065E RID: 1630
			[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public XmlUrlResolver <>4__this;

			// Token: 0x0400065F RID: 1631
			[global::Cpp2ILInjected.Token(Token = "0x40003EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
