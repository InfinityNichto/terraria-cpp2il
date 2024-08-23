using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000052 RID: 82
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	internal static class EnumUtils
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00002AD7 File Offset: 0x00000CD7
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD72CC", Offset = "0x1CD72CC", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEqualityComparer`1<TFirst>", "System.Collections.Generic.IEqualityComparer`1<TSecond>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetFields", ReturnType = typeof(FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Cast", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetBySecond", MemberParameters = new object[] { "TSecond", "TFirst&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "Set", MemberParameters = new object[] { "TFirst", "TSecond" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002ADA File Offset: 0x00000CDA
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002ADD File Offset: 0x00000CDD
		[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
		public static IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002AE0 File Offset: 0x00000CE0
		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		public static IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002AE3 File Offset: 0x00000CE3
		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCA848", Offset = "0x1CCA848", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "BuildStateArray", ReturnType = typeof(JsonWriter.State[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetFields", ReturnType = typeof(FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static IList<object> GetValues(Type enumType)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002AE6 File Offset: 0x00000CE6
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD76CC", Offset = "0x1CD76CC", Length = "0x4E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetFields", ReturnType = typeof(FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static IList<string> GetNames(Type enumType)
		{
			throw null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002AE9 File Offset: 0x00000CE9
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD7BB0", Offset = "0x1CD7BB0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EnumUtils), Member = "ResolvedEnumName", MemberParameters = new object[]
		{
			typeof(BidirectionalDictionary<string, string>),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			throw null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002AEC File Offset: 0x00000CEC
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD7E54", Offset = "0x1CD7E54", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetByFirst", MemberParameters = new object[] { "TFirst", "TSecond&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			throw null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002AEF File Offset: 0x00000CEF
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD7DE4", Offset = "0x1CD7DE4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetBySecond", MemberParameters = new object[] { "TSecond", "TFirst&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			throw null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002AF2 File Offset: 0x00000CF2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD81D0", Offset = "0x1CD81D0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = ".ctor", MemberParameters = new object[] { "System.Func`2<TKey, TValue>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static EnumUtils()
		{
			throw null;
		}

		// Token: 0x040001B5 RID: 437
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;

		// Token: 0x02000105 RID: 261
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000066")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AB2 RID: 2738 RVA: 0x00003F92 File Offset: 0x00002192
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD82AC", Offset = "0x1CD82AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x00003F95 File Offset: 0x00002195
			[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD8308", Offset = "0x1CD8308", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000AB4 RID: 2740 RVA: 0x00003F98 File Offset: 0x00002198
			[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD8310", Offset = "0x1CD8310", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <InitializeEnumType>b__1_0(EnumMemberAttribute a)
			{
				throw null;
			}

			// Token: 0x06000AB5 RID: 2741 RVA: 0x00003F9B File Offset: 0x0000219B
			[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD8318", Offset = "0x1CD8318", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
			internal bool <GetValues>b__5_0(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x06000AB6 RID: 2742 RVA: 0x00003F9E File Offset: 0x0000219E
			[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD8324", Offset = "0x1CD8324", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
			internal bool <GetNames>b__6_0(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x04000399 RID: 921
			[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
			public static readonly EnumUtils.<>c <>9;

			// Token: 0x0400039A RID: 922
			[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
			public static Func<EnumMemberAttribute, string> <>9__1_0;

			// Token: 0x0400039B RID: 923
			[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
			public static Func<FieldInfo, bool> <>9__5_0;

			// Token: 0x0400039C RID: 924
			[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
			public static Func<FieldInfo, bool> <>9__6_0;
		}

		// Token: 0x02000106 RID: 262
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000067")]
		[Serializable]
		private sealed class <>c__2<T> where T : struct
		{
			// Token: 0x06000AB7 RID: 2743 RVA: 0x00003FA1 File Offset: 0x000021A1
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
			static <>c__2()
			{
				throw null;
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x00003FA4 File Offset: 0x000021A4
			[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
			public <>c__2()
			{
				throw null;
			}

			// Token: 0x06000AB9 RID: 2745 RVA: 0x00003FA7 File Offset: 0x000021A7
			[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
			internal bool <GetFlagsValues>b__2_0(EnumValue<ulong> v)
			{
				throw null;
			}

			// Token: 0x0400039D RID: 925
			[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
			public static readonly EnumUtils.<>c__2<T> <>9;

			// Token: 0x0400039E RID: 926
			[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
			public static Func<EnumValue<ulong>, bool> <>9__2_0;
		}
	}
}
