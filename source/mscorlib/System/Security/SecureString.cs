using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security
{
	// Token: 0x02000206 RID: 518
	[global::System.MonoTODO("work in progress - encryption is missing")]
	[global::Cpp2ILInjected.Token(Token = "0x2000298")]
	public sealed class SecureString : global::System.IDisposable
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x00017FE7 File Offset: 0x000161E7
		[global::Cpp2ILInjected.Token(Token = "0x60016F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC490", Offset = "0x1AEC490", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkCredential", Member = "set_SecurePassword", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateSecureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecureString))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SecureString()
		{
			throw null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00017FEA File Offset: 0x000161EA
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60016F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC620", Offset = "0x1AEC620", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateSecureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecureString))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe SecureString(char* value, int length)
		{
			throw null;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00017FED File Offset: 0x000161ED
		[global::Cpp2ILInjected.Token(Token = "0x17000250")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEC73C", Offset = "0x1AEC73C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "SecureStringToBSTR", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "SecureStringToUnicode", MemberParameters = new object[]
			{
				typeof(SecureString),
				typeof(global::System.Runtime.InteropServices.Marshal.SecureStringAllocator)
			}, ReturnType = typeof(global::System.IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateString", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00017FF0 File Offset: 0x000161F0
		[global::Cpp2ILInjected.Token(Token = "0x60016FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC79C", Offset = "0x1AEC79C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkCredential", Member = "get_SecurePassword", ReturnType = typeof(SecureString))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkCredential", Member = "set_SecurePassword", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public SecureString Copy()
		{
			throw null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00017FF3 File Offset: 0x000161F3
		[global::Cpp2ILInjected.Token(Token = "0x60016FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC874", Offset = "0x1AEC874", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00017FF6 File Offset: 0x000161F6
		[global::Cpp2ILInjected.Token(Token = "0x60016FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC738", Offset = "0x1AEC738", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Encrypt()
		{
			throw null;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00017FF9 File Offset: 0x000161F9
		[global::Cpp2ILInjected.Token(Token = "0x60016FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC8AC", Offset = "0x1AEC8AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Decrypt()
		{
			throw null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00017FFC File Offset: 0x000161FC
		[global::Cpp2ILInjected.Token(Token = "0x60016FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC4B4", Offset = "0x1AEC4B4", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecureString), Member = "Copy", ReturnType = typeof(SecureString))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private unsafe void Alloc(int length, bool realloc)
		{
			throw null;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00017FFF File Offset: 0x000161FF
		[global::Cpp2ILInjected.Token(Token = "0x60016FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEC8B0", Offset = "0x1AEC8B0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "SecureStringToBSTR", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "SecureStringToUnicode", MemberParameters = new object[]
		{
			typeof(SecureString),
			typeof(global::System.Runtime.InteropServices.Marshal.SecureStringAllocator)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal byte[] GetBuffer()
		{
			throw null;
		}

		// Token: 0x0400090C RID: 2316
		[global::Cpp2ILInjected.Token(Token = "0x4000B9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int length;

		// Token: 0x0400090D RID: 2317
		[global::Cpp2ILInjected.Token(Token = "0x4000BA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool disposed;

		// Token: 0x0400090E RID: 2318
		[global::Cpp2ILInjected.Token(Token = "0x4000BA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] data;
	}
}
