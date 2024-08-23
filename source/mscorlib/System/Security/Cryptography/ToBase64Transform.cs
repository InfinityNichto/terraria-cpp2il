using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200022D RID: 557
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CA")]
	public class ToBase64Transform : ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000182E4 File Offset: 0x000164E4
		[global::Cpp2ILInjected.Token(Token = "0x17000289")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001826")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF92C8", Offset = "0x1AF92C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000182E7 File Offset: 0x000164E7
		[global::Cpp2ILInjected.Token(Token = "0x1700028A")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001827")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF92D0", Offset = "0x1AF92D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000182EA File Offset: 0x000164EA
		[global::Cpp2ILInjected.Token(Token = "0x1700028B")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001828")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF92D8", Offset = "0x1AF92D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000182ED File Offset: 0x000164ED
		[global::Cpp2ILInjected.Token(Token = "0x1700028C")]
		public virtual bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001829")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF92E0", Offset = "0x1AF92E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000182F0 File Offset: 0x000164F0
		[global::Cpp2ILInjected.Token(Token = "0x600182A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF92E8", Offset = "0x1AF92E8", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000182F3 File Offset: 0x000164F3
		[global::Cpp2ILInjected.Token(Token = "0x600182B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9530", Offset = "0x1AF9530", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000182F6 File Offset: 0x000164F6
		[global::Cpp2ILInjected.Token(Token = "0x600182C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9744", Offset = "0x1AF9744", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000182F9 File Offset: 0x000164F9
		[global::Cpp2ILInjected.Token(Token = "0x600182D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9748", Offset = "0x1AF9748", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000182FC File Offset: 0x000164FC
		[global::Cpp2ILInjected.Token(Token = "0x600182E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF97B4", Offset = "0x1AF97B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000182FF File Offset: 0x000164FF
		[global::Cpp2ILInjected.Token(Token = "0x600182F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF97B8", Offset = "0x1AF97B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00018302 File Offset: 0x00016502
		[global::Cpp2ILInjected.Token(Token = "0x6001830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9858", Offset = "0x1AF9858", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ToBase64Transform()
		{
			throw null;
		}
	}
}
