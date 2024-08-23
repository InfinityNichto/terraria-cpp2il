using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000141 RID: 321
	[global::Cpp2ILInjected.Token(Token = "0x20001C8")]
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x00004A00 File Offset: 0x00002C00
		[global::Cpp2ILInjected.Token(Token = "0x6000AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11720", Offset = "0x1F11720", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		public WebException()
		{
			throw null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00004A03 File Offset: 0x00002C03
		[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F428", Offset = "0x1F0F428", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref FileStream),
			typeof(ref byte[]),
			typeof(ref byte[]),
			typeof(ref byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetValuesToUpload", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public WebException(string message)
		{
			throw null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00004A06 File Offset: 0x00002C06
		[global::Cpp2ILInjected.Token(Token = "0x6000AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11730", Offset = "0x1F11730", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenRead", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(byte[]),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadFile", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadValues", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NameValueCollection)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetExceptionToPropagate", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public WebException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00004A09 File Offset: 0x00002C09
		[global::Cpp2ILInjected.Token(Token = "0x6000AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F67C", Offset = "0x1F0F67C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TranslateConnectException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<RunWithTimeoutWorker>d__241`1", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "SetDisposed", MemberParameters = new object[] { typeof(ref ExceptionDispatchInfo) }, ReturnType = typeof(ValueTuple<ExceptionDispatchInfo, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		public WebException(string message, WebExceptionStatus status)
		{
			throw null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00004A0C File Offset: 0x00002C0C
		[global::Cpp2ILInjected.Token(Token = "0x6000AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F5D0", Offset = "0x1F0F5D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "GetException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse),
			typeof(WebExceptionInternalStatus)
		}, ReturnType = typeof(void))]
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
		{
			throw null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00004A0F File Offset: 0x00002C0F
		[global::Cpp2ILInjected.Token(Token = "0x6000AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11740", Offset = "0x1F11740", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(FtpStatusCode),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new object[]
		{
			typeof(HttpWebResponse),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkStream), Member = "ThrowExpectingChunkTrailer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
			throw null;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00004A12 File Offset: 0x00002C12
		[global::Cpp2ILInjected.Token(Token = "0x6000AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1176C", Offset = "0x1F1176C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_CacheEntryNotFoundException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestProhibitedByCachePolicyException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
		{
			throw null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00004A15 File Offset: 0x00002C15
		[global::Cpp2ILInjected.Token(Token = "0x6000AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11754", Offset = "0x1F11754", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse),
			typeof(WebExceptionInternalStatus)
		}, ReturnType = typeof(void))]
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
			throw null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00004A18 File Offset: 0x00002C18
		[global::Cpp2ILInjected.Token(Token = "0x6000AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1184C", Offset = "0x1F1184C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_IsolatedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(WebExceptionInternalStatus),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse),
			typeof(WebExceptionInternalStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		{
			throw null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00004A1B File Offset: 0x00002C1B
		[global::Cpp2ILInjected.Token(Token = "0x6000AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1193C", Offset = "0x1F1193C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00004A1E File Offset: 0x00002C1E
		[global::Cpp2ILInjected.Token(Token = "0x6000AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1194C", Offset = "0x1F1194C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00004A21 File Offset: 0x00002C21
		[global::Cpp2ILInjected.Token(Token = "0x6000AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11958", Offset = "0x1F11958", Length = "0x8")]
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00004A24 File Offset: 0x00002C24
		[global::Cpp2ILInjected.Token(Token = "0x17000232")]
		public WebExceptionStatus Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11960", Offset = "0x1F11960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00004A27 File Offset: 0x00002C27
		[global::Cpp2ILInjected.Token(Token = "0x17000233")]
		public WebResponse Response
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11968", Offset = "0x1F11968", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00004A2A File Offset: 0x00002C2A
		[global::Cpp2ILInjected.Token(Token = "0x17000234")]
		internal WebExceptionInternalStatus InternalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11970", Offset = "0x1F11970", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400077C RID: 1916
		[global::Cpp2ILInjected.Token(Token = "0x4000995")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private WebExceptionStatus m_Status;

		// Token: 0x0400077D RID: 1917
		[global::Cpp2ILInjected.Token(Token = "0x4000996")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private WebResponse m_Response;

		// Token: 0x0400077E RID: 1918
		[global::Cpp2ILInjected.Token(Token = "0x4000997")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus;
	}
}
