using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200017F RID: 383
	[global::Cpp2ILInjected.Token(Token = "0x2000222")]
	internal static class UnsafeNclNativeMethods
	{
		// Token: 0x0200040A RID: 1034
		[global::Cpp2ILInjected.Token(Token = "0x2000223")]
		internal static class HttpApi
		{
			// Token: 0x06001E02 RID: 7682 RVA: 0x000082D9 File Offset: 0x000064D9
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000DDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B774", Offset = "0x1F3B774", Length = "0x694")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
			static HttpApi()
			{
				throw null;
			}

			// Token: 0x04001219 RID: 4633
			[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
			private const int HttpHeaderRequestMaximum = 41;

			// Token: 0x0400121A RID: 4634
			[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
			private const int HttpHeaderResponseMaximum = 30;

			// Token: 0x0400121B RID: 4635
			[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
			private static string[] m_Strings;

			// Token: 0x020004B7 RID: 1207
			[global::Cpp2ILInjected.Token(Token = "0x2000224")]
			internal static class HTTP_REQUEST_HEADER_ID
			{
				// Token: 0x06002005 RID: 8197 RVA: 0x000087BC File Offset: 0x000069BC
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

				// Token: 0x06002006 RID: 8198 RVA: 0x000087BF File Offset: 0x000069BF
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x6000DDC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3BE6C", Offset = "0x1F3BE6C", Length = "0x8D0")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 87)]
				static HTTP_REQUEST_HEADER_ID()
				{
					throw null;
				}

				// Token: 0x0400141F RID: 5151
				[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
				private static string[] m_Strings;
			}

			// Token: 0x020004B8 RID: 1208
			[global::Cpp2ILInjected.Token(Token = "0x2000225")]
			internal static class HTTP_RESPONSE_HEADER_ID
			{
				// Token: 0x06002007 RID: 8199 RVA: 0x000087C2 File Offset: 0x000069C2
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

				// Token: 0x06002008 RID: 8200 RVA: 0x000087C5 File Offset: 0x000069C5
				[global::Cpp2ILInjected.Token(Token = "0x6000DDE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F3C854", Offset = "0x1F3C854", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				internal static int IndexOfKnownHeader(string HeaderName)
				{
					throw null;
				}

				// Token: 0x06002009 RID: 8201 RVA: 0x000087C8 File Offset: 0x000069C8
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

				// Token: 0x04001420 RID: 5152
				[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
				private static Hashtable m_Hashtable;
			}

			// Token: 0x020004B9 RID: 1209
			[global::Cpp2ILInjected.Token(Token = "0x2000226")]
			internal enum Enum
			{
				// Token: 0x04001422 RID: 5154
				[global::Cpp2ILInjected.Token(Token = "0x4000B86")]
				HttpHeaderCacheControl,
				// Token: 0x04001423 RID: 5155
				[global::Cpp2ILInjected.Token(Token = "0x4000B87")]
				HttpHeaderConnection,
				// Token: 0x04001424 RID: 5156
				[global::Cpp2ILInjected.Token(Token = "0x4000B88")]
				HttpHeaderDate,
				// Token: 0x04001425 RID: 5157
				[global::Cpp2ILInjected.Token(Token = "0x4000B89")]
				HttpHeaderKeepAlive,
				// Token: 0x04001426 RID: 5158
				[global::Cpp2ILInjected.Token(Token = "0x4000B8A")]
				HttpHeaderPragma,
				// Token: 0x04001427 RID: 5159
				[global::Cpp2ILInjected.Token(Token = "0x4000B8B")]
				HttpHeaderTrailer,
				// Token: 0x04001428 RID: 5160
				[global::Cpp2ILInjected.Token(Token = "0x4000B8C")]
				HttpHeaderTransferEncoding,
				// Token: 0x04001429 RID: 5161
				[global::Cpp2ILInjected.Token(Token = "0x4000B8D")]
				HttpHeaderUpgrade,
				// Token: 0x0400142A RID: 5162
				[global::Cpp2ILInjected.Token(Token = "0x4000B8E")]
				HttpHeaderVia,
				// Token: 0x0400142B RID: 5163
				[global::Cpp2ILInjected.Token(Token = "0x4000B8F")]
				HttpHeaderWarning,
				// Token: 0x0400142C RID: 5164
				[global::Cpp2ILInjected.Token(Token = "0x4000B90")]
				HttpHeaderAllow,
				// Token: 0x0400142D RID: 5165
				[global::Cpp2ILInjected.Token(Token = "0x4000B91")]
				HttpHeaderContentLength,
				// Token: 0x0400142E RID: 5166
				[global::Cpp2ILInjected.Token(Token = "0x4000B92")]
				HttpHeaderContentType,
				// Token: 0x0400142F RID: 5167
				[global::Cpp2ILInjected.Token(Token = "0x4000B93")]
				HttpHeaderContentEncoding,
				// Token: 0x04001430 RID: 5168
				[global::Cpp2ILInjected.Token(Token = "0x4000B94")]
				HttpHeaderContentLanguage,
				// Token: 0x04001431 RID: 5169
				[global::Cpp2ILInjected.Token(Token = "0x4000B95")]
				HttpHeaderContentLocation,
				// Token: 0x04001432 RID: 5170
				[global::Cpp2ILInjected.Token(Token = "0x4000B96")]
				HttpHeaderContentMd5,
				// Token: 0x04001433 RID: 5171
				[global::Cpp2ILInjected.Token(Token = "0x4000B97")]
				HttpHeaderContentRange,
				// Token: 0x04001434 RID: 5172
				[global::Cpp2ILInjected.Token(Token = "0x4000B98")]
				HttpHeaderExpires,
				// Token: 0x04001435 RID: 5173
				[global::Cpp2ILInjected.Token(Token = "0x4000B99")]
				HttpHeaderLastModified,
				// Token: 0x04001436 RID: 5174
				[global::Cpp2ILInjected.Token(Token = "0x4000B9A")]
				HttpHeaderAcceptRanges,
				// Token: 0x04001437 RID: 5175
				[global::Cpp2ILInjected.Token(Token = "0x4000B9B")]
				HttpHeaderAge,
				// Token: 0x04001438 RID: 5176
				[global::Cpp2ILInjected.Token(Token = "0x4000B9C")]
				HttpHeaderEtag,
				// Token: 0x04001439 RID: 5177
				[global::Cpp2ILInjected.Token(Token = "0x4000B9D")]
				HttpHeaderLocation,
				// Token: 0x0400143A RID: 5178
				[global::Cpp2ILInjected.Token(Token = "0x4000B9E")]
				HttpHeaderProxyAuthenticate,
				// Token: 0x0400143B RID: 5179
				[global::Cpp2ILInjected.Token(Token = "0x4000B9F")]
				HttpHeaderRetryAfter,
				// Token: 0x0400143C RID: 5180
				[global::Cpp2ILInjected.Token(Token = "0x4000BA0")]
				HttpHeaderServer,
				// Token: 0x0400143D RID: 5181
				[global::Cpp2ILInjected.Token(Token = "0x4000BA1")]
				HttpHeaderSetCookie,
				// Token: 0x0400143E RID: 5182
				[global::Cpp2ILInjected.Token(Token = "0x4000BA2")]
				HttpHeaderVary,
				// Token: 0x0400143F RID: 5183
				[global::Cpp2ILInjected.Token(Token = "0x4000BA3")]
				HttpHeaderWwwAuthenticate,
				// Token: 0x04001440 RID: 5184
				[global::Cpp2ILInjected.Token(Token = "0x4000BA4")]
				HttpHeaderResponseMaximum,
				// Token: 0x04001441 RID: 5185
				[global::Cpp2ILInjected.Token(Token = "0x4000BA5")]
				HttpHeaderMaximum = 41
			}
		}

		// Token: 0x0200040B RID: 1035
		[global::Cpp2ILInjected.Token(Token = "0x2000227")]
		internal static class SecureStringHelper
		{
			// Token: 0x06001E03 RID: 7683 RVA: 0x000082DC File Offset: 0x000064DC
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

			// Token: 0x06001E04 RID: 7684 RVA: 0x000082DF File Offset: 0x000064DF
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
