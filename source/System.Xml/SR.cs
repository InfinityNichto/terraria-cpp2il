using System;
using System.Globalization;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class SR
{
	[global::Cpp2ILInjected.Token(Token = "0x6000001")]
	[global::Cpp2ILInjected.Address(RVA = "0x1D5C428", Offset = "0x1D5C428", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToBoolean", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref bool)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToChar", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref char)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref decimal)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToInteger", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref decimal)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToSByte", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref sbyte)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToInt16", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref short)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToInt32", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref int)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToInt64", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref long)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToByte", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref byte)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToUInt16", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref ushort)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToUInt32", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref uint)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToUInt64", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref ulong)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToSingle", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref float)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToDouble", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref double)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToGuid", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref Guid)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref Uri)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(ExceptionType),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[]),
		typeof(ExceptionType),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Exception))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	internal static string GetString(string name, params object[] args)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000002")]
	[global::Cpp2ILInjected.Address(RVA = "0x1D5C498", Offset = "0x1D5C498", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(IFormatProvider),
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(string))]
	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		throw null;
	}
}
