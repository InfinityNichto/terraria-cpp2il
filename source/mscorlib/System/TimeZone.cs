using System;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000D6 RID: 214
	[global::System.Obsolete("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
	[global::Cpp2ILInjected.Token(Token = "0x2000108")]
	[global::System.Serializable]
	public abstract class TimeZone
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00015FF5 File Offset: 0x000141F5
		[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
		private static object InternalSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4C4D8", Offset = "0x1C4C4D8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(global::System.TimeZone))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00015FF8 File Offset: 0x000141F8
		[global::Cpp2ILInjected.Token(Token = "0x60009D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C570", Offset = "0x1C4C570", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected TimeZone()
		{
			throw null;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00015FFB File Offset: 0x000141FB
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public static global::System.TimeZone CurrentTimeZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4C578", Offset = "0x1C4C578", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "GetUtcOffset", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "ToUniversalTicks", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeIso", MemberParameters = new object[]
			{
				"Newtonsoft.Json.Utilities.StringReference",
				"Newtonsoft.Json.DateTimeZoneHandling",
				typeof(ref global::System.DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new object[]
			{
				"System.Char[]",
				typeof(int),
				typeof(global::System.DateTime),
				"System.Nullable`1<TimeSpan>",
				typeof(global::System.DateTimeKind),
				"Newtonsoft.Json.DateFormatHandling"
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZone), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CurrentSystemTimeZone), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000932 RID: 2354
		[global::Cpp2ILInjected.Token(Token = "0x60009DA")]
		public abstract global::System.TimeSpan GetUtcOffset(global::System.DateTime time);

		// Token: 0x06000933 RID: 2355
		[global::Cpp2ILInjected.Token(Token = "0x60009DB")]
		public abstract global::System.Globalization.DaylightTime GetDaylightChanges(int year);

		// Token: 0x06000934 RID: 2356 RVA: 0x00015FFE File Offset: 0x000141FE
		[global::Cpp2ILInjected.Token(Token = "0x60009DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C6D8", Offset = "0x1C4C6D8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetUtcOffset", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "IsAmbiguousDaylightSavingTime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static global::System.TimeSpan CalculateUtcOffset(global::System.DateTime time, global::System.Globalization.DaylightTime daylightTimes)
		{
			throw null;
		}

		// Token: 0x04000278 RID: 632
		[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
		private static global::System.TimeZone currentTimeZone;

		// Token: 0x04000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
		private static object s_InternalSyncObject;
	}
}
