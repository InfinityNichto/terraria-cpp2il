using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000341")]
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CAC0", Offset = "0x1E3CAC0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidEnumArgumentException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CACC", Offset = "0x1E3CACC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public InvalidEnumArgumentException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CAD4", Offset = "0x1E3CAD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public InvalidEnumArgumentException(string message, Exception innerException)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CADC", Offset = "0x1E3CADC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "set_PriorityClass", MemberParameters = new object[] { typeof(ProcessPriorityClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CBB8", Offset = "0x1E3CBB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
