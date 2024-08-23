using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000D9 RID: 217
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000120")]
	public class BsonReader : JsonReader
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00003D8B File Offset: 0x00001F8B
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00003D8E File Offset: 0x00001F8E
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700022D")]
		public bool JsonNet35BinaryCompatibility
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D38680", Offset = "0x1D38680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D38688", Offset = "0x1D38688", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00003D91 File Offset: 0x00001F91
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00003D94 File Offset: 0x00001F94
		[global::Cpp2ILInjected.Token(Token = "0x1700022E")]
		public bool ReadRootValueAsArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D38694", Offset = "0x1D38694", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3869C", Offset = "0x1D3869C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00003D97 File Offset: 0x00001F97
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00003D9A File Offset: 0x00001F9A
		[global::Cpp2ILInjected.Token(Token = "0x1700022F")]
		public DateTimeKind DateTimeKindHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D386A8", Offset = "0x1D386A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D386B0", Offset = "0x1D386B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00003D9D File Offset: 0x00001F9D
		[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D386B8", Offset = "0x1D386B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "Load", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public BsonReader(Stream stream)
		{
			throw null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[global::Cpp2ILInjected.Token(Token = "0x6000B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D387BC", Offset = "0x1D387BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BsonReader(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00003DA3 File Offset: 0x00001FA3
		[global::Cpp2ILInjected.Token(Token = "0x6000B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D386C4", Offset = "0x1D386C4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			throw null;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00003DA6 File Offset: 0x00001FA6
		[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D387C8", Offset = "0x1D387C8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
			throw null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00003DA9 File Offset: 0x00001FA9
		[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D38894", Offset = "0x1D38894", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadString", ReturnType = typeof(string))]
		private string ReadElement()
		{
			throw null;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00003DAC File Offset: 0x00001FAC
		[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D38B20", Offset = "0x1D38B20", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadReference", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override bool Read()
		{
			throw null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00003DAF File Offset: 0x00001FAF
		[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D392CC", Offset = "0x1D392CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00003DB2 File Offset: 0x00001FB2
		[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D390BC", Offset = "0x1D390BC", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadLengthString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "PushContext", MemberParameters = new object[] { typeof(BsonReader.ContainerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool ReadCodeWScope()
		{
			throw null;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00003DB5 File Offset: 0x00001FB5
		[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D38EE4", Offset = "0x1D38EE4", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadLengthString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool ReadReference()
		{
			throw null;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00003DB8 File Offset: 0x00001FB8
		[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D38CC8", Offset = "0x1D38CC8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "PushContext", MemberParameters = new object[] { typeof(BsonReader.ContainerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "PopContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool ReadNormal()
		{
			throw null;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00003DBB File Offset: 0x00001FBB
		[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39A88", Offset = "0x1D39A88", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PopContext()
		{
			throw null;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00003DBE File Offset: 0x00001FBE
		[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D393BC", Offset = "0x1D393BC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PushContext(BsonReader.ContainerContext newContext)
		{
			throw null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00003DC1 File Offset: 0x00001FC1
		[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39A68", Offset = "0x1D39A68", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private byte ReadByte()
		{
			throw null;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39484", Offset = "0x1D39484", Length = "0x5E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadLengthString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "PushContext", MemberParameters = new object[] { typeof(BsonReader.ContainerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "ReadBinary", MemberParameters = new object[] { typeof(ref BsonBinaryType) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeKind)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void ReadType(BsonType type)
		{
			throw null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00003DC7 File Offset: 0x00001FC7
		[global::Cpp2ILInjected.Token(Token = "0x6000B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39B58", Offset = "0x1D39B58", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			throw null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00003DCA File Offset: 0x00001FCA
		[global::Cpp2ILInjected.Token(Token = "0x6000B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D388EC", Offset = "0x1D388EC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadElement", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "EnsureBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "GetLastFullCharStop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string ReadString()
		{
			throw null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00003DCD File Offset: 0x00001FCD
		[global::Cpp2ILInjected.Token(Token = "0x6000B56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39328", Offset = "0x1D39328", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadReference", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "GetString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		private string ReadLengthString()
		{
			throw null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[global::Cpp2ILInjected.Token(Token = "0x6000B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39D5C", Offset = "0x1D39D5C", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadLengthString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "EnsureBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "GetLastFullCharStop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndOfStreamException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private string GetString(int length)
		{
			throw null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00003DD3 File Offset: 0x00001FD3
		[global::Cpp2ILInjected.Token(Token = "0x6000B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39CF0", Offset = "0x1D39CF0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "GetString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonReader), Member = "BytesInSequence", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
		private int GetLastFullCharStop(int start)
		{
			throw null;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00003DD6 File Offset: 0x00001FD6
		[global::Cpp2ILInjected.Token(Token = "0x6000B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39FB4", Offset = "0x1D39FB4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "GetLastFullCharStop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private int BytesInSequence(byte b)
		{
			throw null;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00003DD9 File Offset: 0x00001FD9
		[global::Cpp2ILInjected.Token(Token = "0x6000B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39C4C", Offset = "0x1D39C4C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "GetString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void EnsureBuffers()
		{
			throw null;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00003DDC File Offset: 0x00001FDC
		[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39B34", Offset = "0x1D39B34", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private double ReadDouble()
		{
			throw null;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00003DDF File Offset: 0x00001FDF
		[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39304", Offset = "0x1D39304", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int ReadInt32()
		{
			throw null;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00003DE2 File Offset: 0x00001FE2
		[global::Cpp2ILInjected.Token(Token = "0x6000B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39C28", Offset = "0x1D39C28", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private long ReadInt64()
		{
			throw null;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00003DE5 File Offset: 0x00001FE5
		[global::Cpp2ILInjected.Token(Token = "0x6000B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D388CC", Offset = "0x1D388CC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private BsonType ReadType()
		{
			throw null;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00003DE8 File Offset: 0x00001FE8
		[global::Cpp2ILInjected.Token(Token = "0x6000B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39B20", Offset = "0x1D39B20", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MovePosition(int count)
		{
			throw null;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00003DEB File Offset: 0x00001FEB
		[global::Cpp2ILInjected.Token(Token = "0x6000B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D39460", Offset = "0x1D39460", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private byte[] ReadBytes(int count)
		{
			throw null;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00003DEE File Offset: 0x00001FEE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A118", Offset = "0x1D3A118", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static BsonReader()
		{
			throw null;
		}

		// Token: 0x04000316 RID: 790
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		private const int MaxCharBytesSize = 128;

		// Token: 0x04000317 RID: 791
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		private static readonly byte[] SeqRange1;

		// Token: 0x04000318 RID: 792
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		private static readonly byte[] SeqRange2;

		// Token: 0x04000319 RID: 793
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		private static readonly byte[] SeqRange3;

		// Token: 0x0400031A RID: 794
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		private static readonly byte[] SeqRange4;

		// Token: 0x0400031B RID: 795
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly BinaryReader _reader;

		// Token: 0x0400031C RID: 796
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x0400031D RID: 797
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private byte[] _byteBuffer;

		// Token: 0x0400031E RID: 798
		[global::Cpp2ILInjected.Token(Token = "0x4000438")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private char[] _charBuffer;

		// Token: 0x0400031F RID: 799
		[global::Cpp2ILInjected.Token(Token = "0x4000439")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private BsonType _currentElementType;

		// Token: 0x04000320 RID: 800
		[global::Cpp2ILInjected.Token(Token = "0x400043A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x04000321 RID: 801
		[global::Cpp2ILInjected.Token(Token = "0x400043B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x04000322 RID: 802
		[global::Cpp2ILInjected.Token(Token = "0x400043C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool _readRootValueAsArray;

		// Token: 0x04000323 RID: 803
		[global::Cpp2ILInjected.Token(Token = "0x400043D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x04000324 RID: 804
		[global::Cpp2ILInjected.Token(Token = "0x400043E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x02000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x2000121")]
		private enum BsonReaderState
		{
			// Token: 0x04000478 RID: 1144
			[global::Cpp2ILInjected.Token(Token = "0x4000440")]
			Normal,
			// Token: 0x04000479 RID: 1145
			[global::Cpp2ILInjected.Token(Token = "0x4000441")]
			ReferenceStart,
			// Token: 0x0400047A RID: 1146
			[global::Cpp2ILInjected.Token(Token = "0x4000442")]
			ReferenceRef,
			// Token: 0x0400047B RID: 1147
			[global::Cpp2ILInjected.Token(Token = "0x4000443")]
			ReferenceId,
			// Token: 0x0400047C RID: 1148
			[global::Cpp2ILInjected.Token(Token = "0x4000444")]
			CodeWScopeStart,
			// Token: 0x0400047D RID: 1149
			[global::Cpp2ILInjected.Token(Token = "0x4000445")]
			CodeWScopeCode,
			// Token: 0x0400047E RID: 1150
			[global::Cpp2ILInjected.Token(Token = "0x4000446")]
			CodeWScopeScope,
			// Token: 0x0400047F RID: 1151
			[global::Cpp2ILInjected.Token(Token = "0x4000447")]
			CodeWScopeScopeObject,
			// Token: 0x04000480 RID: 1152
			[global::Cpp2ILInjected.Token(Token = "0x4000448")]
			CodeWScopeScopeEnd
		}

		// Token: 0x02000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x2000122")]
		private class ContainerContext
		{
			// Token: 0x06000BB5 RID: 2997 RVA: 0x0000429B File Offset: 0x0000249B
			[global::Cpp2ILInjected.Token(Token = "0x6000B62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D39394", Offset = "0x1D39394", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ContainerContext(BsonType type)
			{
				throw null;
			}

			// Token: 0x04000481 RID: 1153
			[global::Cpp2ILInjected.Token(Token = "0x4000449")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly BsonType Type;

			// Token: 0x04000482 RID: 1154
			[global::Cpp2ILInjected.Token(Token = "0x400044A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int Length;

			// Token: 0x04000483 RID: 1155
			[global::Cpp2ILInjected.Token(Token = "0x400044B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int Position;
		}
	}
}
