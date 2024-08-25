using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200030E")]
	public sealed class CryptoAPITransform : ICryptoTransform, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12EEC", Offset = "0x1B12EEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CryptoAPITransform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DD")]
		public bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F08", Offset = "0x1B12F08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DE")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F10", Offset = "0x1B12F10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002DF")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F18", Offset = "0x1B12F18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E0")]
		public global::System.IntPtr KeyHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F20", Offset = "0x1B12F20", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E1")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B12F68", Offset = "0x1B12F68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12F70", Offset = "0x1B12F70", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12FF0", Offset = "0x1B12FF0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12FD8", Offset = "0x1B12FD8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13008", Offset = "0x1B13008", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13010", Offset = "0x1B13010", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B13018", Offset = "0x1B13018", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_disposed;
	}
}
