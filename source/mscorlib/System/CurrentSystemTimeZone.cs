using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000072 RID: 114
	[global::System.Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
	[global::Cpp2ILInjected.Token(Token = "0x2000099")]
	[global::System.Serializable]
	internal class CurrentSystemTimeZone : global::System.TimeZone
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00015404 File Offset: 0x00013604
		[global::Cpp2ILInjected.Token(Token = "0x6000591")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15B64", Offset = "0x1C15B64", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZone), Member = "get_CurrentTimeZone", ReturnType = typeof(global::System.TimeZone))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZone), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_StandardName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_DaylightName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal CurrentSystemTimeZone()
		{
			throw null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00015407 File Offset: 0x00013607
		[global::Cpp2ILInjected.Token(Token = "0x6000592")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15C24", Offset = "0x1C15C24", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override global::System.Globalization.DaylightTime GetDaylightChanges(int year)
		{
			throw null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001540A File Offset: 0x0001360A
		[global::Cpp2ILInjected.Token(Token = "0x6000593")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15EBC", Offset = "0x1C15EBC", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetCachedDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DaylightTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static global::System.Globalization.DaylightTime CreateDaylightChanges(int year)
		{
			throw null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001540D File Offset: 0x0001360D
		[global::Cpp2ILInjected.Token(Token = "0x6000594")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C16130", Offset = "0x1C16130", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZone), Member = "CalculateUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Globalization.DaylightTime)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override global::System.TimeSpan GetUtcOffset(global::System.DateTime time)
		{
			throw null;
		}

		// Token: 0x060004FB RID: 1275
		[global::Cpp2ILInjected.Token(Token = "0x6000595")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1620C", Offset = "0x1C1620C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted);

		// Token: 0x060004FC RID: 1276 RVA: 0x00015410 File Offset: 0x00013610
		[global::Cpp2ILInjected.Token(Token = "0x6000596")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15CF0", Offset = "0x1C15CF0", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private global::System.Globalization.DaylightTime GetCachedDaylightChanges(int year)
		{
			throw null;
		}

		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long m_ticksOffset;

		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_standardName;

		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_daylightName;

		// Token: 0x0400013B RID: 315
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly global::System.Collections.Hashtable m_CachedDaylightChanges;
	}
}
