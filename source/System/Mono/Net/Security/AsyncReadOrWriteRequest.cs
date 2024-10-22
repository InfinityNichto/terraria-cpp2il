﻿using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		protected BufferOffsetSize UserBuffer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D49358", Offset = "0x1D49358", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		protected int CurrentSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D49360", Offset = "0x1D49360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D49368", Offset = "0x1D49368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49370", Offset = "0x1D49370", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncReadRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4940C", Offset = "0x1D4940C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly BufferOffsetSize <UserBuffer>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int <CurrentSize>k__BackingField;
	}
}
