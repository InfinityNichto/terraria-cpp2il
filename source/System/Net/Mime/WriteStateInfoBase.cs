using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Mime
{
	[global::Cpp2ILInjected.Token(Token = "0x2000327")]
	internal class WriteStateInfoBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38FC4", Offset = "0x1E38FC4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal WriteStateInfoBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004C6")]
		internal int FooterLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390E4", Offset = "0x1E390E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004C7")]
		internal byte[] Footer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390F0", Offset = "0x1E390F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004C8")]
		internal byte[] Header
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390F8", Offset = "0x1E390F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004C9")]
		internal byte[] Buffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39100", Offset = "0x1E39100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004CA")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39108", Offset = "0x1E39108", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004CB")]
		internal int CurrentLineLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E39110", Offset = "0x1E39110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39118", Offset = "0x1E39118", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendCRLF", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureSpaceInBuffer(int moreBytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E391B0", Offset = "0x1E391B0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal void Append(byte aByte)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E391F8", Offset = "0x1E391F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendCRLF", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendHeader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteStateInfoBase), Member = "AppendFooter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void Append(params byte[] bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39244", Offset = "0x1E39244", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AppendCRLF(bool includeSpace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39334", Offset = "0x1E39334", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		internal void AppendHeader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3931C", Offset = "0x1E3931C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		internal void AppendFooter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004CC")]
		internal int MaxLineLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3934C", Offset = "0x1E3934C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39354", Offset = "0x1E39354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "Write", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "CompleteWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Base64Stream.WriteAsyncResult", Member = "OnWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400115E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected readonly byte[] _header;

		[global::Cpp2ILInjected.Token(Token = "0x400115F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected readonly byte[] _footer;

		[global::Cpp2ILInjected.Token(Token = "0x4001160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected readonly int _maxLineLength;

		[global::Cpp2ILInjected.Token(Token = "0x4001161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4001162")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected int _currentLineLength;

		[global::Cpp2ILInjected.Token(Token = "0x4001163")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected int _currentBufferUsed;
	}
}
