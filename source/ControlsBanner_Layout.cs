using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001C5")]
public class ControlsBanner_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BEB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5244", Offset = "0x9B5244", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BEC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5290", Offset = "0x9B5290", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "CreateVectorMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ControllerActionAxis),
		typeof(ControllerActionAxis)
	}, ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public int GetMappingPriority(string id)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BED")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B53F0", Offset = "0x9B53F0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControlsBanner_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000F79")]
	public static ControlsBanner_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlsBanner_Layout.PriorityMappings MappingPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Vector2 BackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Vector2 BackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool DebugBannerLength;

	[global::Cpp2ILInjected.Token(Token = "0x4000F7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout Actions;

	[global::Cpp2ILInjected.Token(Token = "0x4000F80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControlsBanner_Layout.ControlGroupingPosition ActionsWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000F81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout LeftInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4000F82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ControlsBanner_Layout.ControlGroupingPosition LeftInterfaceWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000F83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout RightInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4000F84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControlsBanner_Layout.ControlGroupingPosition RightInterfaceWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000F85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout NPCDialogue;

	[global::Cpp2ILInjected.Token(Token = "0x4000F86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControlsBanner_Layout.ControlGroupingPosition NPCDialogueWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000F87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4000F88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ActionStyleMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000F89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout InterfaceBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Microsoft.Xna.Framework.Vector2 InterfaceBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Microsoft.Xna.Framework.Vector2 InterfaceBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout InterfaceActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout InterfaceActionStyleMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ItemGrid_Layout LeftActions;

	[global::Cpp2ILInjected.Token(Token = "0x4000F8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout LeftActionBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000F90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Microsoft.Xna.Framework.Vector2 LeftActionBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Microsoft.Xna.Framework.Vector2 LeftActionBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public ItemGrid_Layout RightActions;

	[global::Cpp2ILInjected.Token(Token = "0x4000F93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout RightActionBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000F94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Microsoft.Xna.Framework.Vector2 RightActionBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Microsoft.Xna.Framework.Vector2 RightActionBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000F96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public String_Layout ActionDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4000F97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout ActionDisplay2;

	[global::Cpp2ILInjected.Token(Token = "0x4000F98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public int ScreenEdgeAmount;

	[global::Cpp2ILInjected.Token(Token = "0x4000F99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public int MaxWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout LeftActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout LeftActionStyleMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout RightActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout RightActionStyleMultiple;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout MoreText;

	[global::Cpp2ILInjected.Token(Token = "0x4000F9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout LeftMoreButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000FA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout RightMoreButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000FA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout MoreButtonBacking;

	[global::Cpp2ILInjected.Token(Token = "0x20001C6")]
	[Serializable]
	public class PriorityMappings
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5448", Offset = "0x9B5448", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PriorityMappings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<string> Ids;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001C7")]
	[Serializable]
	public class ControlGrouping
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B54C4", Offset = "0x9B54C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControlGrouping()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Microsoft.Xna.Framework.Vector2 Left;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Microsoft.Xna.Framework.Vector2 Right;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Microsoft.Xna.Framework.Vector2 Up;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Microsoft.Xna.Framework.Vector2 Down;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001C8")]
	[Serializable]
	public class ControlGroupingPosition
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B54CC", Offset = "0x9B54CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControlGroupingPosition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControlAnchor.ControlId AnchorControl;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public LayoutCalculator.AnchorType Anchor;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Microsoft.Xna.Framework.Vector2 Location;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001C9")]
	[Serializable]
	public class MenuLayout
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5518", Offset = "0x9B5518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MenuLayout()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000FAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TransactionButton_Layout LSIcon;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControlsBanner_Layout.ControlGroupingPosition LS;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TransactionButton_Layout Button1;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout Button2;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TransactionButton_Layout Button3;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TransactionButton_Layout Button4;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public ControlsBanner_Layout.ControlGroupingPosition Buttons;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout LBIcon;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public ControlsBanner_Layout.ControlGroupingPosition LB;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TransactionButton_Layout RBIcon;

		[global::Cpp2ILInjected.Token(Token = "0x4000FB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public ControlsBanner_Layout.ControlGroupingPosition RB;
	}
}
