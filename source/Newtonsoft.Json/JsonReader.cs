using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000030 RID: 48
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000031")]
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000024BF File Offset: 0x000006BF
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		protected JsonReader.State CurrentState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000160")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F60", Offset = "0x1CC1F60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000024C2 File Offset: 0x000006C2
		// (set) Token: 0x06000160 RID: 352 RVA: 0x000024C5 File Offset: 0x000006C5
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public bool CloseInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000161")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F68", Offset = "0x1CC1F68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000162")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F70", Offset = "0x1CC1F70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000024C8 File Offset: 0x000006C8
		// (set) Token: 0x06000162 RID: 354 RVA: 0x000024CB File Offset: 0x000006CB
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public bool SupportMultipleContent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000163")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F7C", Offset = "0x1CC1F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000164")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F84", Offset = "0x1CC1F84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000024CE File Offset: 0x000006CE
		// (set) Token: 0x06000164 RID: 356 RVA: 0x000024D1 File Offset: 0x000006D1
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public virtual char QuoteChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000165")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F90", Offset = "0x1CC1F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000166")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1F98", Offset = "0x1CC1F98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected internal set
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x06000166 RID: 358 RVA: 0x000024D7 File Offset: 0x000006D7
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000167")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1FA0", Offset = "0x1CC1FA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000168")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC1FA8", Offset = "0x1CC1FA8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(ref CultureInfo),
				typeof(ref DateTimeZoneHandling?),
				typeof(ref DateParseHandling?),
				typeof(ref FloatParseHandling?),
				typeof(ref int?),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(CultureInfo),
				typeof(DateTimeZoneHandling?),
				typeof(DateParseHandling?),
				typeof(FloatParseHandling?),
				typeof(int?),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000024DA File Offset: 0x000006DA
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000024DD File Offset: 0x000006DD
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public DateParseHandling DateParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000169")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC2008", Offset = "0x1CC2008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600016A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC2010", Offset = "0x1CC2010", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(ref CultureInfo),
				typeof(ref DateTimeZoneHandling?),
				typeof(ref DateParseHandling?),
				typeof(ref FloatParseHandling?),
				typeof(ref int?),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(CultureInfo),
				typeof(DateTimeZoneHandling?),
				typeof(DateParseHandling?),
				typeof(FloatParseHandling?),
				typeof(int?),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000024E0 File Offset: 0x000006E0
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000024E3 File Offset: 0x000006E3
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public FloatParseHandling FloatParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC2070", Offset = "0x1CC2070", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600016C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC2078", Offset = "0x1CC2078", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(ref CultureInfo),
				typeof(ref DateTimeZoneHandling?),
				typeof(ref DateParseHandling?),
				typeof(ref FloatParseHandling?),
				typeof(ref int?),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(CultureInfo),
				typeof(DateTimeZoneHandling?),
				typeof(DateParseHandling?),
				typeof(FloatParseHandling?),
				typeof(int?),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000024E6 File Offset: 0x000006E6
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000024E9 File Offset: 0x000006E9
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public string DateFormatString
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC20D8", Offset = "0x1CC20D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600016E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC20E0", Offset = "0x1CC20E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000024EF File Offset: 0x000006EF
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public int? MaxDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC20E8", Offset = "0x1CC20E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000170")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC20F0", Offset = "0x1CC20F0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(ref CultureInfo),
				typeof(ref DateTimeZoneHandling?),
				typeof(ref DateParseHandling?),
				typeof(ref FloatParseHandling?),
				typeof(ref int?),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ResetReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(CultureInfo),
				typeof(DateTimeZoneHandling?),
				typeof(DateParseHandling?),
				typeof(FloatParseHandling?),
				typeof(int?),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000024F2 File Offset: 0x000006F2
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public virtual JsonToken TokenType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000171")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC21AC", Offset = "0x1CC21AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000024F5 File Offset: 0x000006F5
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public virtual object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000172")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC21B4", Offset = "0x1CC21B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000024F8 File Offset: 0x000006F8
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public virtual Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000173")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC21BC", Offset = "0x1CC21BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000024FB File Offset: 0x000006FB
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public virtual int Depth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000174")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC21D0", Offset = "0x1CC21D0", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000024FE File Offset: 0x000006FE
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public virtual string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000175")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC224C", Offset = "0x1CC224C", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "get_Path", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition?), Member = ".ctor", MemberParameters = new object[] { typeof(JsonPosition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new object[]
			{
				typeof(List<JsonPosition>),
				typeof(JsonPosition?)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002501 File Offset: 0x00000701
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002504 File Offset: 0x00000704
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000176")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB9484", Offset = "0x1CB9484", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new object[]
			{
				typeof(char),
				typeof(ReadType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadInt32String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDoubleString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDecimalString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(ref CultureInfo),
				typeof(ref DateTimeZoneHandling?),
				typeof(ref DateParseHandling?),
				typeof(ref FloatParseHandling?),
				typeof(ref int?),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
			{
				typeof(IDictionary),
				typeof(JsonReader),
				typeof(JsonDictionaryContract),
				typeof(JsonProperty),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CC236C", Offset = "0x1CC236C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002507 File Offset: 0x00000707
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2374", Offset = "0x1CC2374", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal JsonPosition GetPosition(int depth)
		{
			throw null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000250A File Offset: 0x0000070A
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB8954", Offset = "0x1CB8954", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = ".ctor", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected JsonReader()
		{
			throw null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000250D File Offset: 0x0000070D
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2418", Offset = "0x1CC2418", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = ".ctor", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void Push(JsonContainerType value)
		{
			throw null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002510 File Offset: 0x00000710
		[global::Cpp2ILInjected.Token(Token = "0x600017B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2698", Offset = "0x1CC2698", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ValidateEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private JsonContainerType Pop()
		{
			throw null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002513 File Offset: 0x00000713
		[global::Cpp2ILInjected.Token(Token = "0x600017C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC27AC", Offset = "0x1CC27AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private JsonContainerType Peek()
		{
			throw null;
		}

		// Token: 0x0600017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		public abstract bool Read();

		// Token: 0x0600017C RID: 380 RVA: 0x00002516 File Offset: 0x00000716
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC27B4", Offset = "0x1CC27B4", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadInt32String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual int? ReadAsInt32()
		{
			throw null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002519 File Offset: 0x00000719
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBDD1C", Offset = "0x1CBDD1C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsInt32", ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal int? ReadInt32String(string s)
		{
			throw null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000251C File Offset: 0x0000071C
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2AFC", Offset = "0x1CC2AFC", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTokenUtils), Member = "IsPrimitiveToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual string ReadAsString()
		{
			throw null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000251F File Offset: 0x0000071F
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2E58", Offset = "0x1CC2E58", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "TryConvertGuid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public virtual byte[] ReadAsBytes()
		{
			throw null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002522 File Offset: 0x00000722
		[global::Cpp2ILInjected.Token(Token = "0x6000182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBB864", Offset = "0x1CBB864", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = "ToArray", ReturnType = "T[]")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal byte[] ReadArrayIntoByteArray()
		{
			throw null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002525 File Offset: 0x00000725
		[global::Cpp2ILInjected.Token(Token = "0x6000183")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC3248", Offset = "0x1CC3248", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double?), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadDoubleString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double?))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual double? ReadAsDouble()
		{
			throw null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002528 File Offset: 0x00000728
		[global::Cpp2ILInjected.Token(Token = "0x6000184")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBE130", Offset = "0x1CBE130", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDouble", ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double?), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal double? ReadDoubleString(string s)
		{
			throw null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000252B File Offset: 0x0000072B
		[global::Cpp2ILInjected.Token(Token = "0x6000185")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC350C", Offset = "0x1CC350C", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadBooleanString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual bool? ReadAsBoolean()
		{
			throw null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000252E File Offset: 0x0000072E
		[global::Cpp2ILInjected.Token(Token = "0x6000186")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBDA44", Offset = "0x1CBDA44", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBoolean", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal bool? ReadBooleanString(string s)
		{
			throw null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002531 File Offset: 0x00000731
		[global::Cpp2ILInjected.Token(Token = "0x6000187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC37C0", Offset = "0x1CC37C0", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal?), Member = ".ctor", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadDecimalString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(decimal?))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual decimal? ReadAsDecimal()
		{
			throw null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002534 File Offset: 0x00000734
		[global::Cpp2ILInjected.Token(Token = "0x6000188")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBDF04", Offset = "0x1CBDF04", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDecimal", ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal?), Member = ".ctor", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal decimal? ReadDecimalString(string s)
		{
			throw null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002537 File Offset: 0x00000737
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC3AC8", Offset = "0x1CC3AC8", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadDateTimeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_DateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual DateTime? ReadAsDateTime()
		{
			throw null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000253A File Offset: 0x0000073A
		[global::Cpp2ILInjected.Token(Token = "0x600018A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBBE60", Offset = "0x1CBBE60", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTime", ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal DateTime? ReadDateTimeString(string s)
		{
			throw null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000253D File Offset: 0x0000073D
		[global::Cpp2ILInjected.Token(Token = "0x600018B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC3D7C", Offset = "0x1CC3D7C", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetContentToken", ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadDateTimeOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			throw null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002540 File Offset: 0x00000740
		[global::Cpp2ILInjected.Token(Token = "0x600018C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBC0E8", Offset = "0x1CBC0E8", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTimeOffset", ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002543 File Offset: 0x00000743
		[global::Cpp2ILInjected.Token(Token = "0x600018D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBB67C", Offset = "0x1CBB67C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadIntoWrappedTypeObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "CreateUnexpectedEndException", ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void ReaderReadAndAssert()
		{
			throw null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002546 File Offset: 0x00000746
		[global::Cpp2ILInjected.Token(Token = "0x600018E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBE604", Offset = "0x1CBE604", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "HandleNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "MatchValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			throw null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002549 File Offset: 0x00000749
		[global::Cpp2ILInjected.Token(Token = "0x600018F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBB6C0", Offset = "0x1CBB6C0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReaderReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void ReadIntoWrappedTypeObject()
		{
			throw null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000254C File Offset: 0x0000074C
		[global::Cpp2ILInjected.Token(Token = "0x6000190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC403C", Offset = "0x1CC403C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CheckPropertyName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "ReadRegexObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonSerializer)
		}, ReturnType = typeof(Regex))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTokenUtils), Member = "IsStartToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(bool))]
		public void Skip()
		{
			throw null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000254F File Offset: 0x0000074F
		[global::Cpp2ILInjected.Token(Token = "0x6000191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBA25C", Offset = "0x1CBA25C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadOver", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "ReadToEnd", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetEnd", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadReference", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected void SetToken(JsonToken newToken)
		{
			throw null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002552 File Offset: 0x00000752
		[global::Cpp2ILInjected.Token(Token = "0x6000192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBD2B4", Offset = "0x1CBD2B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadCodeWScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadReference", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadNormal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "ReadType", MemberParameters = new object[] { typeof(BsonType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected void SetToken(JsonToken newToken, object value)
		{
			throw null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002555 File Offset: 0x00000755
		[global::Cpp2ILInjected.Token(Token = "0x6000193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB932C", Offset = "0x1CB932C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Push", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ValidateEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
			throw null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002558 File Offset: 0x00000758
		[global::Cpp2ILInjected.Token(Token = "0x6000194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB92EC", Offset = "0x1CB92EC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetPostValueState(bool updateIndex)
		{
			throw null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000255B File Offset: 0x0000075B
		[global::Cpp2ILInjected.Token(Token = "0x6000195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2680", Offset = "0x1CC2680", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void UpdateScopeWithFinishedValue()
		{
			throw null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000255E File Offset: 0x0000075E
		[global::Cpp2ILInjected.Token(Token = "0x6000196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC40D4", Offset = "0x1CC40D4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "SetToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Pop", ReturnType = typeof(JsonContainerType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetTypeForCloseToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(JsonContainerType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReaderException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonReaderException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ValidateEnd(JsonToken endToken)
		{
			throw null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002561 File Offset: 0x00000761
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBDC2C", Offset = "0x1CBDC2C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ProcessValueComma", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParsePostValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected void SetStateBasedOnCurrent()
		{
			throw null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002564 File Offset: 0x00000764
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC41D4", Offset = "0x1CC41D4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetFinished()
		{
			throw null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002567 File Offset: 0x00000767
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC41EC", Offset = "0x1CC41EC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ValidateEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000256A File Offset: 0x0000076A
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4294", Offset = "0x1CC4294", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000256D File Offset: 0x0000076D
		[global::Cpp2ILInjected.Token(Token = "0x600019B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4304", Offset = "0x1CC4304", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002570 File Offset: 0x00000770
		[global::Cpp2ILInjected.Token(Token = "0x600019C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CBF5E8", Offset = "0x1CBF5E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonReader), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002573 File Offset: 0x00000773
		[global::Cpp2ILInjected.Token(Token = "0x600019D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4328", Offset = "0x1CC4328", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void ReadAndAssert()
		{
			throw null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002576 File Offset: 0x00000776
		[global::Cpp2ILInjected.Token(Token = "0x600019E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC4384", Offset = "0x1CC4384", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal bool ReadAndMoveToContent()
		{
			throw null;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002579 File Offset: 0x00000779
		[global::Cpp2ILInjected.Token(Token = "0x600019F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC43B4", Offset = "0x1CC43B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JConstructor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JProperty), Member = "Load", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonLoadSettings)
		}, ReturnType = typeof(JProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		internal bool MoveToContent()
		{
			throw null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000257C File Offset: 0x0000077C
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC2A88", Offset = "0x1CC2A88", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsInt32", ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadArrayIntoByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDouble", ReturnType = typeof(double?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBoolean", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDecimal", ReturnType = typeof(decimal?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTime", ReturnType = typeof(DateTime?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsDateTimeOffset", ReturnType = typeof(DateTimeOffset?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private JsonToken GetContentToken()
		{
			throw null;
		}

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _value;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal JsonReader.State _currentState;

		// Token: 0x040000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		// Token: 0x040000CD RID: 205
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private CultureInfo _culture;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _dateFormatString;

		// Token: 0x040000D4 RID: 212
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private List<JsonPosition> _stack;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool <CloseInput>k__BackingField;

		// Token: 0x040000D6 RID: 214
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool <SupportMultipleContent>k__BackingField;

		// Token: 0x020000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x2000032")]
		protected internal enum State
		{
			// Token: 0x04000366 RID: 870
			[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
			Start,
			// Token: 0x04000367 RID: 871
			[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
			Complete,
			// Token: 0x04000368 RID: 872
			[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
			Property,
			// Token: 0x04000369 RID: 873
			[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
			ObjectStart,
			// Token: 0x0400036A RID: 874
			[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
			Object,
			// Token: 0x0400036B RID: 875
			[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
			ArrayStart,
			// Token: 0x0400036C RID: 876
			[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
			Array,
			// Token: 0x0400036D RID: 877
			[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
			Closed,
			// Token: 0x0400036E RID: 878
			[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
			PostValue,
			// Token: 0x0400036F RID: 879
			[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
			ConstructorStart,
			// Token: 0x04000370 RID: 880
			[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
			Constructor,
			// Token: 0x04000371 RID: 881
			[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
			Error,
			// Token: 0x04000372 RID: 882
			[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
			Finished
		}
	}
}
