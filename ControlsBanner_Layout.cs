using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000145")]
public class ControlsBanner_Layout : LayoutDefinition
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007D9")]
	public class PriorityMappings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BA7")]
		public List<string> Ids;

		[Cpp2IlInjected.Token(Token = "0x6004918")]
		[Cpp2IlInjected.Address(RVA = "0x20C0594", Offset = "0x20C0594", VA = "0x20C0594")]
		public PriorityMappings()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007DA")]
	public class ControlGrouping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BA8")]
		public Vector2 Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007BA9")]
		public Vector2 Right;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007BAA")]
		public Vector2 Up;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007BAB")]
		public Vector2 Down;

		[Cpp2IlInjected.Token(Token = "0x6004919")]
		[Cpp2IlInjected.Address(RVA = "0x20C052C", Offset = "0x20C052C", VA = "0x20C052C")]
		public ControlGrouping()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007DB")]
	public class ControlGroupingPosition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BAC")]
		public ControlAnchor.ControlId AnchorControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007BAD")]
		public LayoutCalculator.AnchorType Anchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007BAE")]
		public Vector2 Location;

		[Cpp2IlInjected.Token(Token = "0x600491A")]
		[Cpp2IlInjected.Address(RVA = "0x20C0534", Offset = "0x20C0534", VA = "0x20C0534")]
		public ControlGroupingPosition()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007DC")]
	public class MenuLayout
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BAF")]
		public TransactionButton_Layout LSIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007BB0")]
		public ControlGroupingPosition LS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007BB1")]
		public TransactionButton_Layout Button1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007BB2")]
		public TransactionButton_Layout Button2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007BB3")]
		public TransactionButton_Layout Button3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007BB4")]
		public TransactionButton_Layout Button4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007BB5")]
		public ControlGroupingPosition Buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007BB6")]
		public TransactionButton_Layout LBIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007BB7")]
		public ControlGroupingPosition LB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007BB8")]
		public TransactionButton_Layout RBIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007BB9")]
		public ControlGroupingPosition RB;

		[Cpp2IlInjected.Token(Token = "0x600491B")]
		[Cpp2IlInjected.Address(RVA = "0x20C058C", Offset = "0x20C058C", VA = "0x20C058C")]
		public MenuLayout()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000B92")]
	public static ControlsBanner_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000B93")]
	public PriorityMappings MappingPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000B94")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000B95")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000B96")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000B97")]
	public bool DebugBannerLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000B98")]
	public ItemGrid_Layout Actions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000B99")]
	public ControlGroupingPosition ActionsWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000B9A")]
	public ItemGrid_Layout LeftInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000B9B")]
	public ControlGroupingPosition LeftInterfaceWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000B9C")]
	public ItemGrid_Layout RightInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000B9D")]
	public ControlGroupingPosition RightInterfaceWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000B9E")]
	public ItemGrid_Layout NPCDialogue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000B9F")]
	public ControlGroupingPosition NPCDialogueWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000BA0")]
	public TransactionButton_Layout ActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000BA1")]
	public TransactionButton_Layout ActionStyleMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000BA2")]
	public Panel_Layout InterfaceBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000BA3")]
	public Vector2 InterfaceBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000BA4")]
	public Vector2 InterfaceBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000BA5")]
	public TransactionButton_Layout InterfaceActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000BA6")]
	public TransactionButton_Layout InterfaceActionStyleMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000BA7")]
	public ItemGrid_Layout LeftActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000BA8")]
	public Panel_Layout LeftActionBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000BA9")]
	public Vector2 LeftActionBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000BAA")]
	public Vector2 LeftActionBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000BAB")]
	public ItemGrid_Layout RightActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000BAC")]
	public Panel_Layout RightActionBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000BAD")]
	public Vector2 RightActionBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000BAE")]
	public Vector2 RightActionBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000BAF")]
	public String_Layout ActionDisplay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000BB0")]
	public String_Layout ActionDisplay2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000BB1")]
	public int ScreenEdgeAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000BB2")]
	public int MaxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000BB3")]
	public TransactionButton_Layout LeftActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000BB4")]
	public TransactionButton_Layout LeftActionStyleMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000BB5")]
	public TransactionButton_Layout RightActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000BB6")]
	public TransactionButton_Layout RightActionStyleMultiple;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000BB7")]
	public String_Layout MoreText;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000BB8")]
	public TransactionButton_Layout LeftMoreButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000BB9")]
	public TransactionButton_Layout RightMoreButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000BBA")]
	public Panel_Layout MoreButtonBacking;

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x20C0340", Offset = "0x20C0340", VA = "0x20C0340")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x20C039C", Offset = "0x20C039C", VA = "0x20C039C")]
	public int GetMappingPriority(string id)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x20C04B0", Offset = "0x20C04B0", VA = "0x20C04B0")]
	public ControlsBanner_Layout()
	{
	}
}
