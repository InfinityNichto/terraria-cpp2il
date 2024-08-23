using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C4 RID: 196
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
	[global::System.Serializable]
	public readonly struct SByte : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<sbyte>, global::System.IEquatable<sbyte>, global::System.ISpanFormattable
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x00015DB5 File Offset: 0x00013FB5
		[global::Cpp2ILInjected.Token(Token = "0x6000914")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45D20", Offset = "0x1C45D20", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_byte", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object obj)
		{
			throw null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00015DB8 File Offset: 0x00013FB8
		[global::Cpp2ILInjected.Token(Token = "0x6000915")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45DDC", Offset = "0x1C45DDC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(sbyte value)
		{
			throw null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00015DBB File Offset: 0x00013FBB
		[global::Cpp2ILInjected.Token(Token = "0x6000916")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45DE8", Offset = "0x1C45DE8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00015DBE File Offset: 0x00013FBE
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000917")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45E60", Offset = "0x1C45E60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(sbyte obj)
		{
			throw null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00015DC1 File Offset: 0x00013FC1
		[global::Cpp2ILInjected.Token(Token = "0x6000918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45E70", Offset = "0x1C45E70", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00015DC4 File Offset: 0x00013FC4
		[global::Cpp2ILInjected.Token(Token = "0x6000919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45E7C", Offset = "0x1C45E7C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00015DC7 File Offset: 0x00013FC7
		[global::Cpp2ILInjected.Token(Token = "0x600091A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45F14", Offset = "0x1C45F14", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00015DCA File Offset: 0x00013FCA
		[global::Cpp2ILInjected.Token(Token = "0x600091B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45FB0", Offset = "0x1C45FB0", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SByteConverter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00015DCD File Offset: 0x00013FCD
		[global::Cpp2ILInjected.Token(Token = "0x600091C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4612C", Offset = "0x1C4612C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00015DD0 File Offset: 0x00013FD0
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600091D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46248", Offset = "0x1C46248", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static sbyte Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00015DD3 File Offset: 0x00013FD3
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600091E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4647C", Offset = "0x1C4647C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SByteConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static sbyte Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00015DD6 File Offset: 0x00013FD6
		[global::Cpp2ILInjected.Token(Token = "0x600091F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C462E4", Offset = "0x1C462E4", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static sbyte Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00015DD9 File Offset: 0x00013FD9
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000920")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4650C", Offset = "0x1C4650C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref sbyte)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out sbyte result)
		{
			throw null;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00015DDC File Offset: 0x00013FDC
		[global::Cpp2ILInjected.Token(Token = "0x6000921")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C465B4", Offset = "0x1C465B4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info, out sbyte result)
		{
			throw null;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00015DDF File Offset: 0x00013FDF
		[global::Cpp2ILInjected.Token(Token = "0x6000922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4667C", Offset = "0x1C4667C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00015DE2 File Offset: 0x00013FE2
		[global::Cpp2ILInjected.Token(Token = "0x6000923")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46684", Offset = "0x1C46684", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00015DE5 File Offset: 0x00013FE5
		[global::Cpp2ILInjected.Token(Token = "0x6000924")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C466E0", Offset = "0x1C466E0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00015DE8 File Offset: 0x00013FE8
		[global::Cpp2ILInjected.Token(Token = "0x6000925")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4673C", Offset = "0x1C4673C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00015DEB File Offset: 0x00013FEB
		[global::Cpp2ILInjected.Token(Token = "0x6000926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46744", Offset = "0x1C46744", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00015DEE File Offset: 0x00013FEE
		[global::Cpp2ILInjected.Token(Token = "0x6000927")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C467A0", Offset = "0x1C467A0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00015DF1 File Offset: 0x00013FF1
		[global::Cpp2ILInjected.Token(Token = "0x6000928")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C467FC", Offset = "0x1C467FC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00015DF4 File Offset: 0x00013FF4
		[global::Cpp2ILInjected.Token(Token = "0x6000929")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46858", Offset = "0x1C46858", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00015DF7 File Offset: 0x00013FF7
		[global::Cpp2ILInjected.Token(Token = "0x600092A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46860", Offset = "0x1C46860", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00015DFA File Offset: 0x00013FFA
		[global::Cpp2ILInjected.Token(Token = "0x600092B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C468BC", Offset = "0x1C468BC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00015DFD File Offset: 0x00013FFD
		[global::Cpp2ILInjected.Token(Token = "0x600092C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46918", Offset = "0x1C46918", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00015E00 File Offset: 0x00014000
		[global::Cpp2ILInjected.Token(Token = "0x600092D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46974", Offset = "0x1C46974", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00015E03 File Offset: 0x00014003
		[global::Cpp2ILInjected.Token(Token = "0x600092E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C469D0", Offset = "0x1C469D0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00015E06 File Offset: 0x00014006
		[global::Cpp2ILInjected.Token(Token = "0x600092F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46A2C", Offset = "0x1C46A2C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00015E09 File Offset: 0x00014009
		[global::Cpp2ILInjected.Token(Token = "0x6000930")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46A88", Offset = "0x1C46A88", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00015E0C File Offset: 0x0001400C
		[global::Cpp2ILInjected.Token(Token = "0x6000931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46B0C", Offset = "0x1C46B0C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x04000243 RID: 579
		[global::Cpp2ILInjected.Token(Token = "0x4000395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly sbyte m_value;

		// Token: 0x04000244 RID: 580
		[global::Cpp2ILInjected.Token(Token = "0x4000396")]
		public const sbyte MaxValue = 127;

		// Token: 0x04000245 RID: 581
		[global::Cpp2ILInjected.Token(Token = "0x4000397")]
		public const sbyte MinValue = -128;
	}
}
