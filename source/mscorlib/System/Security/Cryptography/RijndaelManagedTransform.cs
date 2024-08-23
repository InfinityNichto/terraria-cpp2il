using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000252 RID: 594
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002EF")]
	public sealed class RijndaelManagedTransform : ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x0600170E RID: 5902 RVA: 0x000185C0 File Offset: 0x000167C0
		[global::Cpp2ILInjected.Token(Token = "0x6001928")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02C00", Offset = "0x1B02C00", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CipherMode),
			typeof(byte[]),
			typeof(int),
			typeof(RijndaelManagedTransformMode)
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal RijndaelManagedTransform(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
		{
			throw null;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000185C3 File Offset: 0x000167C3
		[global::Cpp2ILInjected.Token(Token = "0x6001929")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B03598", Offset = "0x1B03598", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x000185C6 File Offset: 0x000167C6
		[global::Cpp2ILInjected.Token(Token = "0x600192A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0365C", Offset = "0x1B0365C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x000185C9 File Offset: 0x000167C9
		[global::Cpp2ILInjected.Token(Token = "0x600192B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B035A0", Offset = "0x1B035A0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000185CC File Offset: 0x000167CC
		[global::Cpp2ILInjected.Token(Token = "0x170002B4")]
		public int BlockSizeValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600192C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B03664", Offset = "0x1B03664", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x000185CF File Offset: 0x000167CF
		[global::Cpp2ILInjected.Token(Token = "0x170002B5")]
		public int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600192D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0366C", Offset = "0x1B0366C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000185D2 File Offset: 0x000167D2
		[global::Cpp2ILInjected.Token(Token = "0x170002B6")]
		public int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600192E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B03674", Offset = "0x1B03674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x000185D5 File Offset: 0x000167D5
		[global::Cpp2ILInjected.Token(Token = "0x170002B7")]
		public bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600192F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B0367C", Offset = "0x1B0367C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000185D8 File Offset: 0x000167D8
		[global::Cpp2ILInjected.Token(Token = "0x170002B8")]
		public bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001930")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B03684", Offset = "0x1B03684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000185DB File Offset: 0x000167DB
		[global::Cpp2ILInjected.Token(Token = "0x6001931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0368C", Offset = "0x1B0368C", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000185DE File Offset: 0x000167DE
		[global::Cpp2ILInjected.Token(Token = "0x6001932")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B04B44", Offset = "0x1B04B44", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000185E1 File Offset: 0x000167E1
		[global::Cpp2ILInjected.Token(Token = "0x6001933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B04E00", Offset = "0x1B04E00", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000185E4 File Offset: 0x000167E4
		[global::Cpp2ILInjected.Token(Token = "0x6001934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B03950", Offset = "0x1B03950", Length = "0x9CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new object[]
		{
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private unsafe int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			throw null;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000185E7 File Offset: 0x000167E7
		[global::Cpp2ILInjected.Token(Token = "0x6001935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0431C", Offset = "0x1B0431C", Length = "0x828")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Enc", MemberParameters = new object[]
		{
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Dec", MemberParameters = new object[]
		{
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*),
			typeof(int*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private unsafe int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			throw null;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000185EA File Offset: 0x000167EA
		[global::Cpp2ILInjected.Token(Token = "0x6001936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B04E68", Offset = "0x1B04E68", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
			throw null;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000185ED File Offset: 0x000167ED
		[global::Cpp2ILInjected.Token(Token = "0x6001937")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0502C", Offset = "0x1B0502C", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "DecryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
			throw null;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000185F0 File Offset: 0x000167F0
		[global::Cpp2ILInjected.Token(Token = "0x6001938")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B03148", Offset = "0x1B03148", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CipherMode),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(PaddingMode),
			typeof(RijndaelManagedTransformMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "SubWord", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void GenerateKeyExpansion(byte[] rgbKey)
		{
			throw null;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000185F3 File Offset: 0x000167F3
		[global::Cpp2ILInjected.Token(Token = "0x6001939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052CC", Offset = "0x1B052CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot1(int val)
		{
			throw null;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000185F6 File Offset: 0x000167F6
		[global::Cpp2ILInjected.Token(Token = "0x600193A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052C4", Offset = "0x1B052C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot2(int val)
		{
			throw null;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000185F9 File Offset: 0x000167F9
		[global::Cpp2ILInjected.Token(Token = "0x600193B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0520C", Offset = "0x1B0520C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot3(int val)
		{
			throw null;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000185FC File Offset: 0x000167FC
		[global::Cpp2ILInjected.Token(Token = "0x600193C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05214", Offset = "0x1B05214", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "GenerateKeyExpansion", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int SubWord(int a)
		{
			throw null;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000185FF File Offset: 0x000167FF
		[global::Cpp2ILInjected.Token(Token = "0x600193D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052A0", Offset = "0x1B052A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int MulX(int x)
		{
			throw null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00018602 File Offset: 0x00016802
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600193E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052D4", Offset = "0x1B052D4", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static RijndaelManagedTransform()
		{
			throw null;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00018605 File Offset: 0x00016805
		[global::Cpp2ILInjected.Token(Token = "0x600193F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B054C0", Offset = "0x1B054C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RijndaelManagedTransform()
		{
			throw null;
		}

		// Token: 0x040009FF RID: 2559
		[global::Cpp2ILInjected.Token(Token = "0x4000CD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CipherMode m_cipherMode;

		// Token: 0x04000A00 RID: 2560
		[global::Cpp2ILInjected.Token(Token = "0x4000CDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private PaddingMode m_paddingValue;

		// Token: 0x04000A01 RID: 2561
		[global::Cpp2ILInjected.Token(Token = "0x4000CDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RijndaelManagedTransformMode m_transformMode;

		// Token: 0x04000A02 RID: 2562
		[global::Cpp2ILInjected.Token(Token = "0x4000CDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_blockSizeBits;

		// Token: 0x04000A03 RID: 2563
		[global::Cpp2ILInjected.Token(Token = "0x4000CDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_blockSizeBytes;

		// Token: 0x04000A04 RID: 2564
		[global::Cpp2ILInjected.Token(Token = "0x4000CDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_inputBlockSize;

		// Token: 0x04000A05 RID: 2565
		[global::Cpp2ILInjected.Token(Token = "0x4000CDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int m_outputBlockSize;

		// Token: 0x04000A06 RID: 2566
		[global::Cpp2ILInjected.Token(Token = "0x4000CE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[] m_encryptKeyExpansion;

		// Token: 0x04000A07 RID: 2567
		[global::Cpp2ILInjected.Token(Token = "0x4000CE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int[] m_decryptKeyExpansion;

		// Token: 0x04000A08 RID: 2568
		[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int m_Nr;

		// Token: 0x04000A09 RID: 2569
		[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int m_Nb;

		// Token: 0x04000A0A RID: 2570
		[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_Nk;

		// Token: 0x04000A0B RID: 2571
		[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int[] m_encryptindex;

		// Token: 0x04000A0C RID: 2572
		[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int[] m_decryptindex;

		// Token: 0x04000A0D RID: 2573
		[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int[] m_IV;

		// Token: 0x04000A0E RID: 2574
		[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int[] m_lastBlockBuffer;

		// Token: 0x04000A0F RID: 2575
		[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private byte[] m_depadBuffer;

		// Token: 0x04000A10 RID: 2576
		[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private byte[] m_shiftRegister;

		// Token: 0x04000A11 RID: 2577
		[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
		private static readonly byte[] s_Sbox;

		// Token: 0x04000A12 RID: 2578
		[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
		private static readonly int[] s_Rcon;

		// Token: 0x04000A13 RID: 2579
		[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
		private static readonly int[] s_T;

		// Token: 0x04000A14 RID: 2580
		[global::Cpp2ILInjected.Token(Token = "0x4000CEE")]
		private static readonly int[] s_TF;

		// Token: 0x04000A15 RID: 2581
		[global::Cpp2ILInjected.Token(Token = "0x4000CEF")]
		private static readonly int[] s_iT;

		// Token: 0x04000A16 RID: 2582
		[global::Cpp2ILInjected.Token(Token = "0x4000CF0")]
		private static readonly int[] s_iTF;
	}
}
