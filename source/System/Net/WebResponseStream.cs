using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001BB RID: 443
	[global::Cpp2ILInjected.Token(Token = "0x2000298")]
	internal class WebResponseStream : WebConnectionStream
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00005D53 File Offset: 0x00003F53
		[global::Cpp2ILInjected.Token(Token = "0x17000438")]
		public WebRequestStream RequestStream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194A4", Offset = "0x1E194A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00005D56 File Offset: 0x00003F56
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x00005D59 File Offset: 0x00003F59
		[global::Cpp2ILInjected.Token(Token = "0x17000439")]
		public WebHeaderCollection Headers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001255")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194AC", Offset = "0x1E194AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194B4", Offset = "0x1E194B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00005D5C File Offset: 0x00003F5C
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00005D5F File Offset: 0x00003F5F
		[global::Cpp2ILInjected.Token(Token = "0x1700043A")]
		public HttpStatusCode StatusCode
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194BC", Offset = "0x1E194BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001258")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194C4", Offset = "0x1E194C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00005D62 File Offset: 0x00003F62
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x00005D65 File Offset: 0x00003F65
		[global::Cpp2ILInjected.Token(Token = "0x1700043B")]
		public string StatusDescription
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001259")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194CC", Offset = "0x1E194CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600125A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194D4", Offset = "0x1E194D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00005D68 File Offset: 0x00003F68
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00005D6B File Offset: 0x00003F6B
		[global::Cpp2ILInjected.Token(Token = "0x1700043C")]
		public Version Version
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600125B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194DC", Offset = "0x1E194DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600125C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194E4", Offset = "0x1E194E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00005D6E File Offset: 0x00003F6E
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00005D71 File Offset: 0x00003F71
		[global::Cpp2ILInjected.Token(Token = "0x1700043D")]
		public bool KeepAlive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600125D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194EC", Offset = "0x1E194EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600125E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E194F4", Offset = "0x1E194F4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00005D74 File Offset: 0x00003F74
		[global::Cpp2ILInjected.Token(Token = "0x600125F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E153D0", Offset = "0x1E153D0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebConnection),
			typeof(WebOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebResponseStream(WebRequestStream request)
		{
			throw null;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00005D77 File Offset: 0x00003F77
		[global::Cpp2ILInjected.Token(Token = "0x1700043E")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001260")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19500", Offset = "0x1E19500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00005D7A File Offset: 0x00003F7A
		[global::Cpp2ILInjected.Token(Token = "0x1700043F")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19508", Offset = "0x1E19508", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00005D7D File Offset: 0x00003F7D
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00005D80 File Offset: 0x00003F80
		[global::Cpp2ILInjected.Token(Token = "0x17000440")]
		private bool ChunkedRead
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001262")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19510", Offset = "0x1E19510", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19518", Offset = "0x1E19518", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00005D83 File Offset: 0x00003F83
		[global::Cpp2ILInjected.Token(Token = "0x6001264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E19524", Offset = "0x1E19524", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebResponseStream.<ReadAsync>d__40) }, MemberParameters = new object[] { typeof(ref WebResponseStream.<ReadAsync>d__40) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00005D86 File Offset: 0x00003F86
		[global::Cpp2ILInjected.Token(Token = "0x6001265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E19658", Offset = "0x1E19658", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<ReadAllAsyncInner>d__47), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<CancellationToken, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Func`2<CancellationToken, Task`1<T>>",
			typeof(int),
			typeof(Action),
			typeof(Func<bool>),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00005D89 File Offset: 0x00003F89
		[global::Cpp2ILInjected.Token(Token = "0x6001266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E198D8", Offset = "0x1E198D8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferedReadStream), Member = "TryReadFromBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			throw null;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00005D8C File Offset: 0x00003F8C
		[global::Cpp2ILInjected.Token(Token = "0x6001267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E199A4", Offset = "0x1E199A4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool CheckAuthHeader(string headerName)
		{
			throw null;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00005D8F File Offset: 0x00003F8F
		[global::Cpp2ILInjected.Token(Token = "0x17000441")]
		private bool ExpectContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001268")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19A14", Offset = "0x1E19A14", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00005D92 File Offset: 0x00003F92
		[global::Cpp2ILInjected.Token(Token = "0x6001269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E19A9C", Offset = "0x1E19A9C", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "get_ExpectContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferedReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(BufferOffsetSize)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(ContentDecodeStream.Mode)
		}, ReturnType = typeof(ContentDecodeStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(HttpRequestHeader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FixedSizeReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void Initialize(BufferOffsetSize buffer)
		{
			throw null;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00005D95 File Offset: 0x00003F95
		[global::Cpp2ILInjected.Token(Token = "0x600126A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E19F6C", Offset = "0x1E19F6C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<ReadAllAsync>d__48), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebResponseStream.<ReadAllAsyncInner>d__47) }, MemberParameters = new object[] { typeof(ref WebResponseStream.<ReadAllAsyncInner>d__47) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00005D98 File Offset: 0x00003F98
		[global::Cpp2ILInjected.Token(Token = "0x600126B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1A06C", Offset = "0x1E1A06C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebResponseStream.<ReadAllAsync>d__48) }, MemberParameters = new object[] { typeof(ref WebResponseStream.<ReadAllAsync>d__48) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00005D9B File Offset: 0x00003F9B
		[global::Cpp2ILInjected.Token(Token = "0x600126C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1A160", Offset = "0x1E1A160", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00005D9E File Offset: 0x00003F9E
		[global::Cpp2ILInjected.Token(Token = "0x600126D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1A1FC", Offset = "0x1E1A1FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		protected override void Close_internal(ref bool disposed)
		{
			throw null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00005DA1 File Offset: 0x00003FA1
		[global::Cpp2ILInjected.Token(Token = "0x600126E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1A278", Offset = "0x1E1A278", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<ReadAsync>d__40), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(WebExceptionInternalStatus),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			throw null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[global::Cpp2ILInjected.Token(Token = "0x600126F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15448", Offset = "0x1E15448", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebResponseStream.<InitReadAsync>d__52) }, MemberParameters = new object[] { typeof(ref WebResponseStream.<InitReadAsync>d__52) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task InitReadAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00005DA7 File Offset: 0x00003FA7
		[global::Cpp2ILInjected.Token(Token = "0x6001270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1A504", Offset = "0x1E1A504", Length = "0x70C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream.<InitReadAsync>d__52), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnection), Member = "ReadLine", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "DoContinueDelegate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			throw null;
		}

		// Token: 0x04000AB4 RID: 2740
		[global::Cpp2ILInjected.Token(Token = "0x4000E5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private WebReadStream innerStream;

		// Token: 0x04000AB5 RID: 2741
		[global::Cpp2ILInjected.Token(Token = "0x4000E5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool nextReadCalled;

		// Token: 0x04000AB6 RID: 2742
		[global::Cpp2ILInjected.Token(Token = "0x4000E5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool bufferedEntireContent;

		// Token: 0x04000AB7 RID: 2743
		[global::Cpp2ILInjected.Token(Token = "0x4000E5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private WebCompletionSource pendingRead;

		// Token: 0x04000AB8 RID: 2744
		[global::Cpp2ILInjected.Token(Token = "0x4000E5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private object locker;

		// Token: 0x04000AB9 RID: 2745
		[global::Cpp2ILInjected.Token(Token = "0x4000E60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int nestedRead;

		// Token: 0x04000ABA RID: 2746
		[global::Cpp2ILInjected.Token(Token = "0x4000E61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private bool read_eof;

		// Token: 0x04000ABB RID: 2747
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly WebRequestStream <RequestStream>k__BackingField;

		// Token: 0x04000ABC RID: 2748
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000ABD RID: 2749
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private HttpStatusCode <StatusCode>k__BackingField;

		// Token: 0x04000ABE RID: 2750
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string <StatusDescription>k__BackingField;

		// Token: 0x04000ABF RID: 2751
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private Version <Version>k__BackingField;

		// Token: 0x04000AC0 RID: 2752
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool <KeepAlive>k__BackingField;

		// Token: 0x04000AC1 RID: 2753
		[global::Cpp2ILInjected.Token(Token = "0x4000E68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal readonly string ME;

		// Token: 0x04000AC2 RID: 2754
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private bool <ChunkedRead>k__BackingField;

		// Token: 0x02000440 RID: 1088
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000299")]
		[StructLayout(3)]
		private struct <ReadAsync>d__40 : IAsyncStateMachine
		{
			// Token: 0x06001E89 RID: 7817 RVA: 0x0000841A File Offset: 0x0000661A
			[global::Cpp2ILInjected.Token(Token = "0x6001271")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1AC10", Offset = "0x1E1AC10", Length = "0x828")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(WebResponseStream.<ReadAsync>d__40)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref WebResponseStream.<ReadAsync>d__40)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebResponseStream.<ReadAsync>d__40)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebResponseStream.<ReadAsync>d__40)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception),
				typeof(string)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x0000841D File Offset: 0x0000661D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001272")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B438", Offset = "0x1E1B438", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400132E RID: 4910
			[global::Cpp2ILInjected.Token(Token = "0x4000E6A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400132F RID: 4911
			[global::Cpp2ILInjected.Token(Token = "0x4000E6B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001330 RID: 4912
			[global::Cpp2ILInjected.Token(Token = "0x4000E6C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x04001331 RID: 4913
			[global::Cpp2ILInjected.Token(Token = "0x4000E6D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			// Token: 0x04001332 RID: 4914
			[global::Cpp2ILInjected.Token(Token = "0x4000E6E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int offset;

			// Token: 0x04001333 RID: 4915
			[global::Cpp2ILInjected.Token(Token = "0x4000E6F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public int count;

			// Token: 0x04001334 RID: 4916
			[global::Cpp2ILInjected.Token(Token = "0x4000E70")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public WebResponseStream <>4__this;

			// Token: 0x04001335 RID: 4917
			[global::Cpp2ILInjected.Token(Token = "0x4000E71")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private WebCompletionSource <completion>5__2;

			// Token: 0x04001336 RID: 4918
			[global::Cpp2ILInjected.Token(Token = "0x4000E72")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <nbytes>5__3;

			// Token: 0x04001337 RID: 4919
			[global::Cpp2ILInjected.Token(Token = "0x4000E73")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private Exception <throwMe>5__4;

			// Token: 0x04001338 RID: 4920
			[global::Cpp2ILInjected.Token(Token = "0x4000E74")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001339 RID: 4921
			[global::Cpp2ILInjected.Token(Token = "0x4000E75")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000441 RID: 1089
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200029A")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06001E8B RID: 7819 RVA: 0x00008420 File Offset: 0x00006620
			[global::Cpp2ILInjected.Token(Token = "0x6001273")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E198D0", Offset = "0x1E198D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass41_0()
			{
				throw null;
			}

			// Token: 0x06001E8C RID: 7820 RVA: 0x00008423 File Offset: 0x00006623
			[global::Cpp2ILInjected.Token(Token = "0x6001274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B490", Offset = "0x1E1B490", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal Task<int> <ProcessRead>b__0(CancellationToken ct)
			{
				throw null;
			}

			// Token: 0x06001E8D RID: 7821 RVA: 0x00008426 File Offset: 0x00006626
			[global::Cpp2ILInjected.Token(Token = "0x6001275")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B4B8", Offset = "0x1E1B4B8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
			internal void <ProcessRead>b__1()
			{
				throw null;
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x00008429 File Offset: 0x00006629
			[global::Cpp2ILInjected.Token(Token = "0x6001276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B4E0", Offset = "0x1E1B4E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
			internal bool <ProcessRead>b__2()
			{
				throw null;
			}

			// Token: 0x0400133A RID: 4922
			[global::Cpp2ILInjected.Token(Token = "0x4000E76")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WebResponseStream <>4__this;

			// Token: 0x0400133B RID: 4923
			[global::Cpp2ILInjected.Token(Token = "0x4000E77")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public byte[] buffer;

			// Token: 0x0400133C RID: 4924
			[global::Cpp2ILInjected.Token(Token = "0x4000E78")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int offset;

			// Token: 0x0400133D RID: 4925
			[global::Cpp2ILInjected.Token(Token = "0x4000E79")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public int size;
		}

		// Token: 0x02000442 RID: 1090
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200029B")]
		[StructLayout(3)]
		private struct <ReadAllAsyncInner>d__47 : IAsyncStateMachine
		{
			// Token: 0x06001E8F RID: 7823 RVA: 0x0000842C File Offset: 0x0000662C
			[global::Cpp2ILInjected.Token(Token = "0x6001277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B4EC", Offset = "0x1E1B4EC", Length = "0x50C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<int>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(WebResponseStream.<ReadAllAsyncInner>d__47)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref WebResponseStream.<ReadAllAsyncInner>d__47)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E90 RID: 7824 RVA: 0x0000842F File Offset: 0x0000662F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1B9F8", Offset = "0x1E1B9F8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400133E RID: 4926
			[global::Cpp2ILInjected.Token(Token = "0x4000E7A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400133F RID: 4927
			[global::Cpp2ILInjected.Token(Token = "0x4000E7B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			// Token: 0x04001340 RID: 4928
			[global::Cpp2ILInjected.Token(Token = "0x4000E7C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x04001341 RID: 4929
			[global::Cpp2ILInjected.Token(Token = "0x4000E7D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebResponseStream <>4__this;

			// Token: 0x04001342 RID: 4930
			[global::Cpp2ILInjected.Token(Token = "0x4000E7E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private long <maximumSize>5__2;

			// Token: 0x04001343 RID: 4931
			[global::Cpp2ILInjected.Token(Token = "0x4000E7F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private MemoryStream <ms>5__3;

			// Token: 0x04001344 RID: 4932
			[global::Cpp2ILInjected.Token(Token = "0x4000E80")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private byte[] <buffer>5__4;

			// Token: 0x04001345 RID: 4933
			[global::Cpp2ILInjected.Token(Token = "0x4000E81")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000443 RID: 1091
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200029C")]
		[StructLayout(3)]
		private struct <ReadAllAsync>d__48 : IAsyncStateMachine
		{
			// Token: 0x06001E91 RID: 7825 RVA: 0x00008432 File Offset: 0x00006632
			[global::Cpp2ILInjected.Token(Token = "0x6001279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1BA50", Offset = "0x1E1BA50", Length = "0x83C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferedReadStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(WebOperation),
				typeof(Stream),
				typeof(BufferOffsetSize)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new object[] { typeof(Task[]) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebResponseStream.<ReadAllAsync>d__48)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebResponseStream.<ReadAllAsync>d__48)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsyncInner", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<byte[]>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E92 RID: 7826 RVA: 0x00008435 File Offset: 0x00006635
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600127A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1C28C", Offset = "0x1E1C28C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001346 RID: 4934
			[global::Cpp2ILInjected.Token(Token = "0x4000E82")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001347 RID: 4935
			[global::Cpp2ILInjected.Token(Token = "0x4000E83")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001348 RID: 4936
			[global::Cpp2ILInjected.Token(Token = "0x4000E84")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebResponseStream <>4__this;

			// Token: 0x04001349 RID: 4937
			[global::Cpp2ILInjected.Token(Token = "0x4000E85")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x0400134A RID: 4938
			[global::Cpp2ILInjected.Token(Token = "0x4000E86")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool resending;

			// Token: 0x0400134B RID: 4939
			[global::Cpp2ILInjected.Token(Token = "0x4000E87")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private WebCompletionSource <completion>5__2;

			// Token: 0x0400134C RID: 4940
			[global::Cpp2ILInjected.Token(Token = "0x4000E88")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private CancellationTokenSource <timeoutCts>5__3;

			// Token: 0x0400134D RID: 4941
			[global::Cpp2ILInjected.Token(Token = "0x4000E89")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private Task <timeoutTask>5__4;

			// Token: 0x0400134E RID: 4942
			[global::Cpp2ILInjected.Token(Token = "0x4000E8A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400134F RID: 4943
			[global::Cpp2ILInjected.Token(Token = "0x4000E8B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000444 RID: 1092
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200029D")]
		[StructLayout(3)]
		private struct <InitReadAsync>d__52 : IAsyncStateMachine
		{
			// Token: 0x06001E93 RID: 7827 RVA: 0x00008438 File Offset: 0x00006638
			[global::Cpp2ILInjected.Token(Token = "0x600127B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1C298", Offset = "0x1E1C298", Length = "0x5B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
			{
				typeof(BufferOffsetSize),
				typeof(ref int),
				typeof(ref ReadState)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(WebResponseStream.<InitReadAsync>d__52)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref WebResponseStream.<InitReadAsync>d__52)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
			{
				typeof(WebExceptionStatus),
				typeof(Exception),
				typeof(string)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E94 RID: 7828 RVA: 0x0000843B File Offset: 0x0000663B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600127C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1C84C", Offset = "0x1E1C84C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001350 RID: 4944
			[global::Cpp2ILInjected.Token(Token = "0x4000E8C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001351 RID: 4945
			[global::Cpp2ILInjected.Token(Token = "0x4000E8D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001352 RID: 4946
			[global::Cpp2ILInjected.Token(Token = "0x4000E8E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebResponseStream <>4__this;

			// Token: 0x04001353 RID: 4947
			[global::Cpp2ILInjected.Token(Token = "0x4000E8F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001354 RID: 4948
			[global::Cpp2ILInjected.Token(Token = "0x4000E90")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private BufferOffsetSize <buffer>5__2;

			// Token: 0x04001355 RID: 4949
			[global::Cpp2ILInjected.Token(Token = "0x4000E91")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ReadState <state>5__3;

			// Token: 0x04001356 RID: 4950
			[global::Cpp2ILInjected.Token(Token = "0x4000E92")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			private int <position>5__4;

			// Token: 0x04001357 RID: 4951
			[global::Cpp2ILInjected.Token(Token = "0x4000E93")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
