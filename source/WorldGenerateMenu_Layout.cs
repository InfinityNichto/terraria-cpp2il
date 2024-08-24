using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000195 RID: 405
[global::Cpp2ILInjected.Token(Token = "0x2000223")]
public class WorldGenerateMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BC0 RID: 3008 RVA: 0x00023E85 File Offset: 0x00022085
	[global::Cpp2ILInjected.Token(Token = "0x6000CD9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0914", Offset = "0x9D0914", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00023E88 File Offset: 0x00022088
	[global::Cpp2ILInjected.Token(Token = "0x6000CDA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0960", Offset = "0x9D0960", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public WorldGenerateMenu_Layout()
	{
		throw null;
	}

	// Token: 0x040010B7 RID: 4279
	[global::Cpp2ILInjected.Token(Token = "0x4001551")]
	public static WorldGenerateMenu_Layout Instance;

	// Token: 0x040010B8 RID: 4280
	[global::Cpp2ILInjected.Token(Token = "0x4001552")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Status;

	// Token: 0x040010B9 RID: 4281
	[global::Cpp2ILInjected.Token(Token = "0x4001553")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ProgressBar_Layout Progress;

	// Token: 0x040010BA RID: 4282
	[global::Cpp2ILInjected.Token(Token = "0x4001554")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ProgressBar_Layout StageProgress;

	// Token: 0x040010BB RID: 4283
	[global::Cpp2ILInjected.Token(Token = "0x4001555")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout BackingCorrupt;

	// Token: 0x040010BC RID: 4284
	[global::Cpp2ILInjected.Token(Token = "0x4001556")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Texture_Layout BackingCrimson;

	// Token: 0x040010BD RID: 4285
	[global::Cpp2ILInjected.Token(Token = "0x4001557")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color FillingColorCorrupt;

	// Token: 0x040010BE RID: 4286
	[global::Cpp2ILInjected.Token(Token = "0x4001558")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color FillingColorCrimson;

	// Token: 0x040010BF RID: 4287
	[global::Cpp2ILInjected.Token(Token = "0x4001559")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout GameTip;
}
