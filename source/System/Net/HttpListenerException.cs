using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200010C RID: 268
	[global::Cpp2ILInjected.Token(Token = "0x2000191")]
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00004871 File Offset: 0x00002A71
		[global::Cpp2ILInjected.Token(Token = "0x6000A49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C524", Offset = "0x1F0C524", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HttpListenerException()
		{
			throw null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00004874 File Offset: 0x00002A74
		[global::Cpp2ILInjected.Token(Token = "0x6000A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C588", Offset = "0x1F0C588", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public HttpListenerException(int errorCode)
		{
			throw null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00004877 File Offset: 0x00002A77
		[global::Cpp2ILInjected.Token(Token = "0x6000A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C590", Offset = "0x1F0C590", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "AddSpecial", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(ListenerPrefix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "AddPrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		public HttpListenerException(int errorCode, string message)
		{
			throw null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0000487A File Offset: 0x00002A7A
		[global::Cpp2ILInjected.Token(Token = "0x6000A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C598", Offset = "0x1F0C598", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0000487D File Offset: 0x00002A7D
		[global::Cpp2ILInjected.Token(Token = "0x17000215")]
		public override int ErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C5A0", Offset = "0x1F0C5A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
