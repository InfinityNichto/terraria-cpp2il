using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net.Cache;
using System.Net.Configuration;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200014C RID: 332
	[global::Cpp2ILInjected.Token(Token = "0x20001D5")]
	[Serializable]
	public abstract class WebRequest : MarshalByRefObject, ISerializable
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00004BAD File Offset: 0x00002DAD
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x17000255")]
		public virtual IWebRequestCreate CreatorInstance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1E068", Offset = "0x1F1E068", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00004BB0 File Offset: 0x00002DB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E0C0", Offset = "0x1F1E0C0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void RegisterPortableWebRequestCreator(IWebRequestCreate creator)
		{
			throw null;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00004BB3 File Offset: 0x00002DB3
		[global::Cpp2ILInjected.Token(Token = "0x17000256")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1E0C4", Offset = "0x1F1E0C4", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "RegisterPrefix", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IWebRequestCreate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_InternalDefaultWebProxy", MemberParameters = new object[] { typeof(IWebProxy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00004BB6 File Offset: 0x00002DB6
		[global::Cpp2ILInjected.Token(Token = "0x17000257")]
		internal static TimerThread.Queue DefaultTimerQueue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1E190", Offset = "0x1F1E190", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00004BB9 File Offset: 0x00002DB9
		[global::Cpp2ILInjected.Token(Token = "0x6000B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E1E8", Offset = "0x1F1E1E8", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "CreateDefault", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestPrefixElement), Member = "get_Creator", ReturnType = typeof(IWebRequestCreate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static WebRequest Create(Uri requestUri, bool useUriBase)
		{
			throw null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00004BBC File Offset: 0x00002DBC
		[global::Cpp2ILInjected.Token(Token = "0x6000B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E5F4", Offset = "0x1F1E5F4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool)
		}, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static WebRequest Create(string requestUriString)
		{
			throw null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00004BBF File Offset: 0x00002DBF
		[global::Cpp2ILInjected.Token(Token = "0x6000B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E6C4", Offset = "0x1F1E6C4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetWebRequest", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest.DesignerWebRequestCreate), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager.<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetNonFileStream", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool)
		}, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static WebRequest Create(Uri requestUri)
		{
			throw null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00004BC2 File Offset: 0x00002DC2
		[global::Cpp2ILInjected.Token(Token = "0x6000B83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E79C", Offset = "0x1F1E79C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "CreateHttp", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(HttpWebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(bool)
		}, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static WebRequest CreateDefault(Uri requestUri)
		{
			throw null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00004BC5 File Offset: 0x00002DC5
		[global::Cpp2ILInjected.Token(Token = "0x6000B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E874", Offset = "0x1F1E874", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static HttpWebRequest CreateHttp(string requestUriString)
		{
			throw null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00004BC8 File Offset: 0x00002DC8
		[global::Cpp2ILInjected.Token(Token = "0x6000B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1E940", Offset = "0x1F1E940", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "CreateDefault", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static HttpWebRequest CreateHttp(Uri requestUri)
		{
			throw null;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00004BCB File Offset: 0x00002DCB
		[global::Cpp2ILInjected.Token(Token = "0x6000B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1EB30", Offset = "0x1F1EB30", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "set_PrefixList", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
		{
			throw null;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00004BCE File Offset: 0x00002DCE
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00004BD1 File Offset: 0x00002DD1
		[global::Cpp2ILInjected.Token(Token = "0x17000258")]
		internal static ArrayList PrefixList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1E460", Offset = "0x1F1E460", Length = "0x194")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(bool)
			}, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "RegisterPrefix", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IWebRequestCreate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1EF30", Offset = "0x1F1EF30", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "RegisterPrefix", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IWebRequestCreate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[global::Cpp2ILInjected.Token(Token = "0x6000B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1EF90", Offset = "0x1F1EF90", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpRequestCreator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebRequestCreator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequestCreator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static ArrayList PopulatePrefixList()
		{
			throw null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00004BD7 File Offset: 0x00002DD7
		[global::Cpp2ILInjected.Token(Token = "0x6000B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F1B0", Offset = "0x1F1F1B0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected WebRequest()
		{
			throw null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00004BDA File Offset: 0x00002DDA
		[global::Cpp2ILInjected.Token(Token = "0x6000B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F1D4", Offset = "0x1F1F1D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00004BDD File Offset: 0x00002DDD
		[global::Cpp2ILInjected.Token(Token = "0x6000B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F1DC", Offset = "0x1F1F1DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00004BE0 File Offset: 0x00002DE0
		[global::Cpp2ILInjected.Token(Token = "0x6000B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F1E8", Offset = "0x1F1F1E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00004BE3 File Offset: 0x00002DE3
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00004BE6 File Offset: 0x00002DE6
		[global::Cpp2ILInjected.Token(Token = "0x17000259")]
		public static RequestCachePolicy DefaultCachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F1EC", Offset = "0x1F1F1EC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "SetupCacheProtocol", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(RequestCacheBinding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F268", Offset = "0x1F1F268", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(RequestCacheBinding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheBinding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(RequestCache),
				typeof(RequestCacheValidator),
				typeof(RequestCachePolicy)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "SetBinding", MemberParameters = new object[]
			{
				typeof(string),
				typeof(RequestCacheBinding)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00004BE9 File Offset: 0x00002DE9
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00004BEC File Offset: 0x00002DEC
		[global::Cpp2ILInjected.Token(Token = "0x1700025A")]
		public virtual RequestCachePolicy CachePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F33C", Offset = "0x1F1F33C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F344", Offset = "0x1F1F344", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00004BEF File Offset: 0x00002DEF
		[global::Cpp2ILInjected.Token(Token = "0x6000B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F348", Offset = "0x1F1F348", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "SetupCacheProtocol", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheValidator), Member = "CreateValidator", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheProtocol), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InternalSetCachePolicy(RequestCachePolicy policy)
		{
			throw null;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00004BF2 File Offset: 0x00002DF2
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00004BF5 File Offset: 0x00002DF5
		[global::Cpp2ILInjected.Token(Token = "0x1700025B")]
		public virtual string Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F3F8", Offset = "0x1F1F3F8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F41C", Offset = "0x1F1F41C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[global::Cpp2ILInjected.Token(Token = "0x1700025C")]
		public virtual Uri RequestUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F440", Offset = "0x1F1F440", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00004BFB File Offset: 0x00002DFB
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00004BFE File Offset: 0x00002DFE
		[global::Cpp2ILInjected.Token(Token = "0x1700025D")]
		public virtual string ConnectionGroupName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F464", Offset = "0x1F1F464", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F488", Offset = "0x1F1F488", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00004C01 File Offset: 0x00002E01
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00004C04 File Offset: 0x00002E04
		[global::Cpp2ILInjected.Token(Token = "0x1700025E")]
		public virtual WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F4AC", Offset = "0x1F1F4AC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F4D0", Offset = "0x1F1F4D0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00004C07 File Offset: 0x00002E07
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00004C0A File Offset: 0x00002E0A
		[global::Cpp2ILInjected.Token(Token = "0x1700025F")]
		public virtual long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F4F4", Offset = "0x1F1F4F4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F518", Offset = "0x1F1F518", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00004C0D File Offset: 0x00002E0D
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00004C10 File Offset: 0x00002E10
		[global::Cpp2ILInjected.Token(Token = "0x17000260")]
		public virtual string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F53C", Offset = "0x1F1F53C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F560", Offset = "0x1F1F560", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00004C13 File Offset: 0x00002E13
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00004C16 File Offset: 0x00002E16
		[global::Cpp2ILInjected.Token(Token = "0x17000261")]
		public virtual ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F584", Offset = "0x1F1F584", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F5A8", Offset = "0x1F1F5A8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00004C19 File Offset: 0x00002E19
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00004C1C File Offset: 0x00002E1C
		[global::Cpp2ILInjected.Token(Token = "0x17000262")]
		public virtual bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F5CC", Offset = "0x1F1F5CC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F5F0", Offset = "0x1F1F5F0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00004C1F File Offset: 0x00002E1F
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00004C22 File Offset: 0x00002E22
		[global::Cpp2ILInjected.Token(Token = "0x17000263")]
		public virtual IWebProxy Proxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F614", Offset = "0x1F1F614", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F638", Offset = "0x1F1F638", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00004C25 File Offset: 0x00002E25
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00004C28 File Offset: 0x00002E28
		[global::Cpp2ILInjected.Token(Token = "0x17000264")]
		public virtual bool PreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F65C", Offset = "0x1F1F65C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F680", Offset = "0x1F1F680", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00004C2B File Offset: 0x00002E2B
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00004C2E File Offset: 0x00002E2E
		[global::Cpp2ILInjected.Token(Token = "0x17000265")]
		public virtual int Timeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F6A4", Offset = "0x1F1F6A4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1F6C8", Offset = "0x1F1F6C8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00004C31 File Offset: 0x00002E31
		[global::Cpp2ILInjected.Token(Token = "0x6000BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F6EC", Offset = "0x1F1F6EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Stream GetRequestStream()
		{
			throw null;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00004C34 File Offset: 0x00002E34
		[global::Cpp2ILInjected.Token(Token = "0x6000BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F710", Offset = "0x1F1F710", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual WebResponse GetResponse()
		{
			throw null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00004C37 File Offset: 0x00002E37
		[global::Cpp2ILInjected.Token(Token = "0x6000BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F734", Offset = "0x1F1F734", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00004C3A File Offset: 0x00002E3A
		[global::Cpp2ILInjected.Token(Token = "0x6000BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F758", Offset = "0x1F1F758", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00004C3D File Offset: 0x00002E3D
		[global::Cpp2ILInjected.Token(Token = "0x6000BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F77C", Offset = "0x1F1F77C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00004C40 File Offset: 0x00002E40
		[global::Cpp2ILInjected.Token(Token = "0x6000BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F7A0", Offset = "0x1F1F7A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00004C43 File Offset: 0x00002E43
		[global::Cpp2ILInjected.Token(Token = "0x6000BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1F7C4", Offset = "0x1F1F7C4", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "SafeCaptureIdenity", ReturnType = typeof(WindowsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { "System.Func`1<Task`1<TResult>>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public virtual Task<Stream> GetRequestStreamAsync()
		{
			throw null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00004C46 File Offset: 0x00002E46
		[global::Cpp2ILInjected.Token(Token = "0x6000BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1FAA0", Offset = "0x1F1FAA0", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "SafeCaptureIdenity", ReturnType = typeof(WindowsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { "System.Func`1<Task`1<TResult>>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public virtual Task<WebResponse> GetResponseAsync()
		{
			throw null;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00004C49 File Offset: 0x00002E49
		[global::Cpp2ILInjected.Token(Token = "0x6000BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1FA50", Offset = "0x1F1FA50", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "GetRequestStreamAsync", ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "GetResponseAsync", ReturnType = typeof(Task<WebResponse>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private WindowsIdentity SafeCaptureIdenity()
		{
			throw null;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00004C4C File Offset: 0x00002E4C
		[global::Cpp2ILInjected.Token(Token = "0x6000BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1FD2C", Offset = "0x1F1FD2C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Abort()
		{
			throw null;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00004C4F File Offset: 0x00002E4F
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00004C52 File Offset: 0x00002E52
		[global::Cpp2ILInjected.Token(Token = "0x17000266")]
		internal RequestCacheProtocol CacheProtocol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD50", Offset = "0x1F1FD50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD58", Offset = "0x1F1FD58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00004C55 File Offset: 0x00002E55
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00004C58 File Offset: 0x00002E58
		[global::Cpp2ILInjected.Token(Token = "0x17000267")]
		public AuthenticationLevel AuthenticationLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD60", Offset = "0x1F1FD60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD68", Offset = "0x1F1FD68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00004C5B File Offset: 0x00002E5B
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00004C5E File Offset: 0x00002E5E
		[global::Cpp2ILInjected.Token(Token = "0x17000268")]
		public TokenImpersonationLevel ImpersonationLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD70", Offset = "0x1F1FD70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD78", Offset = "0x1F1FD78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00004C61 File Offset: 0x00002E61
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00004C64 File Offset: 0x00002E64
		[global::Cpp2ILInjected.Token(Token = "0x17000269")]
		internal static IWebProxy InternalDefaultWebProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD80", Offset = "0x1F1FD80", Length = "0x1CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_DefaultWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultProxySectionInternal), Member = "GetSection", ReturnType = typeof(DefaultProxySectionInternal))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FF4C", Offset = "0x1F1FF4C", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_DefaultWebProxy", MemberParameters = new object[] { typeof(IWebProxy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00004C67 File Offset: 0x00002E67
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00004C6A File Offset: 0x00002E6A
		[global::Cpp2ILInjected.Token(Token = "0x1700026A")]
		public static IWebProxy DefaultWebProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C3D4", Offset = "0x1F0C3D4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "get_Proxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalProxySelection), Member = "get_Select", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C4C8", Offset = "0x1F0C4C8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "set_InternalDefaultWebProxy", MemberParameters = new object[] { typeof(IWebProxy) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00004C6D File Offset: 0x00002E6D
		[global::Cpp2ILInjected.Token(Token = "0x6000BBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F200D0", Offset = "0x1F200D0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IWebProxy GetSystemWebProxy()
		{
			throw null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00004C70 File Offset: 0x00002E70
		[global::Cpp2ILInjected.Token(Token = "0x6000BBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20120", Offset = "0x1F20120", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		internal static IWebProxy InternalGetSystemWebProxy()
		{
			throw null;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00004C73 File Offset: 0x00002E73
		[global::Cpp2ILInjected.Token(Token = "0x6000BBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F20128", Offset = "0x1F20128", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(RequestCacheBinding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "InternalSetCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void SetupCacheProtocol(Uri uri)
		{
			throw null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00004C76 File Offset: 0x00002E76
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F201FC", Offset = "0x1F201FC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerThread), Member = "CreateQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TimerThread.Queue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static WebRequest()
		{
			throw null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00004C79 File Offset: 0x00002E79
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000BC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F202B4", Offset = "0x1F202B4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Task<Stream> <GetRequestStreamAsync>b__78_0()
		{
			throw null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00004C7C File Offset: 0x00002E7C
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000BC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F203A4", Offset = "0x1F203A4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Task<WebResponse> <GetResponseAsync>b__79_0()
		{
			throw null;
		}

		// Token: 0x040007D4 RID: 2004
		[global::Cpp2ILInjected.Token(Token = "0x40009F6")]
		internal const int DefaultTimeout = 100000;

		// Token: 0x040007D5 RID: 2005
		[global::Cpp2ILInjected.Token(Token = "0x40009F7")]
		private static ArrayList s_PrefixList;

		// Token: 0x040007D6 RID: 2006
		[global::Cpp2ILInjected.Token(Token = "0x40009F8")]
		private static object s_InternalSyncObject;

		// Token: 0x040007D7 RID: 2007
		[global::Cpp2ILInjected.Token(Token = "0x40009F9")]
		private static TimerThread.Queue s_DefaultTimerQueue;

		// Token: 0x040007D8 RID: 2008
		[global::Cpp2ILInjected.Token(Token = "0x40009FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AuthenticationLevel m_AuthenticationLevel;

		// Token: 0x040007D9 RID: 2009
		[global::Cpp2ILInjected.Token(Token = "0x40009FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private TokenImpersonationLevel m_ImpersonationLevel;

		// Token: 0x040007DA RID: 2010
		[global::Cpp2ILInjected.Token(Token = "0x40009FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RequestCachePolicy m_CachePolicy;

		// Token: 0x040007DB RID: 2011
		[global::Cpp2ILInjected.Token(Token = "0x40009FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private RequestCacheProtocol m_CacheProtocol;

		// Token: 0x040007DC RID: 2012
		[global::Cpp2ILInjected.Token(Token = "0x40009FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private RequestCacheBinding m_CacheBinding;

		// Token: 0x040007DD RID: 2013
		[global::Cpp2ILInjected.Token(Token = "0x40009FF")]
		private static WebRequest.DesignerWebRequestCreate webRequestCreate;

		// Token: 0x040007DE RID: 2014
		[global::Cpp2ILInjected.Token(Token = "0x4000A00")]
		private static IWebProxy s_DefaultWebProxy;

		// Token: 0x040007DF RID: 2015
		[global::Cpp2ILInjected.Token(Token = "0x4000A01")]
		private static bool s_DefaultWebProxyInitialized;

		// Token: 0x020003F1 RID: 1009
		[global::Cpp2ILInjected.Token(Token = "0x20001D6")]
		internal class DesignerWebRequestCreate : IWebRequestCreate
		{
			// Token: 0x06001DB9 RID: 7609 RVA: 0x00008213 File Offset: 0x00006413
			[global::Cpp2ILInjected.Token(Token = "0x6000BC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20494", Offset = "0x1F20494", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public WebRequest Create(Uri uri)
			{
				throw null;
			}

			// Token: 0x06001DBA RID: 7610 RVA: 0x00008216 File Offset: 0x00006416
			[global::Cpp2ILInjected.Token(Token = "0x6000BC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F202AC", Offset = "0x1F202AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DesignerWebRequestCreate()
			{
				throw null;
			}
		}

		// Token: 0x020003F2 RID: 1010
		[global::Cpp2ILInjected.Token(Token = "0x20001D7")]
		internal class WebProxyWrapperOpaque : IAutoWebProxy, IWebProxy
		{
			// Token: 0x06001DBB RID: 7611 RVA: 0x00008219 File Offset: 0x00006419
			[global::Cpp2ILInjected.Token(Token = "0x6000BC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F204E8", Offset = "0x1F204E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal WebProxyWrapperOpaque(WebProxy webProxy)
			{
				throw null;
			}

			// Token: 0x06001DBC RID: 7612 RVA: 0x0000821C File Offset: 0x0000641C
			[global::Cpp2ILInjected.Token(Token = "0x6000BC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20510", Offset = "0x1F20510", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "GetProxy", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			public Uri GetProxy(Uri destination)
			{
				throw null;
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x0000821F File Offset: 0x0000641F
			[global::Cpp2ILInjected.Token(Token = "0x6000BC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2051C", Offset = "0x1F2051C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "IsBypassed", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
			public bool IsBypassed(Uri host)
			{
				throw null;
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00008222 File Offset: 0x00006422
			// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00008225 File Offset: 0x00006425
			[global::Cpp2ILInjected.Token(Token = "0x1700026B")]
			public ICredentials Credentials
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000BC7")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F20528", Offset = "0x1F20528", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000BC8")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F20534", Offset = "0x1F20534", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001DC0 RID: 7616 RVA: 0x00008228 File Offset: 0x00006428
			[global::Cpp2ILInjected.Token(Token = "0x6000BC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20540", Offset = "0x1F20540", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public ProxyChain GetProxies(Uri destination)
			{
				throw null;
			}

			// Token: 0x040011D3 RID: 4563
			[global::Cpp2ILInjected.Token(Token = "0x4000A02")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			protected readonly WebProxy webProxy;
		}

		// Token: 0x020003F3 RID: 1011
		[global::Cpp2ILInjected.Token(Token = "0x20001D8")]
		internal class WebProxyWrapper : WebRequest.WebProxyWrapperOpaque
		{
			// Token: 0x06001DC1 RID: 7617 RVA: 0x0000822B File Offset: 0x0000642B
			[global::Cpp2ILInjected.Token(Token = "0x6000BCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F205E8", Offset = "0x1F205E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal WebProxyWrapper(WebProxy webProxy)
			{
				throw null;
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x0000822E File Offset: 0x0000642E
			[global::Cpp2ILInjected.Token(Token = "0x1700026C")]
			internal WebProxy WebProxy
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000BCB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F20610", Offset = "0x1F20610", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x020003F4 RID: 1012
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001D9")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06001DC3 RID: 7619 RVA: 0x00008231 File Offset: 0x00006431
			[global::Cpp2ILInjected.Token(Token = "0x6000BCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FA48", Offset = "0x1F1FA48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass78_0()
			{
				throw null;
			}

			// Token: 0x06001DC4 RID: 7620 RVA: 0x00008234 File Offset: 0x00006434
			[global::Cpp2ILInjected.Token(Token = "0x6000BCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F20618", Offset = "0x1F20618", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			internal Task<Stream> <GetRequestStreamAsync>b__1()
			{
				throw null;
			}

			// Token: 0x040011D4 RID: 4564
			[global::Cpp2ILInjected.Token(Token = "0x4000A03")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WindowsIdentity currentUser;

			// Token: 0x040011D5 RID: 4565
			[global::Cpp2ILInjected.Token(Token = "0x4000A04")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public WebRequest <>4__this;
		}

		// Token: 0x020003F5 RID: 1013
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20001DA")]
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06001DC5 RID: 7621 RVA: 0x00008237 File Offset: 0x00006437
			[global::Cpp2ILInjected.Token(Token = "0x6000BCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1FD24", Offset = "0x1F1FD24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass79_0()
			{
				throw null;
			}

			// Token: 0x06001DC6 RID: 7622 RVA: 0x0000823A File Offset: 0x0000643A
			[global::Cpp2ILInjected.Token(Token = "0x6000BCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F209A0", Offset = "0x1F209A0", Length = "0x388")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			internal Task<WebResponse> <GetResponseAsync>b__1()
			{
				throw null;
			}

			// Token: 0x040011D6 RID: 4566
			[global::Cpp2ILInjected.Token(Token = "0x4000A05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public WindowsIdentity currentUser;

			// Token: 0x040011D7 RID: 4567
			[global::Cpp2ILInjected.Token(Token = "0x4000A06")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public WebRequest <>4__this;
		}
	}
}
