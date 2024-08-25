using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002C5")]
	internal class MibIPGlobalProperties : UnixIPGlobalProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E207DC", Offset = "0x1E207DC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MibIPGlobalProperties(string procDir)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20944", Offset = "0x1E20944", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MibIPGlobalProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string StatisticsFile;

		[global::Cpp2ILInjected.Token(Token = "0x4000F0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string StatisticsFileIPv6;

		[global::Cpp2ILInjected.Token(Token = "0x4000F0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly string TcpFile;

		[global::Cpp2ILInjected.Token(Token = "0x4000F0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly string Tcp6File;

		[global::Cpp2ILInjected.Token(Token = "0x4000F0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly string UdpFile;

		[global::Cpp2ILInjected.Token(Token = "0x4000F0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly string Udp6File;

		[global::Cpp2ILInjected.Token(Token = "0x4000F10")]
		private static readonly char[] wsChars;
	}
}
