using System;
using System.Resources;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000476 RID: 1142
	[global::Cpp2ILInjected.Token(Token = "0x200053C")]
	internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x0001ABAC File Offset: 0x00018DAC
		[global::Cpp2ILInjected.Token(Token = "0x6002784")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99D60", Offset = "0x1B99D60", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(long),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe PinnedBufferMemoryStream(byte[] array)
		{
			throw null;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0001ABAF File Offset: 0x00018DAF
		[global::Cpp2ILInjected.Token(Token = "0x6002785")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A060", Offset = "0x1B9A060", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int Read(global::System.Span<byte> buffer)
		{
			throw null;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0001ABB2 File Offset: 0x00018DB2
		[global::Cpp2ILInjected.Token(Token = "0x6002786")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A278", Offset = "0x1B9A278", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Write(global::System.ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0001ABB5 File Offset: 0x00018DB5
		[global::Cpp2ILInjected.Token(Token = "0x6002787")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A554", Offset = "0x1B9A554", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		[global::Cpp2ILInjected.Token(Token = "0x6002788")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A5F8", Offset = "0x1B9A5F8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Free", ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0400126E RID: 4718
		[global::Cpp2ILInjected.Token(Token = "0x400158E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private byte[] _array;

		// Token: 0x0400126F RID: 4719
		[global::Cpp2ILInjected.Token(Token = "0x400158F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Runtime.InteropServices.GCHandle _pinningHandle;
	}
}
