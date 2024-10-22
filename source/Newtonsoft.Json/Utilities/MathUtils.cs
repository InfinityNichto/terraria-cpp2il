﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	internal static class MathUtils
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDA9F8", Offset = "0x1CDA9F8", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPosition), Member = "CalculateLength", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIntegerValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static int IntLength(ulong i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDABBC", Offset = "0x1CDABBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static char IntToHex(int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDABD4", Offset = "0x1CDABD4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int? Min(int? val1, int? val2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDACB4", Offset = "0x1CDACB4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int? Max(int? val1, int? val2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDAD94", Offset = "0x1CDAD94", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double?), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static double? Max(double? val1, double? val2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDAE90", Offset = "0x1CDAE90", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "CompareFloat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ApproxEquals(double d1, double d2)
		{
			throw null;
		}
	}
}
