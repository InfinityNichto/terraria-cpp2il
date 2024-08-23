using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200014E RID: 334
	[global::Cpp2ILInjected.Token(Token = "0x20001DF")]
	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00004C7F File Offset: 0x00002E7F
		[global::Cpp2ILInjected.Token(Token = "0x6000BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D28", Offset = "0x1F20D28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(Uri),
			typeof(FtpStatusCode),
			typeof(string),
			typeof(DateTime),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(HttpStatusCode),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected WebResponse()
		{
			throw null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00004C82 File Offset: 0x00002E82
		[global::Cpp2ILInjected.Token(Token = "0x6000BD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D30", Offset = "0x1F20D30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00004C85 File Offset: 0x00002E85
		[global::Cpp2ILInjected.Token(Token = "0x6000BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D38", Offset = "0x1F20D38", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00004C88 File Offset: 0x00002E88
		[global::Cpp2ILInjected.Token(Token = "0x6000BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D44", Offset = "0x1F20D44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00004C8B File Offset: 0x00002E8B
		[global::Cpp2ILInjected.Token(Token = "0x6000BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D48", Offset = "0x1F20D48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00004C8E File Offset: 0x00002E8E
		[global::Cpp2ILInjected.Token(Token = "0x6000BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20D4C", Offset = "0x1F20D4C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.WebClientWriteStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00004C91 File Offset: 0x00002E91
		[global::Cpp2ILInjected.Token(Token = "0x6000BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20DB8", Offset = "0x1F20DB8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00004C94 File Offset: 0x00002E94
		[global::Cpp2ILInjected.Token(Token = "0x1700026D")]
		public virtual bool IsFromCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E44", Offset = "0x1F20E44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00004C97 File Offset: 0x00002E97
		[global::Cpp2ILInjected.Token(Token = "0x1700026E")]
		internal bool InternalSetFromCache
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E4C", Offset = "0x1F20E4C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00004C9A File Offset: 0x00002E9A
		[global::Cpp2ILInjected.Token(Token = "0x1700026F")]
		internal virtual bool IsCacheFresh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E58", Offset = "0x1F20E58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000263 RID: 611
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00004C9D File Offset: 0x00002E9D
		[global::Cpp2ILInjected.Token(Token = "0x17000270")]
		internal bool InternalSetIsCacheFresh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E60", Offset = "0x1F20E60", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[global::Cpp2ILInjected.Token(Token = "0x17000271")]
		public virtual bool IsMutuallyAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E6C", Offset = "0x1F20E6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00004CA3 File Offset: 0x00002EA3
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00004CA6 File Offset: 0x00002EA6
		[global::Cpp2ILInjected.Token(Token = "0x17000272")]
		public virtual long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E74", Offset = "0x1F20E74", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20E98", Offset = "0x1F20E98", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00004CA9 File Offset: 0x00002EA9
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00004CAC File Offset: 0x00002EAC
		[global::Cpp2ILInjected.Token(Token = "0x17000273")]
		public virtual string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20EBC", Offset = "0x1F20EBC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20EE0", Offset = "0x1F20EE0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00004CAF File Offset: 0x00002EAF
		[global::Cpp2ILInjected.Token(Token = "0x6000BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20F04", Offset = "0x1F20F04", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Stream GetResponseStream()
		{
			throw null;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00004CB2 File Offset: 0x00002EB2
		[global::Cpp2ILInjected.Token(Token = "0x17000274")]
		public virtual Uri ResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20F28", Offset = "0x1F20F28", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00004CB5 File Offset: 0x00002EB5
		[global::Cpp2ILInjected.Token(Token = "0x17000275")]
		public virtual WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20F4C", Offset = "0x1F20F4C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00004CB8 File Offset: 0x00002EB8
		[global::Cpp2ILInjected.Token(Token = "0x17000276")]
		public virtual bool SupportsHeaders
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20F70", Offset = "0x1F20F70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040007E0 RID: 2016
		[global::Cpp2ILInjected.Token(Token = "0x4000A1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_IsCacheFresh;

		// Token: 0x040007E1 RID: 2017
		[global::Cpp2ILInjected.Token(Token = "0x4000A1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool m_IsFromCache;
	}
}
