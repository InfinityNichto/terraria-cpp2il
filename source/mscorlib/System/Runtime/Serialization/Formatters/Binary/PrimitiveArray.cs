using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200042B")]
	internal sealed class PrimitiveArray
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B67944", Offset = "0x1B67944", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimitiveArray), Member = "Init", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		internal PrimitiveArray(InternalPrimitiveTypeE code, global::System.Array array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F434", Offset = "0x1B6F434", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrimitiveArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal void Init(InternalPrimitiveTypeE code, global::System.Array array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68130", Offset = "0x1B68130", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal void SetValue(string value, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InternalPrimitiveTypeE code;

		[global::Cpp2ILInjected.Token(Token = "0x40011D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool[] booleanA;

		[global::Cpp2ILInjected.Token(Token = "0x40011D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char[] charA;

		[global::Cpp2ILInjected.Token(Token = "0x40011D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private double[] doubleA;

		[global::Cpp2ILInjected.Token(Token = "0x40011D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private short[] int16A;

		[global::Cpp2ILInjected.Token(Token = "0x40011D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int[] int32A;

		[global::Cpp2ILInjected.Token(Token = "0x40011D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private long[] int64A;

		[global::Cpp2ILInjected.Token(Token = "0x40011D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private sbyte[] sbyteA;

		[global::Cpp2ILInjected.Token(Token = "0x40011D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private float[] singleA;

		[global::Cpp2ILInjected.Token(Token = "0x40011D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ushort[] uint16A;

		[global::Cpp2ILInjected.Token(Token = "0x40011D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private uint[] uint32A;

		[global::Cpp2ILInjected.Token(Token = "0x40011DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ulong[] uint64A;
	}
}
