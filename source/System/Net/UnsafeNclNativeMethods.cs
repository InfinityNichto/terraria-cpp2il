using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000222")]
	internal static class UnsafeNclNativeMethods
	{
		[global::Cpp2ILInjected.Token(Token = "0x2000223")]
		internal static class HttpApi
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000DDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B774", Offset = "0x1F3B774", Length = "0x694")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
			static HttpApi()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
			private const int HttpHeaderRequestMaximum = 41;

			[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
			private const int HttpHeaderResponseMaximum = 30;

			[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
			private static string[] m_Strings;

			[global::Cpp2ILInjected.Token(Token = "0x2000224")]
			internal static class HTTP_REQUEST_HEADER_ID
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000DDB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3BE08", Offset = "0x1F3BE08", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "get_Item", MemberParameters = new object[] { typeof(HttpRequestHeader) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "set_Item", MemberParameters = new object[]
				{
					typeof(HttpRequestHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[]
				{
					typeof(HttpRequestHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Set", MemberParameters = new object[]
				{
					typeof(HttpRequestHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(HttpRequestHeader) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal static string ToString(int position)
				{
					throw null;
				}

				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6000DDC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3BE6C", Offset = "0x1F3BE6C", Length = "0x8D0")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 87)]
				static HTTP_REQUEST_HEADER_ID()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
				private static string[] m_Strings;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000225")]
			internal static class HTTP_RESPONSE_HEADER_ID
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000DDD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3C73C", Offset = "0x1F3C73C", Length = "0x118")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
				static HTTP_RESPONSE_HEADER_ID()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6000DDE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3C854", Offset = "0x1F3C854", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal static int IndexOfKnownHeader(string HeaderName)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6000DDF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3C908", Offset = "0x1F3C908", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "get_Item", MemberParameters = new object[] { typeof(HttpResponseHeader) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "set_Item", MemberParameters = new object[]
				{
					typeof(HttpResponseHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[]
				{
					typeof(HttpResponseHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Set", MemberParameters = new object[]
				{
					typeof(HttpResponseHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
				{
					typeof(HttpResponseHeader),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(HttpResponseHeader) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				internal static string ToString(int position)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
				private static Hashtable m_Hashtable;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000226")]
			internal enum Enum
			{
				[global::Cpp2ILInjected.Token(Token = "0x4000B86")]
				HttpHeaderCacheControl,
				[global::Cpp2ILInjected.Token(Token = "0x4000B87")]
				HttpHeaderConnection,
				[global::Cpp2ILInjected.Token(Token = "0x4000B88")]
				HttpHeaderDate,
				[global::Cpp2ILInjected.Token(Token = "0x4000B89")]
				HttpHeaderKeepAlive,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8A")]
				HttpHeaderPragma,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8B")]
				HttpHeaderTrailer,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8C")]
				HttpHeaderTransferEncoding,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8D")]
				HttpHeaderUpgrade,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8E")]
				HttpHeaderVia,
				[global::Cpp2ILInjected.Token(Token = "0x4000B8F")]
				HttpHeaderWarning,
				[global::Cpp2ILInjected.Token(Token = "0x4000B90")]
				HttpHeaderAllow,
				[global::Cpp2ILInjected.Token(Token = "0x4000B91")]
				HttpHeaderContentLength,
				[global::Cpp2ILInjected.Token(Token = "0x4000B92")]
				HttpHeaderContentType,
				[global::Cpp2ILInjected.Token(Token = "0x4000B93")]
				HttpHeaderContentEncoding,
				[global::Cpp2ILInjected.Token(Token = "0x4000B94")]
				HttpHeaderContentLanguage,
				[global::Cpp2ILInjected.Token(Token = "0x4000B95")]
				HttpHeaderContentLocation,
				[global::Cpp2ILInjected.Token(Token = "0x4000B96")]
				HttpHeaderContentMd5,
				[global::Cpp2ILInjected.Token(Token = "0x4000B97")]
				HttpHeaderContentRange,
				[global::Cpp2ILInjected.Token(Token = "0x4000B98")]
				HttpHeaderExpires,
				[global::Cpp2ILInjected.Token(Token = "0x4000B99")]
				HttpHeaderLastModified,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9A")]
				HttpHeaderAcceptRanges,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9B")]
				HttpHeaderAge,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9C")]
				HttpHeaderEtag,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9D")]
				HttpHeaderLocation,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9E")]
				HttpHeaderProxyAuthenticate,
				[global::Cpp2ILInjected.Token(Token = "0x4000B9F")]
				HttpHeaderRetryAfter,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA0")]
				HttpHeaderServer,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA1")]
				HttpHeaderSetCookie,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA2")]
				HttpHeaderVary,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA3")]
				HttpHeaderWwwAuthenticate,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA4")]
				HttpHeaderResponseMaximum,
				[global::Cpp2ILInjected.Token(Token = "0x4000BA5")]
				HttpHeaderMaximum = 41
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000227")]
		internal static class SecureStringHelper
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3C96C", Offset = "0x1F3C96C", Length = "0x1B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = "InternalGetPassword", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "SecureStringToGlobalAllocUnicode", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			internal static string CreateString(SecureString secureString)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000DE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CB1C", Offset = "0x1F3CB1C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(char*),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal unsafe static SecureString CreateSecureString(string plainString)
			{
				throw null;
			}
		}
	}
}
