using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000244 RID: 580
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E1")]
	public interface ICryptoTransform : global::System.IDisposable
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060016A2 RID: 5794
		[global::Cpp2ILInjected.Token(Token = "0x170002A0")]
		int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BC")]
			get;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060016A3 RID: 5795
		[global::Cpp2ILInjected.Token(Token = "0x170002A1")]
		int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BD")]
			get;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060016A4 RID: 5796
		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BE")]
			get;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060016A5 RID: 5797
		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018BF")]
			get;
		}

		// Token: 0x060016A6 RID: 5798
		[global::Cpp2ILInjected.Token(Token = "0x60018C0")]
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		// Token: 0x060016A7 RID: 5799
		[global::Cpp2ILInjected.Token(Token = "0x60018C1")]
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
