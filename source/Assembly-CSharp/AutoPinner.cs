using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000028 RID: 40
[global::Cpp2ILInjected.Token(Token = "0x2000044")]
internal class AutoPinner : IDisposable
{
	// Token: 0x06000100 RID: 256 RVA: 0x00021E78 File Offset: 0x00020078
	[global::Cpp2ILInjected.Token(Token = "0x600017A")]
	[global::Cpp2ILInjected.Address(RVA = "0x705678", Offset = "0x705678", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[]
	{
		typeof(object),
		typeof(GCHandleType)
	}, ReturnType = typeof(GCHandle))]
	public AutoPinner(object obj)
	{
		throw null;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00021E7B File Offset: 0x0002007B
	[global::Cpp2ILInjected.Token(Token = "0x600017B")]
	[global::Cpp2ILInjected.Address(RVA = "0x7056B0", Offset = "0x7056B0", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject", ReturnType = typeof(IntPtr))]
	public static implicit operator IntPtr(AutoPinner ap)
	{
		throw null;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00021E7E File Offset: 0x0002007E
	[global::Cpp2ILInjected.Token(Token = "0x600017C")]
	[global::Cpp2ILInjected.Address(RVA = "0x7056BC", Offset = "0x7056BC", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040000BD RID: 189
	[global::Cpp2ILInjected.Token(Token = "0x4000112")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private GCHandle _pinnedArray;
}
