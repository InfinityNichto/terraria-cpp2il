using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002EF")]
	public sealed class RijndaelManagedTransform : ICryptoTransform, global::System.IDisposable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001929")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B03598", Offset = "0x1B03598", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600192A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0365C", Offset = "0x1B0365C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManagedTransform), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001939")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052CC", Offset = "0x1B052CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot1(int val)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600193A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052C4", Offset = "0x1B052C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot2(int val)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600193B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0520C", Offset = "0x1B0520C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int rot3(int val)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600193D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B052A0", Offset = "0x1B052A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int MulX(int x)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600193F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B054C0", Offset = "0x1B054C0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RijndaelManagedTransform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CipherMode m_cipherMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private PaddingMode m_paddingValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RijndaelManagedTransformMode m_transformMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_blockSizeBits;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_blockSizeBytes;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_inputBlockSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000CDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int m_outputBlockSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int[] m_encryptKeyExpansion;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int[] m_decryptKeyExpansion;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int m_Nr;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int m_Nb;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_Nk;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int[] m_encryptindex;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int[] m_decryptindex;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int[] m_IV;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int[] m_lastBlockBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000CE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private byte[] m_depadBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private byte[] m_shiftRegister;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEB")]
		private static readonly byte[] s_Sbox;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEC")]
		private static readonly int[] s_Rcon;

		[global::Cpp2ILInjected.Token(Token = "0x4000CED")]
		private static readonly int[] s_T;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEE")]
		private static readonly int[] s_TF;

		[global::Cpp2ILInjected.Token(Token = "0x4000CEF")]
		private static readonly int[] s_iT;

		[global::Cpp2ILInjected.Token(Token = "0x4000CF0")]
		private static readonly int[] s_iTF;
	}
}
