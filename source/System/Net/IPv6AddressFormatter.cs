using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200025F")]
	internal struct IPv6AddressFormatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E008F4", Offset = "0x1E008F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public IPv6AddressFormatter(ushort[] addr, long scopeId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E008FC", Offset = "0x1E008FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ushort SwapUShort(ushort number)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00908", Offset = "0x1E00908", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint AsIPv4Int()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00928", Offset = "0x1E00928", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressFormatter), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool IsIPv4Compatible()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00978", Offset = "0x1E00978", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsIPv4Mapped()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600105E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E009B8", Offset = "0x1E009B8", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressFormatter), Member = "IsIPv4Compatible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ushort[] address;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private long scopeId;
	}
}
