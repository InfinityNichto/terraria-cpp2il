using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000240")]
public class Settings_Layout : LayoutDefinition
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000D29")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D55D8", Offset = "0x9D55D8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Settings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40017DD")]
	public static Settings_Layout InstanceNormal;

	[global::Cpp2ILInjected.Token(Token = "0x40017DE")]
	public static Settings_Layout Instance4Page;

	[global::Cpp2ILInjected.Token(Token = "0x40017DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout SettingsButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout SettingsButton_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x40017E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout SettingsButton_Top;

	[global::Cpp2ILInjected.Token(Token = "0x40017E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout JMSettingsButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout BestiaryButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout MapButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout HousingMenuButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ChatButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout EmotesButton;

	[global::Cpp2ILInjected.Token(Token = "0x40017E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ReturnTouch_HUD;

	[global::Cpp2ILInjected.Token(Token = "0x40017E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ReturnTouch_Menu;

	[global::Cpp2ILInjected.Token(Token = "0x40017EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ReturnTouch_Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40017EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout ReturnTouch_MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40017EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ReturnTouch_Prompt;

	[global::Cpp2ILInjected.Token(Token = "0x40017ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ReturnTouch_Accept;

	[global::Cpp2ILInjected.Token(Token = "0x40017EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout ReturnTouch_Cancel;
}
