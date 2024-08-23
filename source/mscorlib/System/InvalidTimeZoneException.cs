using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A4 RID: 164
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	[global::System.Serializable]
	public class InvalidTimeZoneException : global::System.Exception
	{
		// Token: 0x06000738 RID: 1848 RVA: 0x00015A4C File Offset: 0x00013C4C
		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3548C", Offset = "0x1C3548C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InvalidTimeZoneException()
		{
			throw null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00015A4F File Offset: 0x00013C4F
		[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C354E4", Offset = "0x1C354E4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GetEarlyDateTransitionType", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TZifType[]) }, ReturnType = "System.TimeZoneInfo.TZifType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseJulianDay", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InvalidTimeZoneException(string message)
		{
			throw null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00015A52 File Offset: 0x00013C52
		[global::Cpp2ILInjected.Token(Token = "0x60007DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3554C", Offset = "0x1C3554C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected InvalidTimeZoneException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
