using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000312")]
	internal class SecurityBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001486")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37600", Offset = "0x1E37600", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecurityBuffer(byte[] data, SecurityBufferType tokentype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37648", Offset = "0x1E37648", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public SecurityBuffer(int size, SecurityBufferType tokentype)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E377C0", Offset = "0x1E377C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecurityBuffer(ChannelBinding binding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400111A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int size;

		[global::Cpp2ILInjected.Token(Token = "0x400111B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public SecurityBufferType type;

		[global::Cpp2ILInjected.Token(Token = "0x400111C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte[] token;

		[global::Cpp2ILInjected.Token(Token = "0x400111D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public SafeHandle unmanagedToken;

		[global::Cpp2ILInjected.Token(Token = "0x400111E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int offset;
	}
}
