using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001C0")]
	internal class SplitWritesState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10494", Offset = "0x1F10494", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SplitWritesState(BufferOffsetSize[] buffers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022A")]
		internal bool IsDone
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F104C0", Offset = "0x1F104C0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10508", Offset = "0x1F10508", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal BufferOffsetSize[] GetNextBuffers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400097B")]
		private const int c_SplitEncryptedBuffersSize = 65536;

		[global::Cpp2ILInjected.Token(Token = "0x400097C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BufferOffsetSize[] _UserBuffers;

		[global::Cpp2ILInjected.Token(Token = "0x400097D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _Index;

		[global::Cpp2ILInjected.Token(Token = "0x400097E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _LastBufferConsumed;

		[global::Cpp2ILInjected.Token(Token = "0x400097F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BufferOffsetSize[] _RealBuffers;
	}
}
