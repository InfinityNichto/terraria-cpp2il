using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000306 RID: 774
	[global::Cpp2ILInjected.Token(Token = "0x200041D")]
	[Serializable]
	public class NameValueCollection : NameObjectCollectionBase
	{
		// Token: 0x0600195C RID: 6492 RVA: 0x00007571 File Offset: 0x00005771
		[global::Cpp2ILInjected.Token(Token = "0x6001C4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DD28", Offset = "0x1E8DD28", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "get_QueryString", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NameValueCollection()
		{
			throw null;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00007574 File Offset: 0x00005774
		[global::Cpp2ILInjected.Token(Token = "0x6001C4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DDDC", Offset = "0x1E8DDDC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NameValueCollection(int capacity)
		{
			throw null;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00007577 File Offset: 0x00005777
		[global::Cpp2ILInjected.Token(Token = "0x6001C4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DEF0", Offset = "0x1E8DEF0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
		{
			throw null;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0000757A File Offset: 0x0000577A
		[global::Cpp2ILInjected.Token(Token = "0x6001C4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8DF90", Offset = "0x1E8DF90", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected NameValueCollection(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0000757D File Offset: 0x0000577D
		[global::Cpp2ILInjected.Token(Token = "0x6001C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E024", Offset = "0x1E8E024", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "AddWithoutValidate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "SetAddVerified", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "AddInternalNotCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ParseHeadersStrict", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(ref WebParseError)
		}, ReturnType = typeof(DataParseStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		protected void InvalidateCachedArrays()
		{
			throw null;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00007580 File Offset: 0x00005780
		[global::Cpp2ILInjected.Token(Token = "0x6001C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E02C", Offset = "0x1E8E02C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string GetAsOneString(ArrayList list)
		{
			throw null;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00007583 File Offset: 0x00005783
		[global::Cpp2ILInjected.Token(Token = "0x6001C52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E1C4", Offset = "0x1E8E1C4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string[] GetAsStringArray(ArrayList list)
		{
			throw null;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00007586 File Offset: 0x00005786
		[global::Cpp2ILInjected.Token(Token = "0x6001C53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E264", Offset = "0x1E8E264", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "CopyFrom", MemberParameters = new object[] { typeof(HttpListenerResponse) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Add(NameValueCollection c)
		{
			throw null;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00007589 File Offset: 0x00005789
		[global::Cpp2ILInjected.Token(Token = "0x6001C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E3B4", Offset = "0x1E8E3B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void Clear()
		{
			throw null;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0000758C File Offset: 0x0000578C
		[global::Cpp2ILInjected.Token(Token = "0x6001C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E480", Offset = "0x1E8E480", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "InternalHasKeys", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool HasKeys()
		{
			throw null;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0000758F File Offset: 0x0000578F
		[global::Cpp2ILInjected.Token(Token = "0x6001C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E490", Offset = "0x1E8E490", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual bool InternalHasKeys()
		{
			throw null;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00007592 File Offset: 0x00005792
		[global::Cpp2ILInjected.Token(Token = "0x6001C57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E4F0", Offset = "0x1E8E4F0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameObjectCollectionBase.NameObjectEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void Add(string name, string value)
		{
			throw null;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00007595 File Offset: 0x00005795
		[global::Cpp2ILInjected.Token(Token = "0x6001C58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E7B0", Offset = "0x1E8E7B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameObjectCollectionBase.NameObjectEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string Get(string name)
		{
			throw null;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00007598 File Offset: 0x00005798
		[global::Cpp2ILInjected.Token(Token = "0x6001C59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E83C", Offset = "0x1E8E83C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameObjectCollectionBase.NameObjectEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "GetAsStringArray", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string[] GetValues(string name)
		{
			throw null;
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0000759B File Offset: 0x0000579B
		[global::Cpp2ILInjected.Token(Token = "0x6001C5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8E8C8", Offset = "0x1E8E8C8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void Set(string name, string value)
		{
			throw null;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000759E File Offset: 0x0000579E
		[global::Cpp2ILInjected.Token(Token = "0x6001C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EA50", Offset = "0x1E8EA50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Remove(string name)
		{
			throw null;
		}

		// Token: 0x17000607 RID: 1543
		[global::Cpp2ILInjected.Token(Token = "0x17000651")]
		public string this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8EC40", Offset = "0x1E8EC40", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 57)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8EC50", Offset = "0x1E8EC50", Length = "0x10")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(HttpRequestHeader),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(HttpResponseHeader),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "set_ContentType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.AuthorizationState", Member = "CheckAuthorization", MemberParameters = new object[]
			{
				typeof(WebResponse),
				typeof(HttpStatusCode)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
			{
				typeof(HttpListenerContext),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000075A7 File Offset: 0x000057A7
		[global::Cpp2ILInjected.Token(Token = "0x6001C5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EC60", Offset = "0x1E8EC60", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string Get(int index)
		{
			throw null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000075AA File Offset: 0x000057AA
		[global::Cpp2ILInjected.Token(Token = "0x6001C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8ED78", Offset = "0x1E8ED78", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "GetAsStringArray", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string[] GetValues(int index)
		{
			throw null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000075AD File Offset: 0x000057AD
		[global::Cpp2ILInjected.Token(Token = "0x6001C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EDFC", Offset = "0x1E8EDFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual string GetKey(int index)
		{
			throw null;
		}

		// Token: 0x17000608 RID: 1544
		[global::Cpp2ILInjected.Token(Token = "0x17000652")]
		public string this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8EE94", Offset = "0x1E8EE94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x000075B3 File Offset: 0x000057B3
		[global::Cpp2ILInjected.Token(Token = "0x17000653")]
		public virtual string[] AllKeys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8EEA4", Offset = "0x1E8EEA4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetAllKeys", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000075B6 File Offset: 0x000057B6
		[global::Cpp2ILInjected.Token(Token = "0x6001C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8EFA0", Offset = "0x1E8EFA0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollectionType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(NameValueCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal NameValueCollection(DBNull dummy)
		{
			throw null;
		}

		// Token: 0x04000F5A RID: 3930
		[global::Cpp2ILInjected.Token(Token = "0x40013A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string[] _all;

		// Token: 0x04000F5B RID: 3931
		[global::Cpp2ILInjected.Token(Token = "0x40013AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string[] _allKeys;
	}
}
