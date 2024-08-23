using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200024A RID: 586
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E7")]
	public class PasswordDeriveBytes : DeriveBytes
	{
		// Token: 0x060016CB RID: 5835 RVA: 0x000184FA File Offset: 0x000166FA
		[global::Cpp2ILInjected.Token(Token = "0x60018E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFEE0", Offset = "0x1AFFEE0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
		{
			throw null;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000184FD File Offset: 0x000166FD
		[global::Cpp2ILInjected.Token(Token = "0x60018E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFFDC", Offset = "0x1AFFFDC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PasswordDeriveBytes(byte[] password, byte[] salt)
		{
			throw null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00018500 File Offset: 0x00016700
		[global::Cpp2ILInjected.Token(Token = "0x60018E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B000C8", Offset = "0x1B000C8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
		{
			throw null;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00018503 File Offset: 0x00016703
		[global::Cpp2ILInjected.Token(Token = "0x60018E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0020C", Offset = "0x1B0020C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
		{
			throw null;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00018506 File Offset: 0x00016706
		[global::Cpp2ILInjected.Token(Token = "0x60018E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFF68", Offset = "0x1AFFF68", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(string),
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
		{
			throw null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00018509 File Offset: 0x00016709
		[global::Cpp2ILInjected.Token(Token = "0x60018EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00064", Offset = "0x1B00064", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(string),
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
		{
			throw null;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0001850C File Offset: 0x0001670C
		[global::Cpp2ILInjected.Token(Token = "0x60018EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00168", Offset = "0x1B00168", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF8Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(string),
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
		{
			throw null;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0001850F File Offset: 0x0001670F
		[global::Cpp2ILInjected.Token(Token = "0x60018EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B002A8", Offset = "0x1B002A8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(string),
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "set_IterationCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "set_Salt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "set_HashName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
		{
			throw null;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00018512 File Offset: 0x00016712
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00018515 File Offset: 0x00016715
		[global::Cpp2ILInjected.Token(Token = "0x170002AC")]
		public string HashName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B006BC", Offset = "0x1B006BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B00550", Offset = "0x1B00550", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[]),
				typeof(string),
				typeof(int),
				typeof(CspParameters)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00018518 File Offset: 0x00016718
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0001851B File Offset: 0x0001671B
		[global::Cpp2ILInjected.Token(Token = "0x170002AD")]
		public int IterationCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B006C4", Offset = "0x1B006C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B00308", Offset = "0x1B00308", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[]),
				typeof(string),
				typeof(int),
				typeof(CspParameters)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0001851E File Offset: 0x0001671E
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00018521 File Offset: 0x00016721
		[global::Cpp2ILInjected.Token(Token = "0x170002AE")]
		public byte[] Salt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B006CC", Offset = "0x1B006CC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B00410", Offset = "0x1B00410", Length = "0x140")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[]),
				typeof(string),
				typeof(int),
				typeof(CspParameters)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00018524 File Offset: 0x00016724
		[global::System.Obsolete("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
		[global::Cpp2ILInjected.Token(Token = "0x60018F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00740", Offset = "0x1B00740", Length = "0x180")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "ComputeBaseValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "ComputeBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override byte[] GetBytes(int cb)
		{
			throw null;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00018527 File Offset: 0x00016727
		[global::Cpp2ILInjected.Token(Token = "0x60018F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00EAC", Offset = "0x1B00EAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0001852A File Offset: 0x0001672A
		[global::Cpp2ILInjected.Token(Token = "0x60018F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00EB8", Offset = "0x1B00EB8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0001852D File Offset: 0x0001672D
		[global::Cpp2ILInjected.Token(Token = "0x60018F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00F3C", Offset = "0x1B00F3C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00018530 File Offset: 0x00016730
		[global::Cpp2ILInjected.Token(Token = "0x60018F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B008C0", Offset = "0x1B008C0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] ComputeBaseValue()
		{
			throw null;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00018533 File Offset: 0x00016733
		[global::Cpp2ILInjected.Token(Token = "0x60018F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B009F8", Offset = "0x1B009F8", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ICryptoTransform),
			typeof(CryptoStreamMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PasswordDeriveBytes), Member = "HashPrefix", MemberParameters = new object[] { typeof(CryptoStream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private byte[] ComputeBytes(int cb)
		{
			throw null;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00018536 File Offset: 0x00016736
		[global::Cpp2ILInjected.Token(Token = "0x60018F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B00FDC", Offset = "0x1B00FDC", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "ComputeBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void HashPrefix(CryptoStream cs)
		{
			throw null;
		}

		// Token: 0x040009EB RID: 2539
		[global::Cpp2ILInjected.Token(Token = "0x4000CC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _extraCount;

		// Token: 0x040009EC RID: 2540
		[global::Cpp2ILInjected.Token(Token = "0x4000CC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _prefix;

		// Token: 0x040009ED RID: 2541
		[global::Cpp2ILInjected.Token(Token = "0x4000CC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _iterations;

		// Token: 0x040009EE RID: 2542
		[global::Cpp2ILInjected.Token(Token = "0x4000CC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] _baseValue;

		// Token: 0x040009EF RID: 2543
		[global::Cpp2ILInjected.Token(Token = "0x4000CC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _extra;

		// Token: 0x040009F0 RID: 2544
		[global::Cpp2ILInjected.Token(Token = "0x4000CCA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] _salt;

		// Token: 0x040009F1 RID: 2545
		[global::Cpp2ILInjected.Token(Token = "0x4000CCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _hashName;

		// Token: 0x040009F2 RID: 2546
		[global::Cpp2ILInjected.Token(Token = "0x4000CCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] _password;

		// Token: 0x040009F3 RID: 2547
		[global::Cpp2ILInjected.Token(Token = "0x4000CCD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private HashAlgorithm _hash;
	}
}
