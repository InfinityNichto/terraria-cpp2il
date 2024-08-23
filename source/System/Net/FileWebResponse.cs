using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200017A RID: 378
	[global::Cpp2ILInjected.Token(Token = "0x200021D")]
	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx
	{
		// Token: 0x06000C2D RID: 3117 RVA: 0x000050E7 File Offset: 0x000032E7
		[global::Cpp2ILInjected.Token(Token = "0x6000D8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F381E0", Offset = "0x1F381E0", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponseCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollectionType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
		{
			throw null;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000050EA File Offset: 0x000032EA
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x6000D8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39114", Offset = "0x1F39114", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000050ED File Offset: 0x000032ED
		[global::Cpp2ILInjected.Token(Token = "0x6000D8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3935C", Offset = "0x1F3935C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000050F0 File Offset: 0x000032F0
		[global::Cpp2ILInjected.Token(Token = "0x6000D8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39368", Offset = "0x1F39368", Length = "0x1B8")]
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
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000050F3 File Offset: 0x000032F3
		[global::Cpp2ILInjected.Token(Token = "0x170002D5")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39520", Offset = "0x1F39520", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000050F6 File Offset: 0x000032F6
		[global::Cpp2ILInjected.Token(Token = "0x170002D6")]
		public override string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F395A8", Offset = "0x1F395A8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000050F9 File Offset: 0x000032F9
		[global::Cpp2ILInjected.Token(Token = "0x170002D7")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F395F4", Offset = "0x1F395F4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000050FC File Offset: 0x000032FC
		[global::Cpp2ILInjected.Token(Token = "0x170002D8")]
		public override bool SupportsHeaders
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3960C", Offset = "0x1F3960C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x000050FF File Offset: 0x000032FF
		[global::Cpp2ILInjected.Token(Token = "0x170002D9")]
		public override Uri ResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F39614", Offset = "0x1F39614", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00005102 File Offset: 0x00003302
		[global::Cpp2ILInjected.Token(Token = "0x6000D94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39538", Offset = "0x1F39538", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "get_ContentLength", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "get_ContentType", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CheckDisposed()
		{
			throw null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00005105 File Offset: 0x00003305
		[global::Cpp2ILInjected.Token(Token = "0x6000D95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3962C", Offset = "0x1F3962C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00005108 File Offset: 0x00003308
		[global::Cpp2ILInjected.Token(Token = "0x6000D96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F396C4", Offset = "0x1F396C4", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void System.Net.ICloseEx.CloseEx(CloseExState closeState)
		{
			throw null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0000510B File Offset: 0x0000330B
		[global::Cpp2ILInjected.Token(Token = "0x6000D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39830", Offset = "0x1F39830", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override Stream GetResponseStream()
		{
			throw null;
		}

		// Token: 0x040008FA RID: 2298
		[global::Cpp2ILInjected.Token(Token = "0x4000B67")]
		private const int DefaultFileStreamBufferSize = 8192;

		// Token: 0x040008FB RID: 2299
		[global::Cpp2ILInjected.Token(Token = "0x4000B68")]
		private const string DefaultFileContentType = "application/octet-stream";

		// Token: 0x040008FC RID: 2300
		[global::Cpp2ILInjected.Token(Token = "0x4000B69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		private bool m_closed;

		// Token: 0x040008FD RID: 2301
		[global::Cpp2ILInjected.Token(Token = "0x4000B6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long m_contentLength;

		// Token: 0x040008FE RID: 2302
		[global::Cpp2ILInjected.Token(Token = "0x4000B6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private FileAccess m_fileAccess;

		// Token: 0x040008FF RID: 2303
		[global::Cpp2ILInjected.Token(Token = "0x4000B6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private WebHeaderCollection m_headers;

		// Token: 0x04000900 RID: 2304
		[global::Cpp2ILInjected.Token(Token = "0x4000B6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Stream m_stream;

		// Token: 0x04000901 RID: 2305
		[global::Cpp2ILInjected.Token(Token = "0x4000B6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Uri m_uri;
	}
}
