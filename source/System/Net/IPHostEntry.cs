using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200019B")]
	public class IPHostEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000218")]
		public string HostName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E25C", Offset = "0x1F0E25C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E264", Offset = "0x1F0E264", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000219")]
		public string[] Aliases
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E26C", Offset = "0x1F0E26C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E274", Offset = "0x1F0E274", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		public IPAddress[] AddressList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E27C", Offset = "0x1F0E27C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E284", Offset = "0x1F0E284", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E28C", Offset = "0x1F0E28C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IPHostEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400084E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string hostName;

		[global::Cpp2ILInjected.Token(Token = "0x400084F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] aliases;

		[global::Cpp2ILInjected.Token(Token = "0x4000850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IPAddress[] addressList;

		[global::Cpp2ILInjected.Token(Token = "0x4000851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool isTrustedHost;
	}
}
