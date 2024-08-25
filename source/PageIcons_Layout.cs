using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200022D")]
public class PageIcons_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CF2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D12F8", Offset = "0x9D12F8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1344", Offset = "0x9D1344", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PageIcons_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001633")]
	public static PageIcons_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001634")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Stretched_Layout Backing1;

	[global::Cpp2ILInjected.Token(Token = "0x4001635")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Stretched_Layout Backing1Pressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001636")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Stretched_Layout Backing2;

	[global::Cpp2ILInjected.Token(Token = "0x4001637")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Stretched_Layout Backing2Pressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001638")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout LeftItems;

	[global::Cpp2ILInjected.Token(Token = "0x4001639")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout RightItems;

	[global::Cpp2ILInjected.Token(Token = "0x400163A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Stretched_Layout Backing1_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400163B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Stretched_Layout Backing1_HorizontalPressed;

	[global::Cpp2ILInjected.Token(Token = "0x400163C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Stretched_Layout Backing2_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400163D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Stretched_Layout Backing2_HorizontalPressed;

	[global::Cpp2ILInjected.Token(Token = "0x400163E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ItemGrid_Layout LeftItems_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400163F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout RightItems_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001640")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ItemGrid_Layout LeftItems_Controller;

	[global::Cpp2ILInjected.Token(Token = "0x4001641")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout RightItems_Controller;

	[global::Cpp2ILInjected.Token(Token = "0x4001642")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public ItemGrid_Layout LeftItems_MouseKeyboard;

	[global::Cpp2ILInjected.Token(Token = "0x4001643")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public ItemGrid_Layout RightItems_MouseKeyboard;

	[global::Cpp2ILInjected.Token(Token = "0x4001644")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Stretched_Layout Backing1_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001645")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Stretched_Layout Backing1_TopPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001646")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Stretched_Layout Backing2_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001647")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Stretched_Layout Backing2_TopPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001648")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ItemGrid_Layout LeftItems_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001649")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public ItemGrid_Layout RightItems_Top;

	[global::Cpp2ILInjected.Token(Token = "0x400164A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400164B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400164C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public float ScaleSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x400164D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout LeftMenuButton;

	[global::Cpp2ILInjected.Token(Token = "0x400164E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout LeftMenuButton_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x400164F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout LeftMenuButton_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001650")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public AnimationCurve ItemDragPulseScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001651")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public String_Layout LeftPageTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001652")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout LeftPageTitle_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001653")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout LeftPageTitle_Bottom;

	[global::Cpp2ILInjected.Token(Token = "0x4001654")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout RightPageTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001655")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public String_Layout RightPageTitle_Top;

	[global::Cpp2ILInjected.Token(Token = "0x4001656")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public String_Layout RightPageTitle_Bottom;

	[global::Cpp2ILInjected.Token(Token = "0x4001657")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout LeftOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001658")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout LeftOptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001659")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Microsoft.Xna.Framework.Vector2 LeftOptionsBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400165A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Microsoft.Xna.Framework.Vector2 LeftOptionsBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x400165B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x400165C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public ControlAnchor.ControlId LeftGlobalOptionPositionAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x400165D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	public LayoutCalculator.AnchorType LeftGlobalOptionPositionAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x400165E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Microsoft.Xna.Framework.Vector2 LeftGlobalOptionPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400165F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public Microsoft.Xna.Framework.Vector2 LeftGlobalOptionSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4001660")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public ControlAnchor.ControlId LeftOptionPositionAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001661")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
	public LayoutCalculator.AnchorType LeftOptionPositionAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001662")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Microsoft.Xna.Framework.Vector2 LeftOptionPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001663")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Microsoft.Xna.Framework.Vector2 LeftOptionSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4001664")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public Microsoft.Xna.Framework.Vector2 LeftMenuTextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001665")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Microsoft.Xna.Framework.Vector2 LeftTextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001666")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout RightOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001667")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Panel_Layout RightOptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001668")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Panel_Layout RightOptionsBackingChest;

	[global::Cpp2ILInjected.Token(Token = "0x4001669")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Panel_Layout RightOptionsBackingShop;

	[global::Cpp2ILInjected.Token(Token = "0x400166A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Panel_Layout RightOptionsBackingEquipment;

	[global::Cpp2ILInjected.Token(Token = "0x400166B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public Microsoft.Xna.Framework.Vector2 RightOptionsBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400166C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Microsoft.Xna.Framework.Vector2 RightOptionsBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x400166D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public ControlAnchor.ControlId RightGlobalOptionPositionAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x400166E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
	public LayoutCalculator.AnchorType RightGlobalOptionPositionAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x400166F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public Microsoft.Xna.Framework.Vector2 RightGlobalOptionPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001670")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public Microsoft.Xna.Framework.Vector2 RightGlobalOptionSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4001671")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public ControlAnchor.ControlId RightOptionPositionAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001672")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E4")]
	public LayoutCalculator.AnchorType RightOptionPositionAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001673")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Microsoft.Xna.Framework.Vector2 RightOptionPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001674")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public Microsoft.Xna.Framework.Vector2 RightOptionSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4001675")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Microsoft.Xna.Framework.Vector2 RightMenuTextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001676")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public Microsoft.Xna.Framework.Vector2 RightTextOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001677")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public AnimatedTexture_Layout LeftMenuTimer;

	[global::Cpp2ILInjected.Token(Token = "0x4001678")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public AnimatedTexture_Layout RightMenuTimer;
}
