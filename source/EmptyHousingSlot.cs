using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000155 RID: 341
[global::Cpp2ILInjected.Token(Token = "0x20001DA")]
[Serializable]
public class EmptyHousingSlot
{
	// Token: 0x06000B04 RID: 2820 RVA: 0x00023C51 File Offset: 0x00021E51
	[global::Cpp2ILInjected.Token(Token = "0x6000C17")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6DA8", Offset = "0x9B6DA8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public EmptyHousingSlot()
	{
		throw null;
	}

	// Token: 0x04000D03 RID: 3331
	[global::Cpp2ILInjected.Token(Token = "0x4001106")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Color BackingColor;

	// Token: 0x04000D04 RID: 3332
	[global::Cpp2ILInjected.Token(Token = "0x4001107")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public Color ItemColor;

	// Token: 0x04000D05 RID: 3333
	[global::Cpp2ILInjected.Token(Token = "0x4001108")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout HeadTexture;
}
