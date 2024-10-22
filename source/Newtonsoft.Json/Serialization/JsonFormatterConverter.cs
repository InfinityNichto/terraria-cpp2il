﻿using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000081")]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE28C4", Offset = "0x1CE28C4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x158CEBC", Offset = "0x158CEBC", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonFormatterConverter), Member = "ToBoolean", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private T GetTokenValue<T>(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2968", Offset = "0x1CE2968", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public object Convert(object value, Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2B60", Offset = "0x1CE2B60", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(TypeCode),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public object Convert(object value, TypeCode typeCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2C6C", Offset = "0x1CE2C6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter), Member = "GetTokenValue", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool ToBoolean(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2CC4", Offset = "0x1CE2CC4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(byte) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public byte ToByte(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2D1C", Offset = "0x1CE2D1C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public char ToChar(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2D74", Offset = "0x1CE2D74", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(DateTime) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DateTime ToDateTime(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2DCC", Offset = "0x1CE2DCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(decimal) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public decimal ToDecimal(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2E24", Offset = "0x1CE2E24", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(double) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public double ToDouble(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2E7C", Offset = "0x1CE2E7C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public short ToInt16(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2ED4", Offset = "0x1CE2ED4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int ToInt32(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2F2C", Offset = "0x1CE2F2C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(long) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public long ToInt64(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2F84", Offset = "0x1CE2F84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(sbyte) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sbyte ToSByte(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2FDC", Offset = "0x1CE2FDC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public float ToSingle(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3034", Offset = "0x1CE3034", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string ToString(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE308C", Offset = "0x1CE308C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(ushort) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ushort ToUInt16(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE30E4", Offset = "0x1CE30E4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(uint) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public uint ToUInt32(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE313C", Offset = "0x1CE313C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter[]), Member = "GetTokenValue", MemberTypeParameters = new object[] { typeof(ulong) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ulong ToUInt64(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly JsonProperty _member;
	}
}
