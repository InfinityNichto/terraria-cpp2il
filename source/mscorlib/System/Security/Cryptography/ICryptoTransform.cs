using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E1")]
	public interface ICryptoTransform : global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002A0")]
		int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BC")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A1")]
		int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BD")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BF")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C0")]
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		[global::Cpp2ILInjected.Token(Token = "0x60018C1")]
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
