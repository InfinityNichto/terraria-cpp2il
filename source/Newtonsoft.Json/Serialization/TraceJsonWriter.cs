using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000067 RID: 103
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000080")]
	internal class TraceJsonWriter : JsonWriter
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00002D14 File Offset: 0x00000F14
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0A34", Offset = "0x1CE0A34", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_DateFormatHandling", MemberParameters = new object[] { typeof(DateFormatHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_DateTimeZoneHandling", MemberParameters = new object[] { typeof(DateTimeZoneHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "set_FloatFormatHandling", MemberParameters = new object[] { typeof(FloatFormatHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public TraceJsonWriter(JsonWriter innerWriter)
		{
			throw null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002D17 File Offset: 0x00000F17
		[global::Cpp2ILInjected.Token(Token = "0x6000480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0BD4", Offset = "0x1CE0BD4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetSerializedJsonMessage()
		{
			throw null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002D1A File Offset: 0x00000F1A
		[global::Cpp2ILInjected.Token(Token = "0x6000481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0BE4", Offset = "0x1CE0BE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(decimal value)
		{
			throw null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002D1D File Offset: 0x00000F1D
		[global::Cpp2ILInjected.Token(Token = "0x6000482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0C50", Offset = "0x1CE0C50", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(bool value)
		{
			throw null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002D20 File Offset: 0x00000F20
		[global::Cpp2ILInjected.Token(Token = "0x6000483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0CB8", Offset = "0x1CE0CB8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(byte value)
		{
			throw null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002D23 File Offset: 0x00000F23
		[global::Cpp2ILInjected.Token(Token = "0x6000484")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0D1C", Offset = "0x1CE0D1C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte?) }, ReturnType = typeof(void))]
		public override void WriteValue(byte? value)
		{
			throw null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002D26 File Offset: 0x00000F26
		[global::Cpp2ILInjected.Token(Token = "0x6000485")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0D70", Offset = "0x1CE0D70", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(char value)
		{
			throw null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002D29 File Offset: 0x00000F29
		[global::Cpp2ILInjected.Token(Token = "0x6000486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0DD4", Offset = "0x1CE0DD4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public override void WriteValue(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002D2C File Offset: 0x00000F2C
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0E24", Offset = "0x1CE0E24", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002D2F File Offset: 0x00000F2F
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0E88", Offset = "0x1CE0E88", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002D32 File Offset: 0x00000F32
		[global::Cpp2ILInjected.Token(Token = "0x6000489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0EF4", Offset = "0x1CE0EF4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(double value)
		{
			throw null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002D35 File Offset: 0x00000F35
		[global::Cpp2ILInjected.Token(Token = "0x600048A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0F58", Offset = "0x1CE0F58", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteUndefined()
		{
			throw null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002D38 File Offset: 0x00000F38
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0FAC", Offset = "0x1CE0FAC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteNull()
		{
			throw null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002D3B File Offset: 0x00000F3B
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1000", Offset = "0x1CE1000", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(float value)
		{
			throw null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002D3E File Offset: 0x00000F3E
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1064", Offset = "0x1CE1064", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(Guid value)
		{
			throw null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002D41 File Offset: 0x00000F41
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE10D0", Offset = "0x1CE10D0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(int value)
		{
			throw null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002D44 File Offset: 0x00000F44
		[global::Cpp2ILInjected.Token(Token = "0x600048F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1134", Offset = "0x1CE1134", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(long value)
		{
			throw null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002D47 File Offset: 0x00000F47
		[global::Cpp2ILInjected.Token(Token = "0x6000490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1198", Offset = "0x1CE1198", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public override void WriteValue(object value)
		{
			throw null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002D4A File Offset: 0x00000F4A
		[global::Cpp2ILInjected.Token(Token = "0x6000491")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE11E8", Offset = "0x1CE11E8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(sbyte value)
		{
			throw null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002D4D File Offset: 0x00000F4D
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE124C", Offset = "0x1CE124C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(short value)
		{
			throw null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002D50 File Offset: 0x00000F50
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE12B0", Offset = "0x1CE12B0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002D53 File Offset: 0x00000F53
		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1314", Offset = "0x1CE1314", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002D56 File Offset: 0x00000F56
		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1378", Offset = "0x1CE1378", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(uint value)
		{
			throw null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002D59 File Offset: 0x00000F59
		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE13DC", Offset = "0x1CE13DC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(ulong value)
		{
			throw null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002D5C File Offset: 0x00000F5C
		[global::Cpp2ILInjected.Token(Token = "0x6000497")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1440", Offset = "0x1CE1440", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		public override void WriteValue(Uri value)
		{
			throw null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002D5F File Offset: 0x00000F5F
		[global::Cpp2ILInjected.Token(Token = "0x6000498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1490", Offset = "0x1CE1490", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(ushort value)
		{
			throw null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002D62 File Offset: 0x00000F62
		[global::Cpp2ILInjected.Token(Token = "0x6000499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE14F4", Offset = "0x1CE14F4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002D65 File Offset: 0x00000F65
		[global::Cpp2ILInjected.Token(Token = "0x600049A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1544", Offset = "0x1CE1544", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002D68 File Offset: 0x00000F68
		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1594", Offset = "0x1CE1594", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		public override void WriteStartArray()
		{
			throw null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002D6B File Offset: 0x00000F6B
		[global::Cpp2ILInjected.Token(Token = "0x600049C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE15D0", Offset = "0x1CE15D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public override void WriteEndArray()
		{
			throw null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002D6E File Offset: 0x00000F6E
		[global::Cpp2ILInjected.Token(Token = "0x600049D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1608", Offset = "0x1CE1608", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		public override void WriteStartConstructor(string name)
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002D71 File Offset: 0x00000F71
		[global::Cpp2ILInjected.Token(Token = "0x600049E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1654", Offset = "0x1CE1654", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public override void WriteEndConstructor()
		{
			throw null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002D74 File Offset: 0x00000F74
		[global::Cpp2ILInjected.Token(Token = "0x600049F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1694", Offset = "0x1CE1694", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002D77 File Offset: 0x00000F77
		[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE16E8", Offset = "0x1CE16E8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WritePropertyName(string name, bool escape)
		{
			throw null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002D7A File Offset: 0x00000F7A
		[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1748", Offset = "0x1CE1748", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		public override void WriteStartObject()
		{
			throw null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002D7D File Offset: 0x00000F7D
		[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1784", Offset = "0x1CE1784", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public override void WriteEndObject()
		{
			throw null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002D80 File Offset: 0x00000F80
		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE17BC", Offset = "0x1CE17BC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteRawValue(string json)
		{
			throw null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002D83 File Offset: 0x00000F83
		[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1820", Offset = "0x1CE1820", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(string json)
		{
			throw null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002D86 File Offset: 0x00000F86
		[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1864", Offset = "0x1CE1864", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteAll", ReturnType = typeof(void))]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002D89 File Offset: 0x00000F89
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE1898", Offset = "0x1CE1898", Length = "0x102C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private readonly JsonWriter _innerWriter;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private readonly JsonTextWriter _textWriter;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private readonly StringWriter _sw;
	}
}
