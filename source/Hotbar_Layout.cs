using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000153 RID: 339
[global::Cpp2ILInjected.Token(Token = "0x20001D8")]
public class Hotbar_Layout : LayoutDefinition
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00023C42 File Offset: 0x00021E42
	[global::Cpp2ILInjected.Token(Token = "0x17000152")]
	public static Hotbar_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B6B44", Offset = "0x9B6B44", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHotbarRadial), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(GUIItemGrid.GetItemScaleHandler),
			typeof(GUIItemGrid.CursorOver),
			typeof(GUIItemGrid.DrawItemHandler),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00023C45 File Offset: 0x00021E45
	[global::Cpp2ILInjected.Token(Token = "0x6000C13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6BC0", Offset = "0x9B6BC0", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00023C48 File Offset: 0x00021E48
	[global::Cpp2ILInjected.Token(Token = "0x6000C14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6C44", Offset = "0x9B6C44", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Hotbar_Layout()
	{
		throw null;
	}

	// Token: 0x04000CF2 RID: 3314
	[global::Cpp2ILInjected.Token(Token = "0x40010F5")]
	public static Hotbar_Layout InstanceNormal;

	// Token: 0x04000CF3 RID: 3315
	[global::Cpp2ILInjected.Token(Token = "0x40010F6")]
	public static Hotbar_Layout Instance4Page;

	// Token: 0x04000CF4 RID: 3316
	[global::Cpp2ILInjected.Token(Token = "0x40010F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float SelectedScale;

	// Token: 0x04000CF5 RID: 3317
	[global::Cpp2ILInjected.Token(Token = "0x40010F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float NormalScale;

	// Token: 0x04000CF6 RID: 3318
	[global::Cpp2ILInjected.Token(Token = "0x40010F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ScaleSpeed;

	// Token: 0x04000CF7 RID: 3319
	[global::Cpp2ILInjected.Token(Token = "0x40010FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Title;

	// Token: 0x04000CF8 RID: 3320
	[global::Cpp2ILInjected.Token(Token = "0x40010FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout HorizontalTitle;

	// Token: 0x04000CF9 RID: 3321
	[global::Cpp2ILInjected.Token(Token = "0x40010FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x04000CFA RID: 3322
	[global::Cpp2ILInjected.Token(Token = "0x40010FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HorizontalHotbarGrid;
}
