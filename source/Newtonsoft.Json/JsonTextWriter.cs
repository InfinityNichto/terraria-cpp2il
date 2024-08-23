using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200002B RID: 43
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200002C")]
	public class JsonTextWriter : JsonWriter
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000023C0 File Offset: 0x000005C0
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		private Base64Encoder Base64Encoder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000108")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFEC0", Offset = "0x1CBFEC0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000023C3 File Offset: 0x000005C3
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000023C6 File Offset: 0x000005C6
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public IArrayPool<char> ArrayPool
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000109")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFF2C", Offset = "0x1CBFF2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600010A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFF34", Offset = "0x1CBFF34", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000023C9 File Offset: 0x000005C9
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000023CC File Offset: 0x000005CC
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public int Indentation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFF90", Offset = "0x1CBFF90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600010C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFF98", Offset = "0x1CBFF98", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000023CF File Offset: 0x000005CF
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000023D2 File Offset: 0x000005D2
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		public char QuoteChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFFF4", Offset = "0x1CBFFF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600010E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CBFFFC", Offset = "0x1CBFFFC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000023D5 File Offset: 0x000005D5
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000023D8 File Offset: 0x000005D8
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public char IndentChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC00D4", Offset = "0x1CC00D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000110")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC00DC", Offset = "0x1CC00DC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000023DB File Offset: 0x000005DB
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000023DE File Offset: 0x000005DE
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public bool QuoteName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000111")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC00F4", Offset = "0x1CC00F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000112")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC00FC", Offset = "0x1CC00FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000023E1 File Offset: 0x000005E1
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0108", Offset = "0x1CC0108", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(JsonSerializer)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JRaw), Member = "Create", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JRaw))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToString", MemberParameters = new object[]
		{
			typeof(Formatting),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public JsonTextWriter(TextWriter textWriter)
		{
			throw null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000023E4 File Offset: 0x000005E4
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC01E4", Offset = "0x1CC01E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000023E7 File Offset: 0x000005E7
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC01F4", Offset = "0x1CC01F4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000023EA File Offset: 0x000005EA
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0244", Offset = "0x1CC0244", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartObject()
		{
			throw null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000023ED File Offset: 0x000005ED
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0278", Offset = "0x1CC0278", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartArray()
		{
			throw null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000023F0 File Offset: 0x000005F0
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC02AC", Offset = "0x1CC02AC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartConstructor(string name)
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000023F3 File Offset: 0x000005F3
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0350", Offset = "0x1CC0350", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void WriteEnd(JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000023F6 File Offset: 0x000005F6
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC043C", Offset = "0x1CC043C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000023F9 File Offset: 0x000005F9
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0558", Offset = "0x1CC0558", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WritePropertyName(string name, bool escape)
		{
			throw null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000023FC File Offset: 0x000005FC
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0608", Offset = "0x1CC0608", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "UpdateCharEscapeFlags", ReturnType = typeof(void))]
		internal override void OnStringEscapeHandlingChanged()
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000023FF File Offset: 0x000005FF
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0068", Offset = "0x1CC0068", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "OnStringEscapeHandlingChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "GetCharEscapeFlags", MemberParameters = new object[]
		{
			typeof(StringEscapeHandling),
			typeof(char)
		}, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UpdateCharEscapeFlags()
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002402 File Offset: 0x00000602
		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC060C", Offset = "0x1CC060C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void WriteIndent()
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002405 File Offset: 0x00000605
		[global::Cpp2ILInjected.Token(Token = "0x600011F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0700", Offset = "0x1CC0700", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void WriteValueDelimiter()
		{
			throw null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002408 File Offset: 0x00000608
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0718", Offset = "0x1CC0718", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void WriteIndentSpace()
		{
			throw null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000240B File Offset: 0x0000060B
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0730", Offset = "0x1CC0730", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteValueInternal(string value, JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000240E File Offset: 0x0000060E
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0744", Offset = "0x1CC0744", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public override void WriteValue(object value)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002411 File Offset: 0x00000611
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC074C", Offset = "0x1CC074C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteNull()
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002414 File Offset: 0x00000614
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC07CC", Offset = "0x1CC07CC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteUndefined()
		{
			throw null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002417 File Offset: 0x00000617
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC084C", Offset = "0x1CC084C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteRaw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(string json)
		{
			throw null;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000241A File Offset: 0x0000061A
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0884", Offset = "0x1CC0884", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000241D File Offset: 0x0000061D
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0484", Offset = "0x1CC0484", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "WriteEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(string),
			typeof(char),
			typeof(bool),
			typeof(bool[]),
			typeof(StringEscapeHandling),
			typeof(IArrayPool<char>),
			typeof(ref char[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void WriteEscapedString(string value, bool quote)
		{
			throw null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002420 File Offset: 0x00000620
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0950", Offset = "0x1CC0950", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(int value)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002423 File Offset: 0x00000623
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC09EC", Offset = "0x1CC09EC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(uint value)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002426 File Offset: 0x00000626
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0A1C", Offset = "0x1CC0A1C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(long value)
		{
			throw null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002429 File Offset: 0x00000629
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0A4C", Offset = "0x1CC0A4C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public override void WriteValue(ulong value)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000242C File Offset: 0x0000062C
		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0B44", Offset = "0x1CC0B44", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(float),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(float value)
		{
			throw null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000242F File Offset: 0x0000062F
		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0CD4", Offset = "0x1CC0CD4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(float),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteValue(float? value)
		{
			throw null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002432 File Offset: 0x00000632
		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0DBC", Offset = "0x1CC0DBC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(double),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(double value)
		{
			throw null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002435 File Offset: 0x00000635
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0F48", Offset = "0x1CC0F48", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(double),
			typeof(FloatFormatHandling),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteValue(double? value)
		{
			throw null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002438 File Offset: 0x00000638
		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC103C", Offset = "0x1CC103C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(bool value)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000243B File Offset: 0x0000063B
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1134", Offset = "0x1CC1134", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(short value)
		{
			throw null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000243E File Offset: 0x0000063E
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1164", Offset = "0x1CC1164", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(ushort value)
		{
			throw null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002441 File Offset: 0x00000641
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1194", Offset = "0x1CC1194", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(char value)
		{
			throw null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002444 File Offset: 0x00000644
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC12AC", Offset = "0x1CC12AC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(byte value)
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002447 File Offset: 0x00000647
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC12DC", Offset = "0x1CC12DC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		public override void WriteValue(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000244A File Offset: 0x0000064A
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC130C", Offset = "0x1CC130C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(decimal value)
		{
			throw null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000244D File Offset: 0x0000064D
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1468", Offset = "0x1CC1468", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002450 File Offset: 0x00000650
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1624", Offset = "0x1CC1624", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "get_Base64Encoder", ReturnType = typeof(Base64Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002453 File Offset: 0x00000653
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC16C8", Offset = "0x1CC16C8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(DateTime),
			typeof(TimeSpan?),
			typeof(DateTimeKind),
			typeof(DateFormatHandling)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002456 File Offset: 0x00000656
		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1890", Offset = "0x1CC1890", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(Guid value)
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002459 File Offset: 0x00000659
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC197C", Offset = "0x1CC197C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
		public override void WriteValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000245C File Offset: 0x0000065C
		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1A00", Offset = "0x1CC1A00", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteValue", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteEscapedString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(Uri value)
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000245F File Offset: 0x0000065F
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1AB8", Offset = "0x1CC1AB8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002462 File Offset: 0x00000662
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1B68", Offset = "0x1CC1B68", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002465 File Offset: 0x00000665
		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0924", Offset = "0x1CC0924", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		private void EnsureWriteBuffer()
		{
			throw null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002468 File Offset: 0x00000668
		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0980", Offset = "0x1CC0980", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteIntegerValue(long value)
		{
			throw null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000246B File Offset: 0x0000066B
		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC0A7C", Offset = "0x1CC0A7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathUtils), Member = "IntLength", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void WriteIntegerValue(ulong uvalue)
		{
			throw null;
		}

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private readonly TextWriter _writer;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Base64Encoder _base64Encoder;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private char _indentChar;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int _indentation;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private char _quoteChar;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7A")]
		private bool _quoteName;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool[] _charEscapeFlags;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private char[] _writeBuffer;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private IArrayPool<char> _arrayPool;

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private char[] _indentChars;
	}
}
