using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002D RID: 45
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200002E")]
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002489 File Offset: 0x00000689
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000248C File Offset: 0x0000068C
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public int LineNumber
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600014B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1C90", Offset = "0x1CC1C90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1C98", Offset = "0x1CC1C98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000248F File Offset: 0x0000068F
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002492 File Offset: 0x00000692
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public int LinePosition
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1CA0", Offset = "0x1CC1CA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1CA8", Offset = "0x1CC1CA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002495 File Offset: 0x00000695
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002498 File Offset: 0x00000698
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public string Path
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1CB0", Offset = "0x1CC1CB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1CB8", Offset = "0x1CC1CB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000249B File Offset: 0x0000069B
		[global::Cpp2ILInjected.Token(Token = "0x6000151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1CC0", Offset = "0x1CC1CC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", ReturnType = typeof(void))]
		public JsonReaderException()
		{
			throw null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000249E File Offset: 0x0000069E
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1CC4", Offset = "0x1CC1CC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public JsonReaderException(string message)
		{
			throw null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000024A1 File Offset: 0x000006A1
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1CC8", Offset = "0x1CC1CC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public JsonReaderException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000024A4 File Offset: 0x000006A4
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1CCC", Offset = "0x1CC1CCC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000024A7 File Offset: 0x000006A7
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1CD0", Offset = "0x1CC1CD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
			throw null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000024AA File Offset: 0x000006AA
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBA4AC", Offset = "0x1CBA4AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonReaderException))]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000024AD File Offset: 0x000006AD
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBF284", Offset = "0x1CBF284", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "CreateUnexpectedCharacterException", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000024B0 File Offset: 0x000006B0
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC1D08", Offset = "0x1CC1D08", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x040000C5 RID: 197
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int <LineNumber>k__BackingField;

		// Token: 0x040000C6 RID: 198
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int <LinePosition>k__BackingField;

		// Token: 0x040000C7 RID: 199
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string <Path>k__BackingField;
	}
}
