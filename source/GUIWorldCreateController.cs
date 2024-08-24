using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000078 RID: 120
[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
public class GUIWorldCreateController : GUIControllerItem
{
	// Token: 0x06000374 RID: 884 RVA: 0x000225A1 File Offset: 0x000207A1
	[global::Cpp2ILInjected.Token(Token = "0x600040E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844B8", Offset = "0xA844B8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x000225A4 File Offset: 0x000207A4
	[global::Cpp2ILInjected.Token(Token = "0x600040F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844C0", Offset = "0xA844C0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public int GetNavigationOutDirs()
	{
		throw null;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x000225A7 File Offset: 0x000207A7
	[global::Cpp2ILInjected.Token(Token = "0x6000410")]
	[global::Cpp2ILInjected.Address(RVA = "0xA844C8", Offset = "0xA844C8", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x000225AA File Offset: 0x000207AA
	[global::Cpp2ILInjected.Token(Token = "0x6000411")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84690", Offset = "0xA84690", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "EnterName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateName()
	{
		throw null;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x000225AD File Offset: 0x000207AD
	[global::Cpp2ILInjected.Token(Token = "0x6000412")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8469C", Offset = "0xA8469C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateName()
	{
		throw null;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000225B0 File Offset: 0x000207B0
	[global::Cpp2ILInjected.Token(Token = "0x6000413")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846A4", Offset = "0xA846A4", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "EnterSeed", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateSeed()
	{
		throw null;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x000225B3 File Offset: 0x000207B3
	[global::Cpp2ILInjected.Token(Token = "0x6000414")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846B0", Offset = "0xA846B0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "CloseSeedEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void DeactivateSeed()
	{
		throw null;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x000225B6 File Offset: 0x000207B6
	[global::Cpp2ILInjected.Token(Token = "0x6000415")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846B8", Offset = "0xA846B8", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateDifficultyOptions(int selectedOption, int wrapAround)
	{
		throw null;
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000225B9 File Offset: 0x000207B9
	[global::Cpp2ILInjected.Token(Token = "0x6000416")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846CC", Offset = "0xA846CC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	public void DeactivateDifficultyOptions()
	{
		throw null;
	}

	// Token: 0x0600037D RID: 893 RVA: 0x000225BC File Offset: 0x000207BC
	[global::Cpp2ILInjected.Token(Token = "0x6000417")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846D4", Offset = "0xA846D4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldSize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateWorldOptions(int selectedOption)
	{
		throw null;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x000225BF File Offset: 0x000207BF
	[global::Cpp2ILInjected.Token(Token = "0x6000418")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846E4", Offset = "0xA846E4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldSize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	public void DeactivateWorldOptions()
	{
		throw null;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x000225C2 File Offset: 0x000207C2
	[global::Cpp2ILInjected.Token(Token = "0x6000419")]
	[global::Cpp2ILInjected.Address(RVA = "0xA846EC", Offset = "0xA846EC", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldEvilType", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ActivateEvilTypeOptions(int selectedOption, int wrapAround)
	{
		throw null;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000225C5 File Offset: 0x000207C5
	[global::Cpp2ILInjected.Token(Token = "0x600041A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84700", Offset = "0xA84700", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawWorldEvilType", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	public void DeactivateEvilTypeOptions()
	{
		throw null;
	}

	// Token: 0x06000381 RID: 897 RVA: 0x000225C8 File Offset: 0x000207C8
	[global::Cpp2ILInjected.Token(Token = "0x600041B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84708", Offset = "0xA84708", Length = "0x3A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x000225CB File Offset: 0x000207CB
	[global::Cpp2ILInjected.Token(Token = "0x600041C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84AAC", Offset = "0xA84AAC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIWorldCreateController()
	{
		throw null;
	}

	// Token: 0x04000297 RID: 663
	[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int selectedItem;

	// Token: 0x04000298 RID: 664
	[global::Cpp2ILInjected.Token(Token = "0x40003F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool nameActive;

	// Token: 0x04000299 RID: 665
	[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	private bool seedActive;

	// Token: 0x0400029A RID: 666
	[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
	private bool worldActive;

	// Token: 0x0400029B RID: 667
	[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int worldIndex;

	// Token: 0x0400029C RID: 668
	[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool difficultyActive;

	// Token: 0x0400029D RID: 669
	[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int difficultyIndex;

	// Token: 0x0400029E RID: 670
	[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int difficultyWrapAround;

	// Token: 0x0400029F RID: 671
	[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool evilTypeActive;

	// Token: 0x040002A0 RID: 672
	[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int evilTypeIndex;

	// Token: 0x040002A1 RID: 673
	[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int evilTypeWrapAround;
}
