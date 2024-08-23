using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000071 RID: 113
	[global::Cpp2ILInjected.Token(Token = "0x2000096")]
	internal class XmlDownloadManager
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x00004292 File Offset: 0x00002492
		[global::Cpp2ILInjected.Token(Token = "0x6000726")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAC304", Offset = "0x1DAC304", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUrlResolver), Member = "GetEntity", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			throw null;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004295 File Offset: 0x00002495
		[global::Cpp2ILInjected.Token(Token = "0x6000727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAC3FC", Offset = "0x1DAC3FC", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlRegisteredNonCachedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(XmlDownloadManager),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCachedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			throw null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00004298 File Offset: 0x00002498
		[global::Cpp2ILInjected.Token(Token = "0x6000728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAC9D8", Offset = "0x1DAC9D8", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRegisteredNonCachedStream), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRegisteredNonCachedStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void Remove(string host)
		{
			throw null;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000429B File Offset: 0x0000249B
		[global::Cpp2ILInjected.Token(Token = "0x6000729")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DACB30", Offset = "0x1DACB30", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlUrlResolver.<GetEntityAsync>d__15", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "Run", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(Func<object>) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDownloadManager), Member = "GetNonFileStreamAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			throw null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000429E File Offset: 0x0000249E
		[global::Cpp2ILInjected.Token(Token = "0x600072A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DACC98", Offset = "0x1DACC98", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDownloadManager), Member = "GetStreamAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5) }, MemberParameters = new object[] { typeof(ref XmlDownloadManager.<GetNonFileStreamAsync>d__5) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			throw null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000042A1 File Offset: 0x000024A1
		[global::Cpp2ILInjected.Token(Token = "0x600072B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DACDB0", Offset = "0x1DACDB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public XmlDownloadManager()
		{
			throw null;
		}

		// Token: 0x04000249 RID: 585
		[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Hashtable connections;

		// Token: 0x0200016B RID: 363
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000097")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06000CB8 RID: 3256 RVA: 0x0000538A File Offset: 0x0000358A
			[global::Cpp2ILInjected.Token(Token = "0x600072C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DACC90", Offset = "0x1DACC90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4_0()
			{
				throw null;
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x0000538D File Offset: 0x0000358D
			[global::Cpp2ILInjected.Token(Token = "0x600072D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DACDB8", Offset = "0x1DACDB8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FileMode),
				typeof(FileAccess),
				typeof(FileShare),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Stream <GetStreamAsync>b__0()
			{
				throw null;
			}

			// Token: 0x0400064C RID: 1612
			[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Uri uri;
		}

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000098")]
		[StructLayout(3)]
		private struct <GetNonFileStreamAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x06000CBA RID: 3258 RVA: 0x00005390 File Offset: 0x00003590
			[global::Cpp2ILInjected.Token(Token = "0x600072E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DACE3C", Offset = "0x1DACE3C", Length = "0x6A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<object>), Member = "FromAsync", MemberParameters = new object[]
			{
				typeof(Func<AsyncCallback, object, IAsyncResult>),
				typeof(Func<IAsyncResult, object>),
				typeof(object)
			}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref XmlDownloadManager.<GetNonFileStreamAsync>d__5)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlRegisteredNonCachedStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(XmlDownloadManager),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCachedStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Stream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00005393 File Offset: 0x00003593
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600072F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD4E0", Offset = "0x1DAD4E0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400064D RID: 1613
			[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400064E RID: 1614
			[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			// Token: 0x0400064F RID: 1615
			[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Uri uri;

			// Token: 0x04000650 RID: 1616
			[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ICredentials credentials;

			// Token: 0x04000651 RID: 1617
			[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IWebProxy proxy;

			// Token: 0x04000652 RID: 1618
			[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public RequestCachePolicy cachePolicy;

			// Token: 0x04000653 RID: 1619
			[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public XmlDownloadManager <>4__this;

			// Token: 0x04000654 RID: 1620
			[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private WebRequest <req>5__2;

			// Token: 0x04000655 RID: 1621
			[global::Cpp2ILInjected.Token(Token = "0x40003B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
