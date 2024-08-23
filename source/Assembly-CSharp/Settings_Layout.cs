using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001B1 RID: 433
[global::Cpp2ILInjected.Token(Token = "0x2000240")]
public class Settings_Layout : LayoutDefinition
{
	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00023F6C File Offset: 0x0002216C
	[global::Cpp2ILInjected.Token(Token = "0x1700016E")]
	public static Settings_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D27")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D54D8", Offset = "0x9D54D8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "GetIconFrame", MemberParameters = new object[]
		{
			typeof(QuickActionButton_Layout.QuickActionControl),
			typeof(ref Texture2D),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(QuickActionButton_Layout.QuickActionControl),
			typeof(QuickActionButton_Layout),
			typeof(bool),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "DrawHUD", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "PageDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageGroupEdit), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00023F6F File Offset: 0x0002216F
	[global::Cpp2ILInjected.Token(Token = "0x6000D28")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5554", Offset = "0x9D5554", Length = "0x84")]
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

	// Token: 0x06000C0F RID: 3087 RVA: 0x00023F72 File Offset: 0x00022172
	[global::Cpp2ILInjected.Token(Token = "0x6000D29")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D55D8", Offset = "0x9D55D8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Settings_Layout()
	{
		throw null;
	}

	// Token: 0x04001328 RID: 4904
	[global::Cpp2ILInjected.Token(Token = "0x40017DD")]
	public static Settings_Layout InstanceNormal;

	// Token: 0x04001329 RID: 4905
	[global::Cpp2ILInjected.Token(Token = "0x40017DE")]
	public static Settings_Layout Instance4Page;

	// Token: 0x0400132A RID: 4906
	[global::Cpp2ILInjected.Token(Token = "0x40017DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout SettingsButton;

	// Token: 0x0400132B RID: 4907
	[global::Cpp2ILInjected.Token(Token = "0x40017E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SettingsButton_Horizontal;

	// Token: 0x0400132C RID: 4908
	[global::Cpp2ILInjected.Token(Token = "0x40017E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout SettingsButton_Top;

	// Token: 0x0400132D RID: 4909
	[global::Cpp2ILInjected.Token(Token = "0x40017E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout JMSettingsButton;

	// Token: 0x0400132E RID: 4910
	[global::Cpp2ILInjected.Token(Token = "0x40017E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout BestiaryButton;

	// Token: 0x0400132F RID: 4911
	[global::Cpp2ILInjected.Token(Token = "0x40017E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout MapButton;

	// Token: 0x04001330 RID: 4912
	[global::Cpp2ILInjected.Token(Token = "0x40017E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout HousingMenuButton;

	// Token: 0x04001331 RID: 4913
	[global::Cpp2ILInjected.Token(Token = "0x40017E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ChatButton;

	// Token: 0x04001332 RID: 4914
	[global::Cpp2ILInjected.Token(Token = "0x40017E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout EmotesButton;

	// Token: 0x04001333 RID: 4915
	[global::Cpp2ILInjected.Token(Token = "0x40017E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ReturnTouch_HUD;

	// Token: 0x04001334 RID: 4916
	[global::Cpp2ILInjected.Token(Token = "0x40017E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ReturnTouch_Menu;

	// Token: 0x04001335 RID: 4917
	[global::Cpp2ILInjected.Token(Token = "0x40017EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ReturnTouch_Backing;

	// Token: 0x04001336 RID: 4918
	[global::Cpp2ILInjected.Token(Token = "0x40017EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout ReturnTouch_MenuDivider;

	// Token: 0x04001337 RID: 4919
	[global::Cpp2ILInjected.Token(Token = "0x40017EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ReturnTouch_Prompt;

	// Token: 0x04001338 RID: 4920
	[global::Cpp2ILInjected.Token(Token = "0x40017ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ReturnTouch_Accept;

	// Token: 0x04001339 RID: 4921
	[global::Cpp2ILInjected.Token(Token = "0x40017EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout ReturnTouch_Cancel;
}
