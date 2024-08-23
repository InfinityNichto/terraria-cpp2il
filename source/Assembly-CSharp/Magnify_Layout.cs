using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000166 RID: 358
[global::Cpp2ILInjected.Token(Token = "0x20001F0")]
public class Magnify_Layout : LayoutDefinition
{
	// Token: 0x06000B62 RID: 2914 RVA: 0x00023D6B File Offset: 0x00021F6B
	[global::Cpp2ILInjected.Token(Token = "0x6000C77")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE51C", Offset = "0x9CE51C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00023D6E File Offset: 0x00021F6E
	[global::Cpp2ILInjected.Token(Token = "0x6000C78")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE568", Offset = "0x9CE568", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Magnify_Layout()
	{
		throw null;
	}

	// Token: 0x04000DB5 RID: 3509
	[global::Cpp2ILInjected.Token(Token = "0x4001202")]
	public static Magnify_Layout Instance;

	// Token: 0x04000DB6 RID: 3510
	[global::Cpp2ILInjected.Token(Token = "0x4001203")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float WorldZoom;

	// Token: 0x04000DB7 RID: 3511
	[global::Cpp2ILInjected.Token(Token = "0x4001204")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BufferZone;

	// Token: 0x04000DB8 RID: 3512
	[global::Cpp2ILInjected.Token(Token = "0x4001205")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Panel;
}
