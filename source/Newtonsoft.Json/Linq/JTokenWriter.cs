using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200009E RID: 158
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00003665 File Offset: 0x00001865
		[global::Cpp2ILInjected.Token(Token = "0x17000189")]
		public JToken CurrentToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000826")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0FB88", Offset = "0x1D0FB88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00003668 File Offset: 0x00001868
		[global::Cpp2ILInjected.Token(Token = "0x1700018A")]
		public JToken Token
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000827")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D0FB90", Offset = "0x1D0FB90", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonContract)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000366B File Offset: 0x0000186B
		[global::Cpp2ILInjected.Token(Token = "0x6000828")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D09998", Offset = "0x1D09998", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "CreateWriter", ReturnType = typeof(JsonWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JTokenWriter(JContainer container)
		{
			throw null;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000366E File Offset: 0x0000186E
		[global::Cpp2ILInjected.Token(Token = "0x6000829")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FBAC", Offset = "0x1D0FBAC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "FromObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JTokenWriter()
		{
			throw null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00003671 File Offset: 0x00001871
		[global::Cpp2ILInjected.Token(Token = "0x600082A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FC04", Offset = "0x1D0FC04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00003674 File Offset: 0x00001874
		[global::Cpp2ILInjected.Token(Token = "0x600082B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FC08", Offset = "0x1D0FC08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00003677 File Offset: 0x00001877
		[global::Cpp2ILInjected.Token(Token = "0x600082C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FC10", Offset = "0x1D0FC10", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartObject()
		{
			throw null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000367A File Offset: 0x0000187A
		[global::Cpp2ILInjected.Token(Token = "0x600082D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FC8C", Offset = "0x1D0FC8C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		private void AddParent(JContainer container)
		{
			throw null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000367D File Offset: 0x0000187D
		[global::Cpp2ILInjected.Token(Token = "0x600082E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FCC8", Offset = "0x1D0FCC8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RemoveParent()
		{
			throw null;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00003680 File Offset: 0x00001880
		[global::Cpp2ILInjected.Token(Token = "0x600082F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FD10", Offset = "0x1D0FD10", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartArray()
		{
			throw null;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00003683 File Offset: 0x00001883
		[global::Cpp2ILInjected.Token(Token = "0x6000830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FD8C", Offset = "0x1D0FD8C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JConstructor), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartConstructor(string name)
		{
			throw null;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00003686 File Offset: 0x00001886
		[global::Cpp2ILInjected.Token(Token = "0x6000831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FE1C", Offset = "0x1D0FE1C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void WriteEnd(JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00003689 File Offset: 0x00001889
		[global::Cpp2ILInjected.Token(Token = "0x6000832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FE64", Offset = "0x1D0FE64", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JProperty), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "AddAndSkipParentCheck", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000368C File Offset: 0x0000188C
		[global::Cpp2ILInjected.Token(Token = "0x6000833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FF3C", Offset = "0x1D0FF3C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddValue(object value, JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0000368F File Offset: 0x0000188F
		[global::Cpp2ILInjected.Token(Token = "0x6000834")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D0FFA8", Offset = "0x1D0FFA8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateNull", ReturnType = typeof(JValue))]
		internal void AddValue(JValue value, JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00003692 File Offset: 0x00001892
		[global::Cpp2ILInjected.Token(Token = "0x6000835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1002C", Offset = "0x1D1002C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public override void WriteValue(object value)
		{
			throw null;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00003695 File Offset: 0x00001895
		[global::Cpp2ILInjected.Token(Token = "0x6000836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10034", Offset = "0x1D10034", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteNull()
		{
			throw null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00003698 File Offset: 0x00001898
		[global::Cpp2ILInjected.Token(Token = "0x6000837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10054", Offset = "0x1D10054", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteUndefined()
		{
			throw null;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000369B File Offset: 0x0000189B
		[global::Cpp2ILInjected.Token(Token = "0x6000838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10074", Offset = "0x1D10074", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteRaw(string json)
		{
			throw null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000369E File Offset: 0x0000189E
		[global::Cpp2ILInjected.Token(Token = "0x6000839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D100F4", Offset = "0x1D100F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "CreateComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JValue))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000036A1 File Offset: 0x000018A1
		[global::Cpp2ILInjected.Token(Token = "0x600083A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1012C", Offset = "0x1D1012C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000036A4 File Offset: 0x000018A4
		[global::Cpp2ILInjected.Token(Token = "0x600083B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1015C", Offset = "0x1D1015C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(int value)
		{
			throw null;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000036A7 File Offset: 0x000018A7
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600083C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D101D8", Offset = "0x1D101D8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(uint value)
		{
			throw null;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000036AA File Offset: 0x000018AA
		[global::Cpp2ILInjected.Token(Token = "0x600083D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10254", Offset = "0x1D10254", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(long value)
		{
			throw null;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000036AD File Offset: 0x000018AD
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600083E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D102D0", Offset = "0x1D102D0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(ulong value)
		{
			throw null;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000036B0 File Offset: 0x000018B0
		[global::Cpp2ILInjected.Token(Token = "0x600083F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1034C", Offset = "0x1D1034C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(float value)
		{
			throw null;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000036B3 File Offset: 0x000018B3
		[global::Cpp2ILInjected.Token(Token = "0x6000840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D103C8", Offset = "0x1D103C8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(double value)
		{
			throw null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000036B6 File Offset: 0x000018B6
		[global::Cpp2ILInjected.Token(Token = "0x6000841")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10444", Offset = "0x1D10444", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(bool value)
		{
			throw null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000036B9 File Offset: 0x000018B9
		[global::Cpp2ILInjected.Token(Token = "0x6000842")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D104C0", Offset = "0x1D104C0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(short value)
		{
			throw null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000036BC File Offset: 0x000018BC
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000843")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1053C", Offset = "0x1D1053C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(ushort value)
		{
			throw null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000036BF File Offset: 0x000018BF
		[global::Cpp2ILInjected.Token(Token = "0x6000844")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D105B8", Offset = "0x1D105B8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(char value)
		{
			throw null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000036C2 File Offset: 0x000018C2
		[global::Cpp2ILInjected.Token(Token = "0x6000845")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10650", Offset = "0x1D10650", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(byte value)
		{
			throw null;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000036C5 File Offset: 0x000018C5
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000846")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D106CC", Offset = "0x1D106CC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000036C8 File Offset: 0x000018C8
		[global::Cpp2ILInjected.Token(Token = "0x6000847")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10748", Offset = "0x1D10748", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(decimal value)
		{
			throw null;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000036CB File Offset: 0x000018CB
		[global::Cpp2ILInjected.Token(Token = "0x6000848")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D107FC", Offset = "0x1D107FC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000036CE File Offset: 0x000018CE
		[global::Cpp2ILInjected.Token(Token = "0x6000849")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D108B4", Offset = "0x1D108B4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000036D1 File Offset: 0x000018D1
		[global::Cpp2ILInjected.Token(Token = "0x600084A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10940", Offset = "0x1D10940", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteValue(byte[] value)
		{
			throw null;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000036D4 File Offset: 0x000018D4
		[global::Cpp2ILInjected.Token(Token = "0x600084B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10970", Offset = "0x1D10970", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000036D7 File Offset: 0x000018D7
		[global::Cpp2ILInjected.Token(Token = "0x600084C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D109EC", Offset = "0x1D109EC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(Guid value)
		{
			throw null;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000036DA File Offset: 0x000018DA
		[global::Cpp2ILInjected.Token(Token = "0x600084D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10A78", Offset = "0x1D10A78", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonToken)
		}, ReturnType = typeof(void))]
		public override void WriteValue(Uri value)
		{
			throw null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000036DD File Offset: 0x000018DD
		[global::Cpp2ILInjected.Token(Token = "0x600084E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D10AA8", Offset = "0x1D10AA8", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			throw null;
		}

		// Token: 0x0400029A RID: 666
		[global::Cpp2ILInjected.Token(Token = "0x4000338")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private JContainer _token;

		// Token: 0x0400029B RID: 667
		[global::Cpp2ILInjected.Token(Token = "0x4000339")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private JContainer _parent;

		// Token: 0x0400029C RID: 668
		[global::Cpp2ILInjected.Token(Token = "0x400033A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private JValue _value;

		// Token: 0x0400029D RID: 669
		[global::Cpp2ILInjected.Token(Token = "0x400033B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private JToken _current;
	}
}
