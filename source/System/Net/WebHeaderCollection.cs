using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000146 RID: 326
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001CD")]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00004A33 File Offset: 0x00002C33
		[global::Cpp2ILInjected.Token(Token = "0x17000235")]
		internal string ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11B44", Offset = "0x1F11B44", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00004A36 File Offset: 0x00002C36
		[global::Cpp2ILInjected.Token(Token = "0x17000236")]
		internal string CacheControl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11BCC", Offset = "0x1F11BCC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00004A39 File Offset: 0x00002C39
		[global::Cpp2ILInjected.Token(Token = "0x17000237")]
		internal string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11C54", Offset = "0x1F11C54", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00004A3C File Offset: 0x00002C3C
		[global::Cpp2ILInjected.Token(Token = "0x17000238")]
		internal string Date
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11CDC", Offset = "0x1F11CDC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00004A3F File Offset: 0x00002C3F
		[global::Cpp2ILInjected.Token(Token = "0x17000239")]
		internal string Expires
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11D64", Offset = "0x1F11D64", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00004A42 File Offset: 0x00002C42
		[global::Cpp2ILInjected.Token(Token = "0x1700023A")]
		internal string ETag
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11DEC", Offset = "0x1F11DEC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00004A45 File Offset: 0x00002C45
		[global::Cpp2ILInjected.Token(Token = "0x1700023B")]
		internal string LastModified
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11E74", Offset = "0x1F11E74", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00004A48 File Offset: 0x00002C48
		[global::Cpp2ILInjected.Token(Token = "0x1700023C")]
		internal string Location
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11EFC", Offset = "0x1F11EFC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00004A4B File Offset: 0x00002C4B
		[global::Cpp2ILInjected.Token(Token = "0x1700023D")]
		internal string ProxyAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12168", Offset = "0x1F12168", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00004A4E File Offset: 0x00002C4E
		[global::Cpp2ILInjected.Token(Token = "0x1700023E")]
		internal string SetCookie2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F121F0", Offset = "0x1F121F0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00004A51 File Offset: 0x00002C51
		[global::Cpp2ILInjected.Token(Token = "0x1700023F")]
		internal string SetCookie
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12278", Offset = "0x1F12278", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00004A54 File Offset: 0x00002C54
		[global::Cpp2ILInjected.Token(Token = "0x17000240")]
		internal string Server
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12300", Offset = "0x1F12300", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00004A57 File Offset: 0x00002C57
		[global::Cpp2ILInjected.Token(Token = "0x17000241")]
		internal string Via
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12388", Offset = "0x1F12388", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00004A5A File Offset: 0x00002C5A
		[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12410", Offset = "0x1F12410", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void NormalizeCommonHeaders()
		{
			throw null;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00004A5D File Offset: 0x00002C5D
		[global::Cpp2ILInjected.Token(Token = "0x17000242")]
		private NameValueCollection InnerCollection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F124E4", Offset = "0x1F124E4", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(IEqualityComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00004A60 File Offset: 0x00002C60
		[global::Cpp2ILInjected.Token(Token = "0x6000B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12580", Offset = "0x1F12580", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "FormatHeaders", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HeaderInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool AllowMultiValues(string name)
		{
			throw null;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00004A63 File Offset: 0x00002C63
		[global::Cpp2ILInjected.Token(Token = "0x17000243")]
		private bool AllowHttpRequestHeader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12620", Offset = "0x1F12620", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00004A66 File Offset: 0x00002C66
		[global::Cpp2ILInjected.Token(Token = "0x17000244")]
		internal bool AllowHttpResponseHeader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12658", Offset = "0x1F12658", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023A RID: 570
		[global::Cpp2ILInjected.Token(Token = "0x17000245")]
		public string this[HttpRequestHeader header]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12688", Offset = "0x1F12688", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12770", Offset = "0x1F12770", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700023B RID: 571
		[global::Cpp2ILInjected.Token(Token = "0x17000246")]
		public string this[HttpResponseHeader header]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F12868", Offset = "0x1F12868", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1297C", Offset = "0x1F1297C", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00004A75 File Offset: 0x00002C75
		[global::Cpp2ILInjected.Token(Token = "0x6000B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12B3C", Offset = "0x1F12B3C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Add(HttpRequestHeader header, string value)
		{
			throw null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00004A78 File Offset: 0x00002C78
		[global::Cpp2ILInjected.Token(Token = "0x6000B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12C3C", Offset = "0x1F12C3C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Add(HttpResponseHeader header, string value)
		{
			throw null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00004A7B File Offset: 0x00002C7B
		[global::Cpp2ILInjected.Token(Token = "0x6000B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12E04", Offset = "0x1F12E04", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Set(HttpRequestHeader header, string value)
		{
			throw null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00004A7E File Offset: 0x00002C7E
		[global::Cpp2ILInjected.Token(Token = "0x6000B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F12F04", Offset = "0x1F12F04", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Set(HttpResponseHeader header, string value)
		{
			throw null;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00004A81 File Offset: 0x00002C81
		[global::Cpp2ILInjected.Token(Token = "0x6000B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F130CC", Offset = "0x1F130CC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal void SetInternal(HttpResponseHeader header, string value)
		{
			throw null;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00004A84 File Offset: 0x00002C84
		[global::Cpp2ILInjected.Token(Token = "0x6000B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13488", Offset = "0x1F13488", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Remove(HttpRequestHeader header)
		{
			throw null;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00004A87 File Offset: 0x00002C87
		[global::Cpp2ILInjected.Token(Token = "0x6000B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13578", Offset = "0x1F13578", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE_HEADER_ID), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Remove(HttpResponseHeader header)
		{
			throw null;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00004A8A File Offset: 0x00002C8A
		[global::Cpp2ILInjected.Token(Token = "0x6000B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13664", Offset = "0x1F13664", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected void AddWithoutValidate(string headerName, string headerValue)
		{
			throw null;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00004A8D File Offset: 0x00002C8D
		[global::Cpp2ILInjected.Token(Token = "0x6000B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13B50", Offset = "0x1F13B50", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HeaderInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetAddVerified(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00004A90 File Offset: 0x00002C90
		[global::Cpp2ILInjected.Token(Token = "0x6000B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13C0C", Offset = "0x1F13C0C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ParseHeaders", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(int),
			typeof(ref WebParseError)
		}, ReturnType = typeof(DataParseStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void AddInternal(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00004A93 File Offset: 0x00002C93
		[global::Cpp2ILInjected.Token(Token = "0x6000B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13C58", Offset = "0x1F13C58", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "CheckUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void ChangeInternal(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00004A96 File Offset: 0x00002C96
		[global::Cpp2ILInjected.Token(Token = "0x6000B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13CA4", Offset = "0x1F13CA4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.AuthorizationState", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Expect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Referer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_TransferEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "RewriteRedirectToGet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveInternal(string name)
		{
			throw null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00004A99 File Offset: 0x00002C99
		[global::Cpp2ILInjected.Token(Token = "0x6000B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13CF8", Offset = "0x1F13CF8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Expect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_TransferEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void CheckUpdate(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00004A9C File Offset: 0x00002C9C
		[global::Cpp2ILInjected.Token(Token = "0x6000B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13D70", Offset = "0x1F13D70", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void AddInternalNotCommon(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00004A9F File Offset: 0x00002C9F
		[global::Cpp2ILInjected.Token(Token = "0x6000B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F137EC", Offset = "0x1F137EC", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "AddWithoutValidate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "CheckUpdate", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "IsRestricted", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ContainsNonAsciiChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal static string CheckBadChars(string name, bool isHeaderValue)
		{
			throw null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00004AA2 File Offset: 0x00002CA2
		[global::Cpp2ILInjected.Token(Token = "0x6000B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13E30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ContainsNonAsciiChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool IsValidToken(string token)
		{
			throw null;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00004AA5 File Offset: 0x00002CA5
		[global::Cpp2ILInjected.Token(Token = "0x6000B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13DB4", Offset = "0x1F13DB4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "IsValidToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static bool ContainsNonAsciiChars(string token)
		{
			throw null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00004AA8 File Offset: 0x00002CA8
		[global::Cpp2ILInjected.Token(Token = "0x6000B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13EE8", Offset = "0x1F13EE8", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HeaderInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void ThrowOnRestrictedHeader(string headerName)
		{
			throw null;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00004AAB File Offset: 0x00002CAB
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1402C", Offset = "0x1F1402C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void Add(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00004AAE File Offset: 0x00002CAE
		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F141C0", Offset = "0x1F141C0", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = "System.Net.MonoChunkParser.State")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public void Add(string header)
		{
			throw null;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00004AB1 File Offset: 0x00002CB1
		[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14474", Offset = "0x1F14474", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void Set(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F13288", Offset = "0x1F13288", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_IfModifiedSince", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Referer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_UserAgent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void SetInternal(string name, string value)
		{
			throw null;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00004AB7 File Offset: 0x00002CB7
		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14680", Offset = "0x1F14680", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Remove(string name)
		{
			throw null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00004ABA File Offset: 0x00002CBA
		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F147B0", Offset = "0x1F147B0", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HeaderInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string[] GetValues(string header)
		{
			throw null;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00004ABD File Offset: 0x00002CBD
		[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14994", Offset = "0x1F14994", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00004AC0 File Offset: 0x00002CC0
		[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14C7C", Offset = "0x1F14C7C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "GetAsString", MemberParameters = new object[]
		{
			typeof(NameValueCollection),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal string ToString(bool forTrace)
		{
			throw null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00004AC3 File Offset: 0x00002CC3
		[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F149F0", Offset = "0x1F149F0", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			throw null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00004AC6 File Offset: 0x00002CC6
		[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14CD8", Offset = "0x1F14CD8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] ToByteArray()
		{
			throw null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00004AC9 File Offset: 0x00002CC9
		[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14D60", Offset = "0x1F14D60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsRestricted(string headerName)
		{
			throw null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00004ACC File Offset: 0x00002CCC
		[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14DB8", Offset = "0x1F14DB8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HeaderInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsRestricted(string headerName, bool response)
		{
			throw null;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00004ACF File Offset: 0x00002CCF
		[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14E4C", Offset = "0x1F14E4C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = ".ctor", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = ".ctor", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[] { typeof(DBNull) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebHeaderCollection()
		{
			throw null;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00004AD2 File Offset: 0x00002CD2
		[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14EB0", Offset = "0x1F14EB0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Headers", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[] { typeof(DBNull) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal WebHeaderCollection(WebHeaderCollectionType type)
		{
			throw null;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00004AD5 File Offset: 0x00002CD5
		[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F14F8C", Offset = "0x1F14F8C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[] { typeof(DBNull) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal WebHeaderCollection(NameValueCollection cc)
		{
			throw null;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00004AD8 File Offset: 0x00002CD8
		[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F15164", Offset = "0x1F15164", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[] { typeof(DBNull) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00004ADB File Offset: 0x00002CDB
		[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F15318", Offset = "0x1F15318", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00004ADE File Offset: 0x00002CDE
		[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1531C", Offset = "0x1F1531C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00004AE1 File Offset: 0x00002CE1
		[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F15494", Offset = "0x1F15494", Length = "0x48C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe DataParseStatus ParseHeaders(byte[] buffer, int size, ref int unparsed, ref int totalResponseHeadersLength, int maximumResponseHeadersLength, ref WebParseError parseError)
		{
			throw null;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F15A24", Offset = "0x1F15A24", Length = "0x7E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal unsafe DataParseStatus ParseHeadersStrict(byte[] buffer, int size, ref int unparsed, ref int totalResponseHeadersLength, int maximumResponseHeadersLength, ref WebParseError parseError)
		{
			throw null;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00004AE7 File Offset: 0x00002CE7
		[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16208", Offset = "0x1F16208", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00004AEA File Offset: 0x00002CEA
		[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16214", Offset = "0x1F16214", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string Get(string name)
		{
			throw null;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00004AED File Offset: 0x00002CED
		[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F164C0", Offset = "0x1F164C0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameObjectCollectionBase.NameObjectKeysEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(NameObjectCollectionBase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00004AF0 File Offset: 0x00002CF0
		[global::Cpp2ILInjected.Token(Token = "0x17000247")]
		public override int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F16534", Offset = "0x1F16534", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00004AF3 File Offset: 0x00002CF3
		[global::Cpp2ILInjected.Token(Token = "0x17000248")]
		public override NameObjectCollectionBase.KeysCollection Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F16564", Offset = "0x1F16564", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00004AF6 File Offset: 0x00002CF6
		[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F1658C", Offset = "0x1F1658C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "HasKeys", ReturnType = typeof(bool))]
		internal override bool InternalHasKeys()
		{
			throw null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00004AF9 File Offset: 0x00002CF9
		[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F165B4", Offset = "0x1F165B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string Get(int index)
		{
			throw null;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00004AFC File Offset: 0x00002CFC
		[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F165EC", Offset = "0x1F165EC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string[] GetValues(int index)
		{
			throw null;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00004AFF File Offset: 0x00002CFF
		[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16624", Offset = "0x1F16624", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetKey(int index)
		{
			throw null;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00004B02 File Offset: 0x00002D02
		[global::Cpp2ILInjected.Token(Token = "0x17000249")]
		public override string[] AllKeys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F1665C", Offset = "0x1F1665C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "NormalizeCommonHeaders", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00004B05 File Offset: 0x00002D05
		[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F16684", Offset = "0x1F16684", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "InvalidateCachedArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00004B08 File Offset: 0x00002D08
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F166C0", Offset = "0x1F166C0", Length = "0x58C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderInfoTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		static WebHeaderCollection()
		{
			throw null;
		}

		// Token: 0x040007A7 RID: 1959
		[global::Cpp2ILInjected.Token(Token = "0x40009C0")]
		private const int ApproxAveHeaderLineSize = 30;

		// Token: 0x040007A8 RID: 1960
		[global::Cpp2ILInjected.Token(Token = "0x40009C1")]
		private const int ApproxHighAvgNumHeaders = 16;

		// Token: 0x040007A9 RID: 1961
		[global::Cpp2ILInjected.Token(Token = "0x40009C2")]
		private static readonly HeaderInfoTable HInfo;

		// Token: 0x040007AA RID: 1962
		[global::Cpp2ILInjected.Token(Token = "0x40009C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string[] m_CommonHeaders;

		// Token: 0x040007AB RID: 1963
		[global::Cpp2ILInjected.Token(Token = "0x40009C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int m_NumCommonHeaders;

		// Token: 0x040007AC RID: 1964
		[global::Cpp2ILInjected.Token(Token = "0x40009C5")]
		private static readonly string[] s_CommonHeaderNames;

		// Token: 0x040007AD RID: 1965
		[global::Cpp2ILInjected.Token(Token = "0x40009C6")]
		private static readonly sbyte[] s_CommonHeaderHints;

		// Token: 0x040007AE RID: 1966
		[global::Cpp2ILInjected.Token(Token = "0x40009C7")]
		private const int c_AcceptRanges = 0;

		// Token: 0x040007AF RID: 1967
		[global::Cpp2ILInjected.Token(Token = "0x40009C8")]
		private const int c_ContentLength = 1;

		// Token: 0x040007B0 RID: 1968
		[global::Cpp2ILInjected.Token(Token = "0x40009C9")]
		private const int c_CacheControl = 2;

		// Token: 0x040007B1 RID: 1969
		[global::Cpp2ILInjected.Token(Token = "0x40009CA")]
		private const int c_ContentType = 3;

		// Token: 0x040007B2 RID: 1970
		[global::Cpp2ILInjected.Token(Token = "0x40009CB")]
		private const int c_Date = 4;

		// Token: 0x040007B3 RID: 1971
		[global::Cpp2ILInjected.Token(Token = "0x40009CC")]
		private const int c_Expires = 5;

		// Token: 0x040007B4 RID: 1972
		[global::Cpp2ILInjected.Token(Token = "0x40009CD")]
		private const int c_ETag = 6;

		// Token: 0x040007B5 RID: 1973
		[global::Cpp2ILInjected.Token(Token = "0x40009CE")]
		private const int c_LastModified = 7;

		// Token: 0x040007B6 RID: 1974
		[global::Cpp2ILInjected.Token(Token = "0x40009CF")]
		private const int c_Location = 8;

		// Token: 0x040007B7 RID: 1975
		[global::Cpp2ILInjected.Token(Token = "0x40009D0")]
		private const int c_ProxyAuthenticate = 9;

		// Token: 0x040007B8 RID: 1976
		[global::Cpp2ILInjected.Token(Token = "0x40009D1")]
		private const int c_P3P = 10;

		// Token: 0x040007B9 RID: 1977
		[global::Cpp2ILInjected.Token(Token = "0x40009D2")]
		private const int c_SetCookie2 = 11;

		// Token: 0x040007BA RID: 1978
		[global::Cpp2ILInjected.Token(Token = "0x40009D3")]
		private const int c_SetCookie = 12;

		// Token: 0x040007BB RID: 1979
		[global::Cpp2ILInjected.Token(Token = "0x40009D4")]
		private const int c_Server = 13;

		// Token: 0x040007BC RID: 1980
		[global::Cpp2ILInjected.Token(Token = "0x40009D5")]
		private const int c_Via = 14;

		// Token: 0x040007BD RID: 1981
		[global::Cpp2ILInjected.Token(Token = "0x40009D6")]
		private const int c_WwwAuthenticate = 15;

		// Token: 0x040007BE RID: 1982
		[global::Cpp2ILInjected.Token(Token = "0x40009D7")]
		private const int c_XAspNetVersion = 16;

		// Token: 0x040007BF RID: 1983
		[global::Cpp2ILInjected.Token(Token = "0x40009D8")]
		private const int c_XPoweredBy = 17;

		// Token: 0x040007C0 RID: 1984
		[global::Cpp2ILInjected.Token(Token = "0x40009D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private NameValueCollection m_InnerCollection;

		// Token: 0x040007C1 RID: 1985
		[global::Cpp2ILInjected.Token(Token = "0x40009DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private WebHeaderCollectionType m_Type;

		// Token: 0x040007C2 RID: 1986
		[global::Cpp2ILInjected.Token(Token = "0x40009DB")]
		private static readonly char[] HttpTrimCharacters;

		// Token: 0x040007C3 RID: 1987
		[global::Cpp2ILInjected.Token(Token = "0x40009DC")]
		private static WebHeaderCollection.RfcChar[] RfcCharMap;

		// Token: 0x020003EF RID: 1007
		[global::Cpp2ILInjected.Token(Token = "0x20001CE")]
		internal static class HeaderEncoding
		{
			// Token: 0x06001DB3 RID: 7603 RVA: 0x00008201 File Offset: 0x00006401
			[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F16C4C", Offset = "0x1F16C4C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetString", MemberParameters = new object[]
			{
				typeof(byte*),
				typeof(int)
			}, ReturnType = typeof(string))]
			internal unsafe static string GetString(byte[] bytes, int byteIndex, int byteCount)
			{
				throw null;
			}

			// Token: 0x06001DB4 RID: 7604 RVA: 0x00008204 File Offset: 0x00006404
			[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F15920", Offset = "0x1F15920", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetString", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ParseHeaders", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int),
				typeof(ref int),
				typeof(int),
				typeof(ref WebParseError)
			}, ReturnType = typeof(DataParseStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ParseHeadersStrict", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int),
				typeof(ref int),
				typeof(int),
				typeof(ref WebParseError)
			}, ReturnType = typeof(DataParseStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal unsafe static string GetString(byte* pBytes, int byteCount)
			{
				throw null;
			}

			// Token: 0x06001DB5 RID: 7605 RVA: 0x00008207 File Offset: 0x00006407
			[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F16C70", Offset = "0x1F16C70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal static int GetByteCount(string myString)
			{
				throw null;
			}

			// Token: 0x06001DB6 RID: 7606 RVA: 0x0000820A File Offset: 0x0000640A
			[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F16C78", Offset = "0x1F16C78", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			internal static void GetBytes(string myString, int charIndex, int charCount, byte[] bytes, int byteIndex)
			{
				throw null;
			}

			// Token: 0x06001DB7 RID: 7607 RVA: 0x0000820D File Offset: 0x0000640D
			[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F14CF0", Offset = "0x1F14CF0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection.HeaderEncoding), Member = "GetBytes", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static byte[] GetBytes(string myString)
			{
				throw null;
			}

			// Token: 0x06001DB8 RID: 7608 RVA: 0x00008210 File Offset: 0x00006410
			[FriendAccessAllowed]
			[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F11F80", Offset = "0x1F11F80", Length = "0x1E8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(EncoderFallback))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallback), Member = "get_ExceptionFallback", ReturnType = typeof(DecoderFallback))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(string),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal static string DecodeUtf8FromString(string input)
			{
				throw null;
			}
		}

		// Token: 0x020003F0 RID: 1008
		[global::Cpp2ILInjected.Token(Token = "0x20001CF")]
		private enum RfcChar : byte
		{
			// Token: 0x040011CB RID: 4555
			[global::Cpp2ILInjected.Token(Token = "0x40009DE")]
			High,
			// Token: 0x040011CC RID: 4556
			[global::Cpp2ILInjected.Token(Token = "0x40009DF")]
			Reg,
			// Token: 0x040011CD RID: 4557
			[global::Cpp2ILInjected.Token(Token = "0x40009E0")]
			Ctl,
			// Token: 0x040011CE RID: 4558
			[global::Cpp2ILInjected.Token(Token = "0x40009E1")]
			CR,
			// Token: 0x040011CF RID: 4559
			[global::Cpp2ILInjected.Token(Token = "0x40009E2")]
			LF,
			// Token: 0x040011D0 RID: 4560
			[global::Cpp2ILInjected.Token(Token = "0x40009E3")]
			WS,
			// Token: 0x040011D1 RID: 4561
			[global::Cpp2ILInjected.Token(Token = "0x40009E4")]
			Colon,
			// Token: 0x040011D2 RID: 4562
			[global::Cpp2ILInjected.Token(Token = "0x40009E5")]
			Delim
		}
	}
}
