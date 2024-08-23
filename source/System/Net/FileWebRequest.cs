using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000177 RID: 375
	[global::Cpp2ILInjected.Token(Token = "0x200021A")]
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x00005051 File Offset: 0x00003251
		[global::Cpp2ILInjected.Token(Token = "0x6000D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35E5C", Offset = "0x1F35E5C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequestCreator), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollectionType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal FileWebRequest(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00005054 File Offset: 0x00003254
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x6000D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F35FBC", Offset = "0x1F35FBC", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00005057 File Offset: 0x00003257
		[global::Cpp2ILInjected.Token(Token = "0x6000D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F36364", Offset = "0x1F36364", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0000505A File Offset: 0x0000325A
		[global::Cpp2ILInjected.Token(Token = "0x6000D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F36370", Offset = "0x1F36370", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0000505D File Offset: 0x0000325D
		[global::Cpp2ILInjected.Token(Token = "0x170002C9")]
		internal bool Aborted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36610", Offset = "0x1F36610", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00005060 File Offset: 0x00003260
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00005063 File Offset: 0x00003263
		[global::Cpp2ILInjected.Token(Token = "0x170002CA")]
		public override string ConnectionGroupName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36620", Offset = "0x1F36620", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36628", Offset = "0x1F36628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00005066 File Offset: 0x00003266
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00005069 File Offset: 0x00003269
		[global::Cpp2ILInjected.Token(Token = "0x170002CB")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36630", Offset = "0x1F36630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36638", Offset = "0x1F36638", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x0000506F File Offset: 0x0000326F
		[global::Cpp2ILInjected.Token(Token = "0x170002CC")]
		public override string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F366B8", Offset = "0x1F366B8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36704", Offset = "0x1F36704", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00005072 File Offset: 0x00003272
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00005075 File Offset: 0x00003275
		[global::Cpp2ILInjected.Token(Token = "0x170002CD")]
		public override ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36760", Offset = "0x1F36760", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36768", Offset = "0x1F36768", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00005078 File Offset: 0x00003278
		[global::Cpp2ILInjected.Token(Token = "0x170002CE")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36770", Offset = "0x1F36770", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0000507B File Offset: 0x0000327B
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0000507E File Offset: 0x0000327E
		[global::Cpp2ILInjected.Token(Token = "0x170002CF")]
		public override string Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36778", Offset = "0x1F36778", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36780", Offset = "0x1F36780", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "IsBlankString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00005081 File Offset: 0x00003281
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00005084 File Offset: 0x00003284
		[global::Cpp2ILInjected.Token(Token = "0x170002D0")]
		public override bool PreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36854", Offset = "0x1F36854", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3685C", Offset = "0x1F3685C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00005087 File Offset: 0x00003287
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0000508A File Offset: 0x0000328A
		[global::Cpp2ILInjected.Token(Token = "0x170002D1")]
		public override IWebProxy Proxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36868", Offset = "0x1F36868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36870", Offset = "0x1F36870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0000508D File Offset: 0x0000328D
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00005090 File Offset: 0x00003290
		[global::Cpp2ILInjected.Token(Token = "0x170002D2")]
		public override int Timeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36878", Offset = "0x1F36878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36880", Offset = "0x1F36880", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00005093 File Offset: 0x00003293
		[global::Cpp2ILInjected.Token(Token = "0x170002D3")]
		public override Uri RequestUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F36904", Offset = "0x1F36904", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00005096 File Offset: 0x00003296
		[global::Cpp2ILInjected.Token(Token = "0x6000D70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3690C", Offset = "0x1F3690C", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebRequest), Member = "CanGetRequestStream", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00005099 File Offset: 0x00003299
		[global::Cpp2ILInjected.Token(Token = "0x6000D71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F36D20", Offset = "0x1F36D20", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0000509C File Offset: 0x0000329C
		[global::Cpp2ILInjected.Token(Token = "0x6000D72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F36CB4", Offset = "0x1F36CB4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KnownHttpVerb), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(KnownHttpVerb))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool CanGetRequestStream()
		{
			throw null;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0000509F File Offset: 0x0000329F
		[global::Cpp2ILInjected.Token(Token = "0x6000D73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F36FEC", Offset = "0x1F36FEC", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000050A2 File Offset: 0x000032A2
		[global::Cpp2ILInjected.Token(Token = "0x6000D74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F372E0", Offset = "0x1F372E0", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "WaitForCompletion", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000050A5 File Offset: 0x000032A5
		[global::Cpp2ILInjected.Token(Token = "0x6000D75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F375D4", Offset = "0x1F375D4", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override Stream GetRequestStream()
		{
			throw null;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000050A8 File Offset: 0x000032A8
		[global::Cpp2ILInjected.Token(Token = "0x6000D76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F37918", Offset = "0x1F37918", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override WebResponse GetResponse()
		{
			throw null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000050AB File Offset: 0x000032AB
		[global::Cpp2ILInjected.Token(Token = "0x6000D77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F37C60", Offset = "0x1F37C60", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void GetRequestStreamCallback(object state)
		{
			throw null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000050AE File Offset: 0x000032AE
		[global::Cpp2ILInjected.Token(Token = "0x6000D78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F37EF0", Offset = "0x1F37EF0", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private static void GetResponseCallback(object state)
		{
			throw null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000050B1 File Offset: 0x000032B1
		[global::Cpp2ILInjected.Token(Token = "0x6000D79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38480", Offset = "0x1F38480", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void UnblockReader()
		{
			throw null;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000050B4 File Offset: 0x000032B4
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x000050B7 File Offset: 0x000032B7
		[global::Cpp2ILInjected.Token(Token = "0x170002D4")]
		public override bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F38558", Offset = "0x1F38558", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F38580", Offset = "0x1F38580", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotSupportedException", ReturnType = typeof(NotSupportedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000050BA File Offset: 0x000032BA
		[global::Cpp2ILInjected.Token(Token = "0x6000D7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F385A8", Offset = "0x1F385A8", Length = "0x3A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override void Abort()
		{
			throw null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000050BD File Offset: 0x000032BD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38948", Offset = "0x1F38948", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static FileWebRequest()
		{
			throw null;
		}

		// Token: 0x040008E3 RID: 2275
		[global::Cpp2ILInjected.Token(Token = "0x4000B50")]
		private static WaitCallback s_GetRequestStreamCallback;

		// Token: 0x040008E4 RID: 2276
		[global::Cpp2ILInjected.Token(Token = "0x4000B51")]
		private static WaitCallback s_GetResponseCallback;

		// Token: 0x040008E5 RID: 2277
		[global::Cpp2ILInjected.Token(Token = "0x4000B52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string m_connectionGroupName;

		// Token: 0x040008E6 RID: 2278
		[global::Cpp2ILInjected.Token(Token = "0x4000B53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private long m_contentLength;

		// Token: 0x040008E7 RID: 2279
		[global::Cpp2ILInjected.Token(Token = "0x4000B54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ICredentials m_credentials;

		// Token: 0x040008E8 RID: 2280
		[global::Cpp2ILInjected.Token(Token = "0x4000B55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private FileAccess m_fileAccess;

		// Token: 0x040008E9 RID: 2281
		[global::Cpp2ILInjected.Token(Token = "0x4000B56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private WebHeaderCollection m_headers;

		// Token: 0x040008EA RID: 2282
		[global::Cpp2ILInjected.Token(Token = "0x4000B57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string m_method;

		// Token: 0x040008EB RID: 2283
		[global::Cpp2ILInjected.Token(Token = "0x4000B58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool m_preauthenticate;

		// Token: 0x040008EC RID: 2284
		[global::Cpp2ILInjected.Token(Token = "0x4000B59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private IWebProxy m_proxy;

		// Token: 0x040008ED RID: 2285
		[global::Cpp2ILInjected.Token(Token = "0x4000B5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ManualResetEvent m_readerEvent;

		// Token: 0x040008EE RID: 2286
		[global::Cpp2ILInjected.Token(Token = "0x4000B5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool m_readPending;

		// Token: 0x040008EF RID: 2287
		[global::Cpp2ILInjected.Token(Token = "0x4000B5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private WebResponse m_response;

		// Token: 0x040008F0 RID: 2288
		[global::Cpp2ILInjected.Token(Token = "0x4000B5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Stream m_stream;

		// Token: 0x040008F1 RID: 2289
		[global::Cpp2ILInjected.Token(Token = "0x4000B5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool m_syncHint;

		// Token: 0x040008F2 RID: 2290
		[global::Cpp2ILInjected.Token(Token = "0x4000B5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private int m_timeout;

		// Token: 0x040008F3 RID: 2291
		[global::Cpp2ILInjected.Token(Token = "0x4000B60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private Uri m_uri;

		// Token: 0x040008F4 RID: 2292
		[global::Cpp2ILInjected.Token(Token = "0x4000B61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool m_writePending;

		// Token: 0x040008F5 RID: 2293
		[global::Cpp2ILInjected.Token(Token = "0x4000B62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool m_writing;

		// Token: 0x040008F6 RID: 2294
		[global::Cpp2ILInjected.Token(Token = "0x4000B63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private LazyAsyncResult m_WriteAResult;

		// Token: 0x040008F7 RID: 2295
		[global::Cpp2ILInjected.Token(Token = "0x4000B64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private LazyAsyncResult m_ReadAResult;

		// Token: 0x040008F8 RID: 2296
		[global::Cpp2ILInjected.Token(Token = "0x4000B65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private int m_Aborted;
	}
}
