using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200006D RID: 109
[global::Cpp2ILInjected.Token(Token = "0x200009E")]
public class GUIControllerNPCDialogue : GUIControllerItem
{
	// Token: 0x0600032E RID: 814 RVA: 0x000224CF File Offset: 0x000206CF
	[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80DF4", Offset = "0xA80DF4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x000224D2 File Offset: 0x000206D2
	[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80DFC", Offset = "0xA80DFC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000224D5 File Offset: 0x000206D5
	[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80E04", Offset = "0xA80E04", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x000224D8 File Offset: 0x000206D8
	[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80EA0", Offset = "0xA80EA0", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "LoadPanelRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000332 RID: 818 RVA: 0x000224DB File Offset: 0x000206DB
	[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA80F8C", Offset = "0xA80F8C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerNPCDialogue()
	{
		throw null;
	}

	// Token: 0x0400027D RID: 637
	[global::Cpp2ILInjected.Token(Token = "0x40003B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int _selected;
}
