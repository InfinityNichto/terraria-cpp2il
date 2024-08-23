using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000D5 RID: 213
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	[global::System.Serializable]
	public readonly struct TimeSpan : global::System.IComparable, global::System.IComparable<global::System.TimeSpan>, global::System.IEquatable<global::System.TimeSpan>, global::System.IFormattable, global::System.ISpanFormattable
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00015F65 File Offset: 0x00014165
		[global::Cpp2ILInjected.Token(Token = "0x60009A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B5D4", Offset = "0x1C4B5D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public TimeSpan(long ticks)
		{
			throw null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00015F68 File Offset: 0x00014168
		[global::Cpp2ILInjected.Token(Token = "0x60009A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B5DC", Offset = "0x1C4B5DC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TimeSpan(int hours, int minutes, int seconds)
		{
			throw null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00015F6B File Offset: 0x0001416B
		[global::Cpp2ILInjected.Token(Token = "0x60009A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B6F4", Offset = "0x1C4B6F4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "initialiseCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Timeout), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(global::System.Threading.WaitHandle),
			typeof(global::System.Threading.WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(global::System.Threading.RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			throw null;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00015F6E File Offset: 0x0001416E
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		public long Ticks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B7B0", Offset = "0x1C4B7B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00015F71 File Offset: 0x00014171
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		public int Days
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B7B8", Offset = "0x1C4B7B8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "PlayerDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "PlayerDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00015F74 File Offset: 0x00014174
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		public int Hours
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B7E4", Offset = "0x1C4B7E4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "PlayerDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "PlayerDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CalculateTransitionOffsetFromBase", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(int),
				typeof(bool),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.Span<char>),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeOffset),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.TimeSpan),
				"Newtonsoft.Json.DateFormatHandling"
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00015F77 File Offset: 0x00014177
		[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
		public int Milliseconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B82C", Offset = "0x1C4B82C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "getDPS", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00015F7A File Offset: 0x0001417A
		[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
		public int Minutes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B878", Offset = "0x1C4B878", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "getDPS", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CalculateTransitionOffsetFromBase", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(int),
				typeof(bool),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.Span<char>),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeOffset),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeOffset", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.TimeSpan),
				"Newtonsoft.Json.DateFormatHandling"
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x00015F7D File Offset: 0x0001417D
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		public int Seconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B8C0", Offset = "0x1C4B8C0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "checkDPSTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "getDPS", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.FrameSkipTest", Member = "CheckReset", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordJoinToServerRequest", Member = "GetUserWrapperText", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00015F80 File Offset: 0x00014180
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		public double TotalDays
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B90C", Offset = "0x1C4B90C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.UmAlQuraCalendar), Member = "ConvertGregorianToHijri", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00015F83 File Offset: 0x00014183
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public double TotalHours
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B924", Offset = "0x1C4B924", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00015F86 File Offset: 0x00014186
		[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
		public double TotalMilliseconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B93C", Offset = "0x1C4B93C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 57)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00015F89 File Offset: 0x00014189
		[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
		public double TotalMinutes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B970", Offset = "0x1C4B970", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTimeOffset),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00015F8C File Offset: 0x0001418C
		[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
		public double TotalSeconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4B988", Offset = "0x1C4B988", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00015F8F File Offset: 0x0001418F
		[global::Cpp2ILInjected.Token(Token = "0x60009B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B9A0", Offset = "0x1C4B9A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public global::System.TimeSpan Add(global::System.TimeSpan ts)
		{
			throw null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00015F92 File Offset: 0x00014192
		[global::Cpp2ILInjected.Token(Token = "0x60009B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BA08", Offset = "0x1C4BA08", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "CheckValueFacets", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			"System.Xml.Schema.XmlSchemaDatatype"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.DurationFacetsChecker", Member = "MatchEnumeration", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static int Compare(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00015F95 File Offset: 0x00014195
		[global::Cpp2ILInjected.Token(Token = "0x60009B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BA20", Offset = "0x1C4BA20", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_duration", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00015F98 File Offset: 0x00014198
		[global::Cpp2ILInjected.Token(Token = "0x60009B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BAE4", Offset = "0x1C4BAE4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int CompareTo(global::System.TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00015F9B File Offset: 0x0001419B
		[global::Cpp2ILInjected.Token(Token = "0x60009B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BB00", Offset = "0x1C4BB00", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePointScheduler.<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection", Member = "StartOperation", MemberParameters = new object[]
		{
			"System.Net.WebOperation",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeSpan FromDays(double value)
		{
			throw null;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00015F9E File Offset: 0x0001419E
		[global::Cpp2ILInjected.Token(Token = "0x60009BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BCA8", Offset = "0x1C4BCA8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00015FA1 File Offset: 0x000141A1
		[global::Cpp2ILInjected.Token(Token = "0x60009BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BD20", Offset = "0x1C4BD20", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(global::System.TimeSpan obj)
		{
			throw null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00015FA4 File Offset: 0x000141A4
		[global::Cpp2ILInjected.Token(Token = "0x60009BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BD30", Offset = "0x1C4BD30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00015FA7 File Offset: 0x000141A7
		[global::Cpp2ILInjected.Token(Token = "0x60009BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BD3C", Offset = "0x1C4BD3C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Interval", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeSpan FromHours(double value)
		{
			throw null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00015FAA File Offset: 0x000141AA
		[global::Cpp2ILInjected.Token(Token = "0x60009BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BB64", Offset = "0x1C4BB64", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "FromHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "FromMinutes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static global::System.TimeSpan Interval(double value, int scale)
		{
			throw null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00015FAD File Offset: 0x000141AD
		[global::Cpp2ILInjected.Token(Token = "0x60009BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BDA0", Offset = "0x1C4BDA0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "WaitForThreadTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.AssetRepository", Member = "ProcessAsyncLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "DoCheckTimeout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_HasTimedOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Interval", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeSpan FromMilliseconds(double value)
		{
			throw null;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00015FB0 File Offset: 0x000141B0
		[global::Cpp2ILInjected.Token(Token = "0x60009C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BE00", Offset = "0x1C4BE00", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Interval", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeSpan FromMinutes(double value)
		{
			throw null;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00015FB3 File Offset: 0x000141B3
		[global::Cpp2ILInjected.Token(Token = "0x60009C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BE60", Offset = "0x1C4BE60", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(bool),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZone", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseTimeZoneOffset", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeOffset),
			"System.Xml.Schema.XsdDateTimeFlags"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.TimeSpan Negate()
		{
			throw null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00015FB6 File Offset: 0x000141B6
		[global::Cpp2ILInjected.Token(Token = "0x60009C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BF14", Offset = "0x1C4BF14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = ".ctor", MemberParameters = new object[]
		{
			"SoundChannel",
			"SoundDefinition",
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundInstance", Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerInitialise", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Audio.SoundEffect", Member = "get_Duration", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ConfigHandler), Member = "ParseTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LifetimeServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Interval", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeSpan FromSeconds(double value)
		{
			throw null;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00015FB9 File Offset: 0x000141B9
		[global::Cpp2ILInjected.Token(Token = "0x60009C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BF74", Offset = "0x1C4BF74", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public global::System.TimeSpan Subtract(global::System.TimeSpan ts)
		{
			throw null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00015FBC File Offset: 0x000141BC
		[global::Cpp2ILInjected.Token(Token = "0x60009C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BFDC", Offset = "0x1C4BFDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "DumpFrameData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Stopwatch", Member = "get_Elapsed", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public static global::System.TimeSpan FromTicks(long value)
		{
			throw null;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00015FBF File Offset: 0x000141BF
		[global::Cpp2ILInjected.Token(Token = "0x60009C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B65C", Offset = "0x1C4B65C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.Calendar), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.GregorianCalendarHelper), Member = "TimeToTicks", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static long TimeToTicks(int hour, int minute, int second)
		{
			throw null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00015FC2 File Offset: 0x000141C2
		[global::Cpp2ILInjected.Token(Token = "0x60009C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4BFE0", Offset = "0x1C4BFE0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DefaultValueAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "ParseTimeSpan", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static global::System.TimeSpan Parse(string s)
		{
			throw null;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00015FC5 File Offset: 0x000141C5
		[global::Cpp2ILInjected.Token(Token = "0x60009C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C03C", Offset = "0x1C4C03C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static global::System.TimeSpan Parse(string input, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00015FC8 File Offset: 0x000141C8
		[global::Cpp2ILInjected.Token(Token = "0x60009C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C09C", Offset = "0x1C4C09C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Globalization.TimeSpanStyles),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryParseExact(string input, string format, global::System.IFormatProvider formatProvider, out global::System.TimeSpan result)
		{
			throw null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00015FCB File Offset: 0x000141CB
		[global::Cpp2ILInjected.Token(Token = "0x60009C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C170", Offset = "0x1C4C170", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00015FCE File Offset: 0x000141CE
		[global::Cpp2ILInjected.Token(Token = "0x60009CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C1D4", Offset = "0x1C4C1D4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerSelectMenu", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "PlayerDraw", MemberParameters = new object[]
		{
			"ItemGrid_Layout",
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00015FD1 File Offset: 0x000141D1
		[global::Cpp2ILInjected.Token(Token = "0x60009CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C244", Offset = "0x1C4C244", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToString(string format, global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00015FD4 File Offset: 0x000141D4
		[global::Cpp2ILInjected.Token(Token = "0x60009CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C2B8", Offset = "0x1C4C2B8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.TimeSpanFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider formatProvider = null)
		{
			throw null;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00015FD7 File Offset: 0x000141D7
		[global::Cpp2ILInjected.Token(Token = "0x60009CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C35C", Offset = "0x1C4C35C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static global::System.TimeSpan operator -(global::System.TimeSpan t)
		{
			throw null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00015FDA File Offset: 0x000141DA
		[global::Cpp2ILInjected.Token(Token = "0x60009CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C408", Offset = "0x1C4C408", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CalculateTransitionOffsetFromBase", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Subtract", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		public static global::System.TimeSpan operator -(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00015FDD File Offset: 0x000141DD
		[global::Cpp2ILInjected.Token(Token = "0x60009CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C420", Offset = "0x1C4C420", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "GetPlayTime", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "UpdatePlayTimerAndKeepState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "StopPlayTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			"System.TimeZoneInfo.CachedData"
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightSavingsEndOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryReadOffset", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(int),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Add", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		public static global::System.TimeSpan operator +(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00015FE0 File Offset: 0x000141E0
		[global::Cpp2ILInjected.Token(Token = "0x60009D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C438", Offset = "0x1C4C438", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.AdjustmentRule) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(bool),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexRunner", Member = "Scan", MemberParameters = new object[]
		{
			"System.Text.RegularExpressions.Regex",
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(global::System.TimeSpan)
		}, ReturnType = "System.Text.RegularExpressions.Match")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static bool operator ==(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00015FE3 File Offset: 0x000141E3
		[global::Cpp2ILInjected.Token(Token = "0x60009D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C444", Offset = "0x1C4C444", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "HasSameRules", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.DateTime),
			typeof(ref global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatR", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "ProcessSponsorResponse", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public static bool operator !=(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00015FE6 File Offset: 0x000141E6
		[global::Cpp2ILInjected.Token(Token = "0x60009D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C450", Offset = "0x1C4C450", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.AssetRepository", Member = "ProcessAsyncLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.LeaseSink), Member = "RenewLease", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static bool operator <(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00015FE9 File Offset: 0x000141E9
		[global::Cpp2ILInjected.Token(Token = "0x60009D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C45C", Offset = "0x1C4C45C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "ValidateMatchTimeout", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator <=(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00015FEC File Offset: 0x000141EC
		[global::Cpp2ILInjected.Token(Token = "0x60009D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C468", Offset = "0x1C4C468", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang", Member = "LocalizedDuration", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "WaitForThreadTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Lifetime.Lease), Member = "UpdateState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public static bool operator >(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00015FEF File Offset: 0x000141EF
		[global::Cpp2ILInjected.Token(Token = "0x60009D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C474", Offset = "0x1C4C474", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityServerUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Game", Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(bool),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool operator >=(global::System.TimeSpan t1, global::System.TimeSpan t2)
		{
			throw null;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00015FF2 File Offset: 0x000141F2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C480", Offset = "0x1C4C480", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static TimeSpan()
		{
			throw null;
		}

		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
		public const long TicksPerMillisecond = 10000L;

		// Token: 0x04000262 RID: 610
		[global::Cpp2ILInjected.Token(Token = "0x40003B4")]
		private const double MillisecondsPerTick = 0.0001;

		// Token: 0x04000263 RID: 611
		[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
		public const long TicksPerSecond = 10000000L;

		// Token: 0x04000264 RID: 612
		[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
		private const double SecondsPerTick = 1E-07;

		// Token: 0x04000265 RID: 613
		[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
		public const long TicksPerMinute = 600000000L;

		// Token: 0x04000266 RID: 614
		[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
		private const double MinutesPerTick = 1.6666666666666667E-09;

		// Token: 0x04000267 RID: 615
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		public const long TicksPerHour = 36000000000L;

		// Token: 0x04000268 RID: 616
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		private const double HoursPerTick = 2.7777777777777777E-11;

		// Token: 0x04000269 RID: 617
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		public const long TicksPerDay = 864000000000L;

		// Token: 0x0400026A RID: 618
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		private const double DaysPerTick = 1.1574074074074074E-12;

		// Token: 0x0400026B RID: 619
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		private const int MillisPerSecond = 1000;

		// Token: 0x0400026C RID: 620
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		private const int MillisPerMinute = 60000;

		// Token: 0x0400026D RID: 621
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		private const int MillisPerHour = 3600000;

		// Token: 0x0400026E RID: 622
		[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
		private const int MillisPerDay = 86400000;

		// Token: 0x0400026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
		internal const long MaxSeconds = 922337203685L;

		// Token: 0x04000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
		internal const long MinSeconds = -922337203685L;

		// Token: 0x04000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
		internal const long MaxMilliSeconds = 922337203685477L;

		// Token: 0x04000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
		internal const long MinMilliSeconds = -922337203685477L;

		// Token: 0x04000273 RID: 627
		[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
		internal const long TicksPerTenthSecond = 1000000L;

		// Token: 0x04000274 RID: 628
		[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
		public static readonly global::System.TimeSpan Zero;

		// Token: 0x04000275 RID: 629
		[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
		public static readonly global::System.TimeSpan MaxValue;

		// Token: 0x04000276 RID: 630
		[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
		public static readonly global::System.TimeSpan MinValue;

		// Token: 0x04000277 RID: 631
		[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly long _ticks;
	}
}
