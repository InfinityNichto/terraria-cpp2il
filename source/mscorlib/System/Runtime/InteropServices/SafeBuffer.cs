using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000389 RID: 905
	[global::Cpp2ILInjected.Token(Token = "0x2000433")]
	public abstract class SafeBuffer : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x00019C52 File Offset: 0x00017E52
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600215A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FAA0", Offset = "0x1B6FAA0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.UIntPtr),
			typeof(global::System.UIntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeBuffer), Member = "NotInitialized", ReturnType = typeof(global::System.InvalidOperationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			throw null;
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00019C55 File Offset: 0x00017E55
		[global::Cpp2ILInjected.Token(Token = "0x600215B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FCD8", Offset = "0x1B6FCD8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.UIntPtr),
			typeof(global::System.UIntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeBuffer), Member = "NotInitialized", ReturnType = typeof(global::System.InvalidOperationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void ReleasePointer()
		{
			throw null;
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00019C58 File Offset: 0x00017E58
		[global::Cpp2ILInjected.Token(Token = "0x600215C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FBA8", Offset = "0x1B6FBA8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe static global::System.InvalidOperationException NotInitialized()
		{
			throw null;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00019C5B File Offset: 0x00017E5B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600215D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6FDBC", Offset = "0x1B6FDBC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "get_Size", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(global::System.UIntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(global::System.UIntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SafeBuffer()
		{
			throw null;
		}

		// Token: 0x04000F02 RID: 3842
		[global::Cpp2ILInjected.Token(Token = "0x40011F7")]
		private static readonly global::System.UIntPtr Uninitialized;

		// Token: 0x04000F03 RID: 3843
		[global::Cpp2ILInjected.Token(Token = "0x40011F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.UIntPtr _numBytes;
	}
}
