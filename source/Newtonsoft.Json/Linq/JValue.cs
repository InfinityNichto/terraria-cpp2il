using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000A2 RID: 162
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	public class JValue : JToken, IFormattable, IComparable, IConvertible
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x000038CF File Offset: 0x00001ACF
		[global::Cpp2ILInjected.Token(Token = "0x6000938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B3E4", Offset = "0x1D1B3E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal JValue(object value, JTokenType type)
		{
			throw null;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000038D2 File Offset: 0x00001AD2
		[global::Cpp2ILInjected.Token(Token = "0x6000939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B458", Offset = "0x1D1B458", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new object[] { typeof(JRaw) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JRaw), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "CloneToken", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(JValue other)
		{
			throw null;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000038D5 File Offset: 0x00001AD5
		[global::Cpp2ILInjected.Token(Token = "0x600093A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B4D8", Offset = "0x1D1B4D8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(long value)
		{
			throw null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000038D8 File Offset: 0x00001AD8
		[global::Cpp2ILInjected.Token(Token = "0x600093B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B544", Offset = "0x1D1B544", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JValue(decimal value)
		{
			throw null;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000038DB File Offset: 0x00001ADB
		[global::Cpp2ILInjected.Token(Token = "0x600093C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B5E4", Offset = "0x1D1B5E4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(char value)
		{
			throw null;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000038DE File Offset: 0x00001ADE
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600093D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B650", Offset = "0x1D1B650", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(ulong value)
		{
			throw null;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000038E1 File Offset: 0x00001AE1
		[global::Cpp2ILInjected.Token(Token = "0x600093E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B6BC", Offset = "0x1D1B6BC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(double value)
		{
			throw null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000038E4 File Offset: 0x00001AE4
		[global::Cpp2ILInjected.Token(Token = "0x600093F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B728", Offset = "0x1D1B728", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(float value)
		{
			throw null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000038E7 File Offset: 0x00001AE7
		[global::Cpp2ILInjected.Token(Token = "0x6000940")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B794", Offset = "0x1D1B794", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000038EA File Offset: 0x00001AEA
		[global::Cpp2ILInjected.Token(Token = "0x6000941")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B800", Offset = "0x1D1B800", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000038ED File Offset: 0x00001AED
		[global::Cpp2ILInjected.Token(Token = "0x6000942")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B878", Offset = "0x1D1B878", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(bool value)
		{
			throw null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000038F0 File Offset: 0x00001AF0
		[global::Cpp2ILInjected.Token(Token = "0x6000943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B8E4", Offset = "0x1D1B8E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		public JValue(string value)
		{
			throw null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000038F3 File Offset: 0x00001AF3
		[global::Cpp2ILInjected.Token(Token = "0x6000944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B8EC", Offset = "0x1D1B8EC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(Guid value)
		{
			throw null;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000038F6 File Offset: 0x00001AF6
		[global::Cpp2ILInjected.Token(Token = "0x6000945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B964", Offset = "0x1D1B964", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(Uri value)
		{
			throw null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000038F9 File Offset: 0x00001AF9
		[global::Cpp2ILInjected.Token(Token = "0x6000946")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1B9E8", Offset = "0x1D1B9E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Implicit", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000038FC File Offset: 0x00001AFC
		[global::Cpp2ILInjected.Token(Token = "0x6000947")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1BA54", Offset = "0x1D1BA54", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new object[]
		{
			typeof(JTokenType?),
			typeof(object)
		}, ReturnType = typeof(JTokenType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		public JValue(object value)
		{
			throw null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000038FF File Offset: 0x00001AFF
		[global::Cpp2ILInjected.Token(Token = "0x6000948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1BE88", Offset = "0x1D1BE88", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override bool DeepEquals(JToken node)
		{
			throw null;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00003902 File Offset: 0x00001B02
		[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
		public override bool HasValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000949")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1BF74", Offset = "0x1D1BF74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00003905 File Offset: 0x00001B05
		[global::Cpp2ILInjected.Token(Token = "0x600094A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1BF7C", Offset = "0x1D1BF7C", Length = "0x874")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "ValuesEquals", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "CompareTo", MemberParameters = new object[] { typeof(JValue) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "IsMatch", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer<object>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ByteArrayCompare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CompareFloat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "CompareTo", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "CompareTo", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "CompareTo", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 59)]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			throw null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00003908 File Offset: 0x00001B08
		[global::Cpp2ILInjected.Token(Token = "0x600094B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1C7F0", Offset = "0x1D1C7F0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathUtils), Member = "ApproxEquals", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int CompareFloat(object objA, object objB)
		{
			throw null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000390B File Offset: 0x00001B0B
		[global::Cpp2ILInjected.Token(Token = "0x600094C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1C8EC", Offset = "0x1D1C8EC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(JValue) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000390E File Offset: 0x00001B0E
		[global::Cpp2ILInjected.Token(Token = "0x600094D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1C944", Offset = "0x1D1C944", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JValue CreateComment(string value)
		{
			throw null;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00003911 File Offset: 0x00001B11
		[global::Cpp2ILInjected.Token(Token = "0x600094E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1C9A0", Offset = "0x1D1C9A0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JValue CreateString(string value)
		{
			throw null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00003914 File Offset: 0x00001B14
		[global::Cpp2ILInjected.Token(Token = "0x600094F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1A610", Offset = "0x1D1A610", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "EnsureParentToken", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "set_Value", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JValue CreateNull()
		{
			throw null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00003917 File Offset: 0x00001B17
		[global::Cpp2ILInjected.Token(Token = "0x6000950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1C9FC", Offset = "0x1D1C9FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "ReadContentFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static JValue CreateUndefined()
		{
			throw null;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0000391A File Offset: 0x00001B1A
		[global::Cpp2ILInjected.Token(Token = "0x6000951")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1BA84", Offset = "0x1D1BA84", Length = "0x404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "set_Value", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "GetStringValueType", MemberParameters = new object[] { typeof(JTokenType?) }, ReturnType = typeof(JTokenType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			throw null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0000391D File Offset: 0x00001B1D
		[global::Cpp2ILInjected.Token(Token = "0x6000952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1CA54", Offset = "0x1D1CA54", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new object[]
		{
			typeof(JTokenType?),
			typeof(object)
		}, ReturnType = typeof(JTokenType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			throw null;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00003920 File Offset: 0x00001B20
		[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
		public override JTokenType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000953")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1CAD0", Offset = "0x1D1CAD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00003923 File Offset: 0x00001B23
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00003926 File Offset: 0x00001B26
		[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
		public new object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000954")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1CAD8", Offset = "0x1D1CAD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000955")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1CAE0", Offset = "0x1D1CAE0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new object[]
			{
				typeof(JTokenType?),
				typeof(object)
			}, ReturnType = typeof(JTokenType))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00003929 File Offset: 0x00001B29
		[global::Cpp2ILInjected.Token(Token = "0x6000956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1CB90", Offset = "0x1D1CB90", Length = "0x6FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new object[]
		{
			typeof(IList<JsonConverter>),
			typeof(Type)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "CreateDefault", ReturnType = typeof(JsonSerializer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			throw null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000392C File Offset: 0x00001B2C
		[global::Cpp2ILInjected.Token(Token = "0x6000957")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D28C", Offset = "0x1D1D28C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		internal override int GetDeepHashCode()
		{
			throw null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000392F File Offset: 0x00001B2F
		[global::Cpp2ILInjected.Token(Token = "0x6000958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1BF24", Offset = "0x1D1BF24", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "Equals", MemberParameters = new object[] { typeof(JValue) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			throw null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00003932 File Offset: 0x00001B32
		[global::Cpp2ILInjected.Token(Token = "0x6000959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D2E0", Offset = "0x1D1D2E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "ValuesEquals", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		public bool Equals(JValue other)
		{
			throw null;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00003935 File Offset: 0x00001B35
		[global::Cpp2ILInjected.Token(Token = "0x600095A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D2F0", Offset = "0x1D1D2F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "ValuesEquals", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00003938 File Offset: 0x00001B38
		[global::Cpp2ILInjected.Token(Token = "0x600095B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D394", Offset = "0x1D1D394", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0000393B File Offset: 0x00001B3B
		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D3AC", Offset = "0x1D1D3AC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0000393E File Offset: 0x00001B3E
		[global::Cpp2ILInjected.Token(Token = "0x600095D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D414", Offset = "0x1D1D414", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00003941 File Offset: 0x00001B41
		[global::Cpp2ILInjected.Token(Token = "0x600095E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D594", Offset = "0x1D1D594", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		public string ToString(IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00003944 File Offset: 0x00001B44
		[global::Cpp2ILInjected.Token(Token = "0x600095F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D484", Offset = "0x1D1D484", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00003947 File Offset: 0x00001B47
		[global::Cpp2ILInjected.Token(Token = "0x6000960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D5A0", Offset = "0x1D1D5A0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.IComparable.CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000394A File Offset: 0x00001B4A
		[global::Cpp2ILInjected.Token(Token = "0x6000961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D634", Offset = "0x1D1D634", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		public int CompareTo(JValue obj)
		{
			throw null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0000394D File Offset: 0x00001B4D
		[global::Cpp2ILInjected.Token(Token = "0x6000962")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D658", Offset = "0x1D1D658", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private TypeCode System.IConvertible.GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00003950 File Offset: 0x00001B50
		[global::Cpp2ILInjected.Token(Token = "0x6000963")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D714", Offset = "0x1D1D714", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00003953 File Offset: 0x00001B53
		[global::Cpp2ILInjected.Token(Token = "0x6000964")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D76C", Offset = "0x1D1D76C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00003956 File Offset: 0x00001B56
		[global::Cpp2ILInjected.Token(Token = "0x6000965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D7C4", Offset = "0x1D1D7C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00003959 File Offset: 0x00001B59
		[global::Cpp2ILInjected.Token(Token = "0x6000966")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D81C", Offset = "0x1D1D81C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0000395C File Offset: 0x00001B5C
		[global::Cpp2ILInjected.Token(Token = "0x6000967")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D874", Offset = "0x1D1D874", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0000395F File Offset: 0x00001B5F
		[global::Cpp2ILInjected.Token(Token = "0x6000968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D8CC", Offset = "0x1D1D8CC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00003962 File Offset: 0x00001B62
		[global::Cpp2ILInjected.Token(Token = "0x6000969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D924", Offset = "0x1D1D924", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00003965 File Offset: 0x00001B65
		[global::Cpp2ILInjected.Token(Token = "0x600096A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D97C", Offset = "0x1D1D97C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00003968 File Offset: 0x00001B68
		[global::Cpp2ILInjected.Token(Token = "0x600096B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1D9D4", Offset = "0x1D1D9D4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0000396B File Offset: 0x00001B6B
		[global::Cpp2ILInjected.Token(Token = "0x600096C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DA2C", Offset = "0x1D1DA2C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0000396E File Offset: 0x00001B6E
		[global::Cpp2ILInjected.Token(Token = "0x600096D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DA84", Offset = "0x1D1DA84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00003971 File Offset: 0x00001B71
		[global::Cpp2ILInjected.Token(Token = "0x600096E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DADC", Offset = "0x1D1DADC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00003974 File Offset: 0x00001B74
		[global::Cpp2ILInjected.Token(Token = "0x600096F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DB34", Offset = "0x1D1DB34", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00003977 File Offset: 0x00001B77
		[global::Cpp2ILInjected.Token(Token = "0x6000970")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DB8C", Offset = "0x1D1DB8C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DateTime System.IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000397A File Offset: 0x00001B7A
		[global::Cpp2ILInjected.Token(Token = "0x6000971")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DBE4", Offset = "0x1D1DBE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x040002C1 RID: 705
		[global::Cpp2ILInjected.Token(Token = "0x4000384")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		// Token: 0x040002C2 RID: 706
		[global::Cpp2ILInjected.Token(Token = "0x4000385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _value;
	}
}
