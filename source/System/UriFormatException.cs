using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	[Serializable]
	public class UriFormatException : FormatException, ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA3A58", Offset = "0x1EA3A58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", ReturnType = typeof(void))]
		public UriFormatException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600027D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1E18", Offset = "0x1EA1E18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public unsafe UriFormatException(string textString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600027E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA3A60", Offset = "0x1EA3A60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600027F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA3A68", Offset = "0x1EA3A68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
