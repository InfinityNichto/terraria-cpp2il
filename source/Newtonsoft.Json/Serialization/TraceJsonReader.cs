using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000066 RID: 102
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007F")]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00002CD2 File Offset: 0x00000ED2
		[global::Cpp2ILInjected.Token(Token = "0x6000469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0300", Offset = "0x1CE0300", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TraceJsonReader(JsonReader innerReader)
		{
			throw null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002CD5 File Offset: 0x00000ED5
		[global::Cpp2ILInjected.Token(Token = "0x600046A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0438", Offset = "0x1CE0438", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetDeserializedJsonMessage()
		{
			throw null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002CD8 File Offset: 0x00000ED8
		[global::Cpp2ILInjected.Token(Token = "0x600046B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0448", Offset = "0x1CE0448", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Read()
		{
			throw null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002CDB File Offset: 0x00000EDB
		[global::Cpp2ILInjected.Token(Token = "0x600046C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0494", Offset = "0x1CE0494", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int? ReadAsInt32()
		{
			throw null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002CDE File Offset: 0x00000EDE
		[global::Cpp2ILInjected.Token(Token = "0x600046D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE04E4", Offset = "0x1CE04E4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ReadAsString()
		{
			throw null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002CE1 File Offset: 0x00000EE1
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0534", Offset = "0x1CE0534", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override byte[] ReadAsBytes()
		{
			throw null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0584", Offset = "0x1CE0584", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override decimal? ReadAsDecimal()
		{
			throw null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002CE7 File Offset: 0x00000EE7
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0610", Offset = "0x1CE0610", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override double? ReadAsDouble()
		{
			throw null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002CEA File Offset: 0x00000EEA
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0670", Offset = "0x1CE0670", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool? ReadAsBoolean()
		{
			throw null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002CED File Offset: 0x00000EED
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE06C0", Offset = "0x1CE06C0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override DateTime? ReadAsDateTime()
		{
			throw null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0720", Offset = "0x1CE0720", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			throw null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00002CF3 File Offset: 0x00000EF3
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public override int Depth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000474")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE078C", Offset = "0x1CE078C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00002CF6 File Offset: 0x00000EF6
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public override string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000475")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE079C", Offset = "0x1CE079C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00002CF9 File Offset: 0x00000EF9
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00002CFC File Offset: 0x00000EFC
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		public override char QuoteChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000476")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE07AC", Offset = "0x1CE07AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000477")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE07BC", Offset = "0x1CE07BC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			protected internal set
			{
				throw null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00002CFF File Offset: 0x00000EFF
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public override JsonToken TokenType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000478")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE07CC", Offset = "0x1CE07CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00002D02 File Offset: 0x00000F02
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public override object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000479")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE07DC", Offset = "0x1CE07DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00002D05 File Offset: 0x00000F05
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE07EC", Offset = "0x1CE07EC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002D08 File Offset: 0x00000F08
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE07FC", Offset = "0x1CE07FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002D0B File Offset: 0x00000F0B
		[global::Cpp2ILInjected.Token(Token = "0x600047C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0810", Offset = "0x1CE0810", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			throw null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002D0E File Offset: 0x00000F0E
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		private int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE08C4", Offset = "0x1CE08C4", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00002D11 File Offset: 0x00000F11
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		private int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600047E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE097C", Offset = "0x1CE097C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;
	}
}
