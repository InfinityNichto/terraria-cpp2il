using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000196 RID: 406
[global::Cpp2ILInjected.Token(Token = "0x2000224")]
public class WorldName_Layout : LayoutDefinition
{
	// Token: 0x06000BC2 RID: 3010 RVA: 0x00023E8B File Offset: 0x0002208B
	[global::Cpp2ILInjected.Token(Token = "0x6000CDB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D09F8", Offset = "0x9D09F8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00023E8E File Offset: 0x0002208E
	[global::Cpp2ILInjected.Token(Token = "0x6000CDC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0A44", Offset = "0x9D0A44", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldName_Layout()
	{
		throw null;
	}

	// Token: 0x040010C0 RID: 4288
	[global::Cpp2ILInjected.Token(Token = "0x400155A")]
	public static WorldName_Layout Instance;

	// Token: 0x040010C1 RID: 4289
	[global::Cpp2ILInjected.Token(Token = "0x400155B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Title;

	// Token: 0x040010C2 RID: 4290
	[global::Cpp2ILInjected.Token(Token = "0x400155C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InputWorldName;
}
