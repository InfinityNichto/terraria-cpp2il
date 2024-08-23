using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000E3 RID: 227
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012C")]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00003E60 File Offset: 0x00002060
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00003E63 File Offset: 0x00002063
		[global::Cpp2ILInjected.Token(Token = "0x1700023F")]
		public DateTimeKind DateTimeKindHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A6C4", Offset = "0x1D3A6C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A6D0", Offset = "0x1D3A6D0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00003E66 File Offset: 0x00002066
		[global::Cpp2ILInjected.Token(Token = "0x6000B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A6DC", Offset = "0x1D3A6DC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Save", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Save", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public BsonWriter(Stream stream)
		{
			throw null;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00003E69 File Offset: 0x00002069
		[global::Cpp2ILInjected.Token(Token = "0x6000B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A7CC", Offset = "0x1D3A7CC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public BsonWriter(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00003E6C File Offset: 0x0000206C
		[global::Cpp2ILInjected.Token(Token = "0x6000B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A890", Offset = "0x1D3A890", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00003E6F File Offset: 0x0000206F
		[global::Cpp2ILInjected.Token(Token = "0x6000B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A8A4", Offset = "0x1D3A8A4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		protected override void WriteEnd(JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00003E72 File Offset: 0x00002072
		[global::Cpp2ILInjected.Token(Token = "0x6000B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A914", Offset = "0x1D3A914", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00003E75 File Offset: 0x00002075
		[global::Cpp2ILInjected.Token(Token = "0x6000B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A958", Offset = "0x1D3A958", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteStartConstructor(string name)
		{
			throw null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00003E78 File Offset: 0x00002078
		[global::Cpp2ILInjected.Token(Token = "0x6000B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A99C", Offset = "0x1D3A99C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteRaw(string json)
		{
			throw null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00003E7B File Offset: 0x0000207B
		[global::Cpp2ILInjected.Token(Token = "0x6000B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A9E0", Offset = "0x1D3A9E0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteRawValue(string json)
		{
			throw null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00003E7E File Offset: 0x0000207E
		[global::Cpp2ILInjected.Token(Token = "0x6000B93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AA24", Offset = "0x1D3AA24", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonArray), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartArray()
		{
			throw null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00003E81 File Offset: 0x00002081
		[global::Cpp2ILInjected.Token(Token = "0x6000B94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AAB4", Offset = "0x1D3AAB4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteStartObject()
		{
			throw null;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00003E84 File Offset: 0x00002084
		[global::Cpp2ILInjected.Token(Token = "0x6000B95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AB20", Offset = "0x1D3AB20", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00003E87 File Offset: 0x00002087
		[global::Cpp2ILInjected.Token(Token = "0x6000B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AB48", Offset = "0x1D3AB48", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00003E8A File Offset: 0x0000208A
		[global::Cpp2ILInjected.Token(Token = "0x6000B97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AA90", Offset = "0x1D3AA90", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		private void AddParent(BsonToken container)
		{
			throw null;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00003E8D File Offset: 0x0000208D
		[global::Cpp2ILInjected.Token(Token = "0x6000B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A904", Offset = "0x1D3A904", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RemoveParent()
		{
			throw null;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00003E90 File Offset: 0x00002090
		[global::Cpp2ILInjected.Token(Token = "0x6000B99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AD38", Offset = "0x1D3AD38", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteObjectId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddValue(object value, BsonType type)
		{
			throw null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00003E93 File Offset: 0x00002093
		[global::Cpp2ILInjected.Token(Token = "0x6000B9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AB84", Offset = "0x1D3AB84", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "AddParent", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteRegex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonArray), Member = "Add", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObject), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BsonToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void AddToken(BsonToken token)
		{
			throw null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00003E96 File Offset: 0x00002096
		[global::Cpp2ILInjected.Token(Token = "0x6000B9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3ADAC", Offset = "0x1D3ADAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public override void WriteValue(object value)
		{
			throw null;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00003E99 File Offset: 0x00002099
		[global::Cpp2ILInjected.Token(Token = "0x6000B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3ADB4", Offset = "0x1D3ADB4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		public override void WriteNull()
		{
			throw null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00003E9C File Offset: 0x0000209C
		[global::Cpp2ILInjected.Token(Token = "0x6000B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3ADD8", Offset = "0x1D3ADD8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		public override void WriteUndefined()
		{
			throw null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00003E9F File Offset: 0x0000209F
		[global::Cpp2ILInjected.Token(Token = "0x6000B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3ADFC", Offset = "0x1D3ADFC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00003EA2 File Offset: 0x000020A2
		[global::Cpp2ILInjected.Token(Token = "0x6000B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AE9C", Offset = "0x1D3AE9C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(int value)
		{
			throw null;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00003EA5 File Offset: 0x000020A5
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AF18", Offset = "0x1D3AF18", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteValue(uint value)
		{
			throw null;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00003EA8 File Offset: 0x000020A8
		[global::Cpp2ILInjected.Token(Token = "0x6000BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3AFD4", Offset = "0x1D3AFD4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(long value)
		{
			throw null;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00003EAB File Offset: 0x000020AB
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B050", Offset = "0x1D3B050", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteValue(ulong value)
		{
			throw null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00003EAE File Offset: 0x000020AE
		[global::Cpp2ILInjected.Token(Token = "0x6000BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B10C", Offset = "0x1D3B10C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(float value)
		{
			throw null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00003EB1 File Offset: 0x000020B1
		[global::Cpp2ILInjected.Token(Token = "0x6000BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B188", Offset = "0x1D3B188", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(double value)
		{
			throw null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00003EB4 File Offset: 0x000020B4
		[global::Cpp2ILInjected.Token(Token = "0x6000BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B204", Offset = "0x1D3B204", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(bool value)
		{
			throw null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00003EB7 File Offset: 0x000020B7
		[global::Cpp2ILInjected.Token(Token = "0x6000BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B280", Offset = "0x1D3B280", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(short value)
		{
			throw null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00003EBA File Offset: 0x000020BA
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B2FC", Offset = "0x1D3B2FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(ushort value)
		{
			throw null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00003EBD File Offset: 0x000020BD
		[global::Cpp2ILInjected.Token(Token = "0x6000BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B378", Offset = "0x1D3B378", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteValue(char value)
		{
			throw null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00003EC0 File Offset: 0x000020C0
		[global::Cpp2ILInjected.Token(Token = "0x6000BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B450", Offset = "0x1D3B450", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(byte value)
		{
			throw null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00003EC3 File Offset: 0x000020C3
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B4CC", Offset = "0x1D3B4CC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00003EC6 File Offset: 0x000020C6
		[global::Cpp2ILInjected.Token(Token = "0x6000BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B548", Offset = "0x1D3B548", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteValue(decimal value)
		{
			throw null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00003EC9 File Offset: 0x000020C9
		[global::Cpp2ILInjected.Token(Token = "0x6000BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B5FC", Offset = "0x1D3B5FC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00003ECC File Offset: 0x000020CC
		[global::Cpp2ILInjected.Token(Token = "0x6000BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B6B4", Offset = "0x1D3B6B4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00003ECF File Offset: 0x000020CF
		[global::Cpp2ILInjected.Token(Token = "0x6000BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B740", Offset = "0x1D3B740", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00003ED2 File Offset: 0x000020D2
		[global::Cpp2ILInjected.Token(Token = "0x6000BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B7C4", Offset = "0x1D3B7C4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(Guid value)
		{
			throw null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00003ED5 File Offset: 0x000020D5
		[global::Cpp2ILInjected.Token(Token = "0x6000BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B874", Offset = "0x1D3B874", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00003ED8 File Offset: 0x000020D8
		[global::Cpp2ILInjected.Token(Token = "0x6000BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B91C", Offset = "0x1D3B91C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteValue(Uri value)
		{
			throw null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00003EDB File Offset: 0x000020DB
		[global::Cpp2ILInjected.Token(Token = "0x6000BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3B9C0", Offset = "0x1D3B9C0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonObjectIdConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "UpdateScopeWithFinishedValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BsonType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void WriteObjectId(byte[] value)
		{
			throw null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00003EDE File Offset: 0x000020DE
		[global::Cpp2ILInjected.Token(Token = "0x6000BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BA8C", Offset = "0x1D3BA8C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "WriteBson", MemberParameters = new object[]
		{
			typeof(BsonWriter),
			typeof(Regex)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "UpdateScopeWithFinishedValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonRegex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "AddToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void WriteRegex(string pattern, string options)
		{
			throw null;
		}

		// Token: 0x04000347 RID: 839
		[global::Cpp2ILInjected.Token(Token = "0x400046E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private readonly BsonBinaryWriter _writer;

		// Token: 0x04000348 RID: 840
		[global::Cpp2ILInjected.Token(Token = "0x400046F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private BsonToken _root;

		// Token: 0x04000349 RID: 841
		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private BsonToken _parent;

		// Token: 0x0400034A RID: 842
		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private string _propertyName;
	}
}
