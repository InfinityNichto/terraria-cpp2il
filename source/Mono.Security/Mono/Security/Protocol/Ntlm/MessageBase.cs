﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Protocol.Ntlm
{
	[global::Cpp2ILInjected.Token(Token = "0x200003B")]
	public abstract class MessageBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99B4C", Offset = "0x1A99B4C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MessageBase(int messageType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public NtlmFlags Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A99B74", Offset = "0x1A99B74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A99B7C", Offset = "0x1A99B7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public int Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A99B84", Offset = "0x1A99B84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99B8C", Offset = "0x1A99B8C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type1Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type2Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected byte[] PrepareMessage(int messageSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99C5C", Offset = "0x1A99C5C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type1Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type2Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "CheckHeader", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		protected virtual void Decode(byte[] message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99DFC", Offset = "0x1A99DFC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected bool CheckHeader(byte[] message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		public abstract byte[] GetBytes();

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A99ECC", Offset = "0x1A99ECC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MessageBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		private static byte[] header;

		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _type;

		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private NtlmFlags _flags;
	}
}
