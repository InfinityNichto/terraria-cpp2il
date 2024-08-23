using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200013C RID: 316
	[global::Cpp2ILInjected.Token(Token = "0x20001C3")]
	[Serializable]
	public class ProtocolViolationException : InvalidOperationException, ISerializable
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x000049B5 File Offset: 0x00002BB5
		[global::Cpp2ILInjected.Token(Token = "0x6000ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B78", Offset = "0x1F10B78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		public ProtocolViolationException()
		{
			throw null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000049B8 File Offset: 0x00002BB8
		[global::Cpp2ILInjected.Token(Token = "0x6000ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F103F8", Offset = "0x1F103F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpProtocolUtils), Member = "string2date", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "CheckWriteOverflow", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ProtocolViolationException(string message)
		{
			throw null;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000049BB File Offset: 0x00002BBB
		[global::Cpp2ILInjected.Token(Token = "0x6000ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B80", Offset = "0x1F10B80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000049BE File Offset: 0x00002BBE
		[global::Cpp2ILInjected.Token(Token = "0x6000AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B88", Offset = "0x1F10B88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000049C1 File Offset: 0x00002BC1
		[global::Cpp2ILInjected.Token(Token = "0x6000AD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B90", Offset = "0x1F10B90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
