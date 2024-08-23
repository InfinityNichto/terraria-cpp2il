using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000097 RID: 151
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
	public static class Extensions
	{
		// Token: 0x0600067E RID: 1662 RVA: 0x00003386 File Offset: 0x00001586
		[global::Cpp2ILInjected.Token(Token = "0x60006F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589304", Offset = "0x1589304", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00003389 File Offset: 0x00001589
		[global::Cpp2ILInjected.Token(Token = "0x60006F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589468", Offset = "0x1589468", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000338C File Offset: 0x0000158C
		[global::Cpp2ILInjected.Token(Token = "0x60006F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589FC0", Offset = "0x1589FC0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			throw null;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000338F File Offset: 0x0000158F
		[global::Cpp2ILInjected.Token(Token = "0x60006F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A124", Offset = "0x158A124", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : JContainer
		{
			throw null;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00003392 File Offset: 0x00001592
		[global::Cpp2ILInjected.Token(Token = "0x60006F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04A8C", Offset = "0x1D04A8C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SelectMany", MemberTypeParameters = new object[] { "TSource", "TResult" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, IEnumerable`1<TResult>>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "Newtonsoft.Json.Linq.IJEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			throw null;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00003395 File Offset: 0x00001595
		[global::Cpp2ILInjected.Token(Token = "0x60006FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04BC4", Offset = "0x1D04BC4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Values", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "Values", MemberTypeParameters = new object[] { "T", "U" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<T>",
			typeof(object)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<U>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, object key)
		{
			throw null;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00003398 File Offset: 0x00001598
		[global::Cpp2ILInjected.Token(Token = "0x60006FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04C68", Offset = "0x1D04C68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "Values", MemberParameters = new object[]
		{
			typeof(IEnumerable<JToken>),
			typeof(object)
		}, ReturnType = typeof(IJEnumerable<JToken>))]
		public static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			throw null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000339B File Offset: 0x0000159B
		[global::Cpp2ILInjected.Token(Token = "0x60006FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A4AC", Offset = "0x158A4AC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, object key)
		{
			throw null;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000339E File Offset: 0x0000159E
		[global::Cpp2ILInjected.Token(Token = "0x60006FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A498", Offset = "0x158A498", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			throw null;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000033A1 File Offset: 0x000015A1
		[global::Cpp2ILInjected.Token(Token = "0x60006FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A288", Offset = "0x158A288", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "LoadManifest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static U Value<U>(this IEnumerable<JToken> value)
		{
			throw null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000033A4 File Offset: 0x000015A4
		[global::Cpp2ILInjected.Token(Token = "0x60006FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A2A8", Offset = "0x158A2A8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static U Value<T, U>(this IEnumerable<T> value) where T : JToken
		{
			throw null;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000033A7 File Offset: 0x000015A7
		[global::Cpp2ILInjected.Token(Token = "0x6000700")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A4BC", Offset = "0x158A4BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Values", MemberParameters = new object[]
		{
			typeof(IEnumerable<JToken>),
			typeof(object)
		}, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, object key) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000033AA File Offset: 0x000015AA
		[global::Cpp2ILInjected.Token(Token = "0x6000701")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589690", Offset = "0x1589690", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		public static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000033AD File Offset: 0x000015AD
		[global::Cpp2ILInjected.Token(Token = "0x6000702")]
		[global::Cpp2ILInjected.Address(RVA = "0x15896B0", Offset = "0x15896B0", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000033B0 File Offset: 0x000015B0
		[global::Cpp2ILInjected.Token(Token = "0x6000703")]
		[global::Cpp2ILInjected.Address(RVA = "0x1589BB0", Offset = "0x1589BB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000033B3 File Offset: 0x000015B3
		[global::Cpp2ILInjected.Token(Token = "0x6000704")]
		[global::Cpp2ILInjected.Address(RVA = "0x158981C", Offset = "0x158981C", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		internal static U Convert<T, U>(this T token) where T : JToken
		{
			throw null;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000033B6 File Offset: 0x000015B6
		[global::Cpp2ILInjected.Token(Token = "0x6000705")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04C20", Offset = "0x1D04C20", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Ancestors", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "AncestorsAndSelf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Descendants", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "DescendantsAndSelf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Children", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "AsJEnumerable", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = "Newtonsoft.Json.Linq.IJEnumerable`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			throw null;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000033B9 File Offset: 0x000015B9
		[global::Cpp2ILInjected.Token(Token = "0x6000706")]
		[global::Cpp2ILInjected.Address(RVA = "0x15895CC", Offset = "0x15895CC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Properties", MemberParameters = new object[] { typeof(IEnumerable<JObject>) }, ReturnType = typeof(IJEnumerable<JProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "AsJEnumerable", MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = typeof(IJEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			throw null;
		}

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
		[Serializable]
		private sealed class <>c__0<T> where T : JToken
		{
			// Token: 0x06000AF6 RID: 2806 RVA: 0x0000405E File Offset: 0x0000225E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000707")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1774", Offset = "0x15B1774", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__0()
			{
				throw null;
			}

			// Token: 0x06000AF7 RID: 2807 RVA: 0x00004061 File Offset: 0x00002261
			[global::Cpp2ILInjected.Token(Token = "0x6000708")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1860", Offset = "0x15B1860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__0()
			{
				throw null;
			}

			// Token: 0x06000AF8 RID: 2808 RVA: 0x00004064 File Offset: 0x00002264
			[global::Cpp2ILInjected.Token(Token = "0x6000709")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1868", Offset = "0x15B1868", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "Ancestors", ReturnType = typeof(IEnumerable<JToken>))]
			internal IEnumerable<JToken> <Ancestors>b__0_0(T j)
			{
				throw null;
			}

			// Token: 0x040003D3 RID: 979
			[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
			public static readonly Extensions.<>c__0<T> <>9;

			// Token: 0x040003D4 RID: 980
			[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
			public static Func<T, IEnumerable<JToken>> <>9__0_0;
		}

		// Token: 0x0200011D RID: 285
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
		[Serializable]
		private sealed class <>c__1<T> where T : JToken
		{
			// Token: 0x06000AF9 RID: 2809 RVA: 0x00004067 File Offset: 0x00002267
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600070A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B19D8", Offset = "0x15B19D8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__1()
			{
				throw null;
			}

			// Token: 0x06000AFA RID: 2810 RVA: 0x0000406A File Offset: 0x0000226A
			[global::Cpp2ILInjected.Token(Token = "0x600070B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1AC4", Offset = "0x15B1AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__1()
			{
				throw null;
			}

			// Token: 0x06000AFB RID: 2811 RVA: 0x0000406D File Offset: 0x0000226D
			[global::Cpp2ILInjected.Token(Token = "0x600070C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1ACC", Offset = "0x15B1ACC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "AncestorsAndSelf", ReturnType = typeof(IEnumerable<JToken>))]
			internal IEnumerable<JToken> <AncestorsAndSelf>b__1_0(T j)
			{
				throw null;
			}

			// Token: 0x040003D5 RID: 981
			[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
			public static readonly Extensions.<>c__1<T> <>9;

			// Token: 0x040003D6 RID: 982
			[global::Cpp2ILInjected.Token(Token = "0x4000300")]
			public static Func<T, IEnumerable<JToken>> <>9__1_0;
		}

		// Token: 0x0200011E RID: 286
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
		[Serializable]
		private sealed class <>c__2<T> where T : JContainer
		{
			// Token: 0x06000AFC RID: 2812 RVA: 0x00004070 File Offset: 0x00002270
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600070D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1DB8", Offset = "0x15B1DB8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__2()
			{
				throw null;
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x00004073 File Offset: 0x00002273
			[global::Cpp2ILInjected.Token(Token = "0x600070E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1EA4", Offset = "0x15B1EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__2()
			{
				throw null;
			}

			// Token: 0x06000AFE RID: 2814 RVA: 0x00004076 File Offset: 0x00002276
			[global::Cpp2ILInjected.Token(Token = "0x600070F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1EAC", Offset = "0x15B1EAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "Descendants", ReturnType = typeof(IEnumerable<JToken>))]
			internal IEnumerable<JToken> <Descendants>b__2_0(T j)
			{
				throw null;
			}

			// Token: 0x040003D7 RID: 983
			[global::Cpp2ILInjected.Token(Token = "0x4000301")]
			public static readonly Extensions.<>c__2<T> <>9;

			// Token: 0x040003D8 RID: 984
			[global::Cpp2ILInjected.Token(Token = "0x4000302")]
			public static Func<T, IEnumerable<JToken>> <>9__2_0;
		}

		// Token: 0x0200011F RID: 287
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
		[Serializable]
		private sealed class <>c__3<T> where T : JContainer
		{
			// Token: 0x06000AFF RID: 2815 RVA: 0x00004079 File Offset: 0x00002279
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000710")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1EB8", Offset = "0x15B1EB8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__3()
			{
				throw null;
			}

			// Token: 0x06000B00 RID: 2816 RVA: 0x0000407C File Offset: 0x0000227C
			[global::Cpp2ILInjected.Token(Token = "0x6000711")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1FA4", Offset = "0x15B1FA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__3()
			{
				throw null;
			}

			// Token: 0x06000B01 RID: 2817 RVA: 0x0000407F File Offset: 0x0000227F
			[global::Cpp2ILInjected.Token(Token = "0x6000712")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1FAC", Offset = "0x15B1FAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "DescendantsAndSelf", ReturnType = typeof(IEnumerable<JToken>))]
			internal IEnumerable<JToken> <DescendantsAndSelf>b__3_0(T j)
			{
				throw null;
			}

			// Token: 0x040003D9 RID: 985
			[global::Cpp2ILInjected.Token(Token = "0x4000303")]
			public static readonly Extensions.<>c__3<T> <>9;

			// Token: 0x040003DA RID: 986
			[global::Cpp2ILInjected.Token(Token = "0x4000304")]
			public static Func<T, IEnumerable<JToken>> <>9__3_0;
		}

		// Token: 0x02000120 RID: 288
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000B02 RID: 2818 RVA: 0x00004082 File Offset: 0x00002282
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000713")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04C70", Offset = "0x1D04C70", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000B03 RID: 2819 RVA: 0x00004085 File Offset: 0x00002285
			[global::Cpp2ILInjected.Token(Token = "0x6000714")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04CCC", Offset = "0x1D04CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000B04 RID: 2820 RVA: 0x00004088 File Offset: 0x00002288
			[global::Cpp2ILInjected.Token(Token = "0x6000715")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D04CD4", Offset = "0x1D04CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal IEnumerable<JProperty> <Properties>b__4_0(JObject d)
			{
				throw null;
			}

			// Token: 0x040003DB RID: 987
			[global::Cpp2ILInjected.Token(Token = "0x4000305")]
			public static readonly Extensions.<>c <>9;

			// Token: 0x040003DC RID: 988
			[global::Cpp2ILInjected.Token(Token = "0x4000306")]
			public static Func<JObject, IEnumerable<JProperty>> <>9__4_0;
		}

		// Token: 0x02000121 RID: 289
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
		private sealed class <Values>d__11<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IDisposable, IEnumerator where T : JToken
		{
			// Token: 0x06000B05 RID: 2821 RVA: 0x0000408B File Offset: 0x0000228B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000716")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BFCA0", Offset = "0x15BFCA0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <Values>d__11(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B06 RID: 2822 RVA: 0x0000408E File Offset: 0x0000228E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000717")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BFCDC", Offset = "0x15BFCDC", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B07 RID: 2823 RVA: 0x00004091 File Offset: 0x00002291
			[global::Cpp2ILInjected.Token(Token = "0x6000718")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BFDCC", Offset = "0x15BFDCC", Length = "0x524")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JEnumerable<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B08 RID: 2824 RVA: 0x00004094 File Offset: 0x00002294
			[global::Cpp2ILInjected.Token(Token = "0x6000719")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C02F0", Offset = "0x15C02F0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B09 RID: 2825 RVA: 0x00004097 File Offset: 0x00002297
			[global::Cpp2ILInjected.Token(Token = "0x600071A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C03A0", Offset = "0x15C03A0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000409A File Offset: 0x0000229A
			[global::Cpp2ILInjected.Token(Token = "0x17000157")]
			private U System.Collections.Generic.IEnumerator<U>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600071B")]
				[global::Cpp2ILInjected.Address(RVA = "0x15C0450", Offset = "0x15C0450", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B0B RID: 2827 RVA: 0x0000409D File Offset: 0x0000229D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600071C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0458", Offset = "0x15C0458", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x06000B0C RID: 2828 RVA: 0x000040A0 File Offset: 0x000022A0
			[global::Cpp2ILInjected.Token(Token = "0x17000158")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600071D")]
				[global::Cpp2ILInjected.Address(RVA = "0x15C0490", Offset = "0x15C0490", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x000040A3 File Offset: 0x000022A3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600071E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0498", Offset = "0x15C0498", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B0E RID: 2830 RVA: 0x000040A6 File Offset: 0x000022A6
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600071F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C0534", Offset = "0x15C0534", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040003DD RID: 989
			[global::Cpp2ILInjected.Token(Token = "0x4000307")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040003DE RID: 990
			[global::Cpp2ILInjected.Token(Token = "0x4000308")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private U <>2__current;

			// Token: 0x040003DF RID: 991
			[global::Cpp2ILInjected.Token(Token = "0x4000309")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x040003E0 RID: 992
			[global::Cpp2ILInjected.Token(Token = "0x400030A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<T> source;

			// Token: 0x040003E1 RID: 993
			[global::Cpp2ILInjected.Token(Token = "0x400030B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<T> <>3__source;

			// Token: 0x040003E2 RID: 994
			[global::Cpp2ILInjected.Token(Token = "0x400030C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private object key;

			// Token: 0x040003E3 RID: 995
			[global::Cpp2ILInjected.Token(Token = "0x400030D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public object <>3__key;

			// Token: 0x040003E4 RID: 996
			[global::Cpp2ILInjected.Token(Token = "0x400030E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private JToken <token>5__1;

			// Token: 0x040003E5 RID: 997
			[global::Cpp2ILInjected.Token(Token = "0x400030F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<T> <>7__wrap1;

			// Token: 0x040003E6 RID: 998
			[global::Cpp2ILInjected.Token(Token = "0x4000310")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<JToken> <>7__wrap2;
		}

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
		[Serializable]
		private sealed class <>c__13<T, U> where T : JToken
		{
			// Token: 0x06000B0F RID: 2831 RVA: 0x000040A9 File Offset: 0x000022A9
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000720")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1874", Offset = "0x15B1874", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__13()
			{
				throw null;
			}

			// Token: 0x06000B10 RID: 2832 RVA: 0x000040AC File Offset: 0x000022AC
			[global::Cpp2ILInjected.Token(Token = "0x6000721")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1960", Offset = "0x15B1960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__13()
			{
				throw null;
			}

			// Token: 0x06000B11 RID: 2833 RVA: 0x000040AF File Offset: 0x000022AF
			[global::Cpp2ILInjected.Token(Token = "0x6000722")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1968", Offset = "0x15B1968", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal IEnumerable<JToken> <Children>b__13_0(T c)
			{
				throw null;
			}

			// Token: 0x040003E7 RID: 999
			[global::Cpp2ILInjected.Token(Token = "0x4000311")]
			public static readonly Extensions.<>c__13<T, U> <>9;

			// Token: 0x040003E8 RID: 1000
			[global::Cpp2ILInjected.Token(Token = "0x4000312")]
			public static Func<T, IEnumerable<JToken>> <>9__13_0;
		}

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
		private sealed class <Convert>d__14<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IDisposable, IEnumerator where T : JToken
		{
			// Token: 0x06000B12 RID: 2834 RVA: 0x000040B2 File Offset: 0x000022B2
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000723")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B77DC", Offset = "0x15B77DC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <Convert>d__14(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B13 RID: 2835 RVA: 0x000040B5 File Offset: 0x000022B5
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000724")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7818", Offset = "0x15B7818", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B14 RID: 2836 RVA: 0x000040B8 File Offset: 0x000022B8
			[global::Cpp2ILInjected.Token(Token = "0x6000725")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7844", Offset = "0x15B7844", Length = "0x2EC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B15 RID: 2837 RVA: 0x000040BB File Offset: 0x000022BB
			[global::Cpp2ILInjected.Token(Token = "0x6000726")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7B30", Offset = "0x15B7B30", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000040BE File Offset: 0x000022BE
			[global::Cpp2ILInjected.Token(Token = "0x17000159")]
			private U System.Collections.Generic.IEnumerator<U>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000727")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B7BE0", Offset = "0x15B7BE0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B17 RID: 2839 RVA: 0x000040C1 File Offset: 0x000022C1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000728")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7BE8", Offset = "0x15B7BE8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000040C4 File Offset: 0x000022C4
			[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000729")]
				[global::Cpp2ILInjected.Address(RVA = "0x15B7C20", Offset = "0x15B7C20", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B19 RID: 2841 RVA: 0x000040C7 File Offset: 0x000022C7
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600072A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7C28", Offset = "0x15B7C28", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<U> System.Collections.Generic.IEnumerable<U>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B1A RID: 2842 RVA: 0x000040CA File Offset: 0x000022CA
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600072B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B7CBC", Offset = "0x15B7CBC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040003E9 RID: 1001
			[global::Cpp2ILInjected.Token(Token = "0x4000313")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x040003EA RID: 1002
			[global::Cpp2ILInjected.Token(Token = "0x4000314")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private U <>2__current;

			// Token: 0x040003EB RID: 1003
			[global::Cpp2ILInjected.Token(Token = "0x4000315")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			// Token: 0x040003EC RID: 1004
			[global::Cpp2ILInjected.Token(Token = "0x4000316")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerable<T> source;

			// Token: 0x040003ED RID: 1005
			[global::Cpp2ILInjected.Token(Token = "0x4000317")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IEnumerable<T> <>3__source;

			// Token: 0x040003EE RID: 1006
			[global::Cpp2ILInjected.Token(Token = "0x4000318")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private IEnumerator<T> <>7__wrap1;
		}
	}
}
