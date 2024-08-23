using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000278 RID: 632
	[global::Cpp2ILInjected.Token(Token = "0x2000315")]
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x00018A8B File Offset: 0x00016C8B
		[global::Cpp2ILInjected.Token(Token = "0x6001AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AA54", Offset = "0x1B1AA54", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RNGCryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00018A8E File Offset: 0x00016C8E
		[global::Cpp2ILInjected.Token(Token = "0x6001AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AAD0", Offset = "0x1B1AAD0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RNGCryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00018A91 File Offset: 0x00016C91
		[global::Cpp2ILInjected.Token(Token = "0x6001AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AC18", Offset = "0x1B1AC18", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RNGCryptoServiceProvider(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00018A94 File Offset: 0x00016C94
		[global::Cpp2ILInjected.Token(Token = "0x6001ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1ACD8", Offset = "0x1B1ACD8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RNGCryptoServiceProvider(CspParameters cspParams)
		{
			throw null;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00018A97 File Offset: 0x00016C97
		[global::Cpp2ILInjected.Token(Token = "0x6001ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AD70", Offset = "0x1B1AD70", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public RNGCryptoServiceProvider(string str)
		{
			throw null;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00018A9A File Offset: 0x00016C9A
		[global::Cpp2ILInjected.Token(Token = "0x6001ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AB6C", Offset = "0x1B1AB6C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = "GetBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RNGCryptoServiceProvider), Member = "GetNonZeroBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe void Check()
		{
			throw null;
		}

		// Token: 0x060018B3 RID: 6323
		[global::Cpp2ILInjected.Token(Token = "0x6001ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AACC", Offset = "0x1B1AACC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool RngOpen();

		// Token: 0x060018B4 RID: 6324
		[global::Cpp2ILInjected.Token(Token = "0x6001ACE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AB68", Offset = "0x1B1AB68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr RngInitialize(byte* seed, global::System.IntPtr seed_length);

		// Token: 0x060018B5 RID: 6325
		[global::Cpp2ILInjected.Token(Token = "0x6001ACF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AE78", Offset = "0x1B1AE78", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr RngGetBytes(global::System.IntPtr handle, byte* data, global::System.IntPtr data_length);

		// Token: 0x060018B6 RID: 6326
		[global::Cpp2ILInjected.Token(Token = "0x6001AD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AE7C", Offset = "0x1B1AE7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void RngClose(global::System.IntPtr handle);

		// Token: 0x060018B7 RID: 6327 RVA: 0x00018A9D File Offset: 0x00016C9D
		[global::Cpp2ILInjected.Token(Token = "0x6001AD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1AE80", Offset = "0x1B1AE80", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void GetBytes(byte[] data)
		{
			throw null;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00018AA0 File Offset: 0x00016CA0
		[global::Cpp2ILInjected.Token(Token = "0x6001AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B098", Offset = "0x1B1B098", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal unsafe void GetBytes(byte* data, global::System.IntPtr data_length)
		{
			throw null;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00018AA3 File Offset: 0x00016CA3
		[global::Cpp2ILInjected.Token(Token = "0x6001AD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B230", Offset = "0x1B1B230", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = "Check", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void GetNonZeroBytes(byte[] data)
		{
			throw null;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00018AA6 File Offset: 0x00016CA6
		[global::Cpp2ILInjected.Token(Token = "0x6001AD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B3C0", Offset = "0x1B1B3C0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00018AA9 File Offset: 0x00016CA9
		[global::Cpp2ILInjected.Token(Token = "0x6001AD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1B4D8", Offset = "0x1B1B4D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x04000ACE RID: 2766
		[global::Cpp2ILInjected.Token(Token = "0x4000DA8")]
		private static object _lock;

		// Token: 0x04000ACF RID: 2767
		[global::Cpp2ILInjected.Token(Token = "0x4000DA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr _handle;
	}
}
