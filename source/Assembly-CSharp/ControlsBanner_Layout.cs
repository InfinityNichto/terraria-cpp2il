using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using UnityEngine;

// Token: 0x02000144 RID: 324
[global::Cpp2ILInjected.Token(Token = "0x20001C5")]
public class ControlsBanner_Layout : LayoutDefinition
{
	// Token: 0x06000ADC RID: 2780 RVA: 0x00023BD9 File Offset: 0x00021DD9
	[global::Cpp2ILInjected.Token(Token = "0x6000BEB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5244", Offset = "0x9B5244", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00023BDC File Offset: 0x00021DDC
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

	// Token: 0x06000ADE RID: 2782 RVA: 0x00023BDF File Offset: 0x00021DDF
	[global::Cpp2ILInjected.Token(Token = "0x6000BED")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B53F0", Offset = "0x9B53F0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControlsBanner_Layout()
	{
		throw null;
	}

	// Token: 0x04000B89 RID: 2953
	[global::Cpp2ILInjected.Token(Token = "0x4000F79")]
	public static ControlsBanner_Layout Instance;

	// Token: 0x04000B8A RID: 2954
	[global::Cpp2ILInjected.Token(Token = "0x4000F7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControlsBanner_Layout.PriorityMappings MappingPriority;

	// Token: 0x04000B8B RID: 2955
	[global::Cpp2ILInjected.Token(Token = "0x4000F7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000B8C RID: 2956
	[global::Cpp2ILInjected.Token(Token = "0x4000F7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Vector2 BackingTLOffset;

	// Token: 0x04000B8D RID: 2957
	[global::Cpp2ILInjected.Token(Token = "0x4000F7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Vector2 BackingBROffset;

	// Token: 0x04000B8E RID: 2958
	[global::Cpp2ILInjected.Token(Token = "0x4000F7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool DebugBannerLength;

	// Token: 0x04000B8F RID: 2959
	[global::Cpp2ILInjected.Token(Token = "0x4000F7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout Actions;

	// Token: 0x04000B90 RID: 2960
	[global::Cpp2ILInjected.Token(Token = "0x4000F80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControlsBanner_Layout.ControlGroupingPosition ActionsWidth;

	// Token: 0x04000B91 RID: 2961
	[global::Cpp2ILInjected.Token(Token = "0x4000F81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout LeftInterface;

	// Token: 0x04000B92 RID: 2962
	[global::Cpp2ILInjected.Token(Token = "0x4000F82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ControlsBanner_Layout.ControlGroupingPosition LeftInterfaceWidth;

	// Token: 0x04000B93 RID: 2963
	[global::Cpp2ILInjected.Token(Token = "0x4000F83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout RightInterface;

	// Token: 0x04000B94 RID: 2964
	[global::Cpp2ILInjected.Token(Token = "0x4000F84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControlsBanner_Layout.ControlGroupingPosition RightInterfaceWidth;

	// Token: 0x04000B95 RID: 2965
	[global::Cpp2ILInjected.Token(Token = "0x4000F85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout NPCDialogue;

	// Token: 0x04000B96 RID: 2966
	[global::Cpp2ILInjected.Token(Token = "0x4000F86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControlsBanner_Layout.ControlGroupingPosition NPCDialogueWidth;

	// Token: 0x04000B97 RID: 2967
	[global::Cpp2ILInjected.Token(Token = "0x4000F87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ActionStyle;

	// Token: 0x04000B98 RID: 2968
	[global::Cpp2ILInjected.Token(Token = "0x4000F88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ActionStyleMultiple;

	// Token: 0x04000B99 RID: 2969
	[global::Cpp2ILInjected.Token(Token = "0x4000F89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout InterfaceBacking;

	// Token: 0x04000B9A RID: 2970
	[global::Cpp2ILInjected.Token(Token = "0x4000F8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Microsoft.Xna.Framework.Vector2 InterfaceBackingTLOffset;

	// Token: 0x04000B9B RID: 2971
	[global::Cpp2ILInjected.Token(Token = "0x4000F8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Microsoft.Xna.Framework.Vector2 InterfaceBackingBROffset;

	// Token: 0x04000B9C RID: 2972
	[global::Cpp2ILInjected.Token(Token = "0x4000F8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout InterfaceActionStyle;

	// Token: 0x04000B9D RID: 2973
	[global::Cpp2ILInjected.Token(Token = "0x4000F8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout InterfaceActionStyleMultiple;

	// Token: 0x04000B9E RID: 2974
	[global::Cpp2ILInjected.Token(Token = "0x4000F8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ItemGrid_Layout LeftActions;

	// Token: 0x04000B9F RID: 2975
	[global::Cpp2ILInjected.Token(Token = "0x4000F8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout LeftActionBacking;

	// Token: 0x04000BA0 RID: 2976
	[global::Cpp2ILInjected.Token(Token = "0x4000F90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Microsoft.Xna.Framework.Vector2 LeftActionBackingTLOffset;

	// Token: 0x04000BA1 RID: 2977
	[global::Cpp2ILInjected.Token(Token = "0x4000F91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Microsoft.Xna.Framework.Vector2 LeftActionBackingBROffset;

	// Token: 0x04000BA2 RID: 2978
	[global::Cpp2ILInjected.Token(Token = "0x4000F92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public ItemGrid_Layout RightActions;

	// Token: 0x04000BA3 RID: 2979
	[global::Cpp2ILInjected.Token(Token = "0x4000F93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout RightActionBacking;

	// Token: 0x04000BA4 RID: 2980
	[global::Cpp2ILInjected.Token(Token = "0x4000F94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Microsoft.Xna.Framework.Vector2 RightActionBackingTLOffset;

	// Token: 0x04000BA5 RID: 2981
	[global::Cpp2ILInjected.Token(Token = "0x4000F95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Microsoft.Xna.Framework.Vector2 RightActionBackingBROffset;

	// Token: 0x04000BA6 RID: 2982
	[global::Cpp2ILInjected.Token(Token = "0x4000F96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public String_Layout ActionDisplay;

	// Token: 0x04000BA7 RID: 2983
	[global::Cpp2ILInjected.Token(Token = "0x4000F97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout ActionDisplay2;

	// Token: 0x04000BA8 RID: 2984
	[global::Cpp2ILInjected.Token(Token = "0x4000F98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public int ScreenEdgeAmount;

	// Token: 0x04000BA9 RID: 2985
	[global::Cpp2ILInjected.Token(Token = "0x4000F99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public int MaxWidth;

	// Token: 0x04000BAA RID: 2986
	[global::Cpp2ILInjected.Token(Token = "0x4000F9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout LeftActionStyle;

	// Token: 0x04000BAB RID: 2987
	[global::Cpp2ILInjected.Token(Token = "0x4000F9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout LeftActionStyleMultiple;

	// Token: 0x04000BAC RID: 2988
	[global::Cpp2ILInjected.Token(Token = "0x4000F9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout RightActionStyle;

	// Token: 0x04000BAD RID: 2989
	[global::Cpp2ILInjected.Token(Token = "0x4000F9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout RightActionStyleMultiple;

	// Token: 0x04000BAE RID: 2990
	[global::Cpp2ILInjected.Token(Token = "0x4000F9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout MoreText;

	// Token: 0x04000BAF RID: 2991
	[global::Cpp2ILInjected.Token(Token = "0x4000F9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout LeftMoreButton;

	// Token: 0x04000BB0 RID: 2992
	[global::Cpp2ILInjected.Token(Token = "0x4000FA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout RightMoreButton;

	// Token: 0x04000BB1 RID: 2993
	[global::Cpp2ILInjected.Token(Token = "0x4000FA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout MoreButtonBacking;

	// Token: 0x020007E2 RID: 2018
	[global::Cpp2ILInjected.Token(Token = "0x20001C6")]
	[Serializable]
	public class PriorityMappings
	{
		// Token: 0x060048E2 RID: 18658 RVA: 0x0002EEFB File Offset: 0x0002D0FB
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

		// Token: 0x04007BBA RID: 31674
		[global::Cpp2ILInjected.Token(Token = "0x4000FA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<string> Ids;
	}

	// Token: 0x020007E3 RID: 2019
	[global::Cpp2ILInjected.Token(Token = "0x20001C7")]
	[Serializable]
	public class ControlGrouping
	{
		// Token: 0x060048E3 RID: 18659 RVA: 0x0002EEFE File Offset: 0x0002D0FE
		[global::Cpp2ILInjected.Token(Token = "0x6000BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B54C4", Offset = "0x9B54C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControlGrouping()
		{
			throw null;
		}

		// Token: 0x04007BBB RID: 31675
		[global::Cpp2ILInjected.Token(Token = "0x4000FA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Microsoft.Xna.Framework.Vector2 Left;

		// Token: 0x04007BBC RID: 31676
		[global::Cpp2ILInjected.Token(Token = "0x4000FA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Microsoft.Xna.Framework.Vector2 Right;

		// Token: 0x04007BBD RID: 31677
		[global::Cpp2ILInjected.Token(Token = "0x4000FA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Microsoft.Xna.Framework.Vector2 Up;

		// Token: 0x04007BBE RID: 31678
		[global::Cpp2ILInjected.Token(Token = "0x4000FA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Microsoft.Xna.Framework.Vector2 Down;
	}

	// Token: 0x020007E4 RID: 2020
	[global::Cpp2ILInjected.Token(Token = "0x20001C8")]
	[Serializable]
	public class ControlGroupingPosition
	{
		// Token: 0x060048E4 RID: 18660 RVA: 0x0002EF01 File Offset: 0x0002D101
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

		// Token: 0x04007BBF RID: 31679
		[global::Cpp2ILInjected.Token(Token = "0x4000FA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControlAnchor.ControlId AnchorControl;

		// Token: 0x04007BC0 RID: 31680
		[global::Cpp2ILInjected.Token(Token = "0x4000FA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public LayoutCalculator.AnchorType Anchor;

		// Token: 0x04007BC1 RID: 31681
		[global::Cpp2ILInjected.Token(Token = "0x4000FA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Microsoft.Xna.Framework.Vector2 Location;
	}

	// Token: 0x020007E5 RID: 2021
	[global::Cpp2ILInjected.Token(Token = "0x20001C9")]
	[Serializable]
	public class MenuLayout
	{
		// Token: 0x060048E5 RID: 18661 RVA: 0x0002EF04 File Offset: 0x0002D104
		[global::Cpp2ILInjected.Token(Token = "0x6000BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5518", Offset = "0x9B5518", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MenuLayout()
		{
			throw null;
		}

		// Token: 0x04007BC2 RID: 31682
		[global::Cpp2ILInjected.Token(Token = "0x4000FAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TransactionButton_Layout LSIcon;

		// Token: 0x04007BC3 RID: 31683
		[global::Cpp2ILInjected.Token(Token = "0x4000FAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControlsBanner_Layout.ControlGroupingPosition LS;

		// Token: 0x04007BC4 RID: 31684
		[global::Cpp2ILInjected.Token(Token = "0x4000FAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TransactionButton_Layout Button1;

		// Token: 0x04007BC5 RID: 31685
		[global::Cpp2ILInjected.Token(Token = "0x4000FAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout Button2;

		// Token: 0x04007BC6 RID: 31686
		[global::Cpp2ILInjected.Token(Token = "0x4000FAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public TransactionButton_Layout Button3;

		// Token: 0x04007BC7 RID: 31687
		[global::Cpp2ILInjected.Token(Token = "0x4000FAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TransactionButton_Layout Button4;

		// Token: 0x04007BC8 RID: 31688
		[global::Cpp2ILInjected.Token(Token = "0x4000FB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public ControlsBanner_Layout.ControlGroupingPosition Buttons;

		// Token: 0x04007BC9 RID: 31689
		[global::Cpp2ILInjected.Token(Token = "0x4000FB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout LBIcon;

		// Token: 0x04007BCA RID: 31690
		[global::Cpp2ILInjected.Token(Token = "0x4000FB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public ControlsBanner_Layout.ControlGroupingPosition LB;

		// Token: 0x04007BCB RID: 31691
		[global::Cpp2ILInjected.Token(Token = "0x4000FB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TransactionButton_Layout RBIcon;

		// Token: 0x04007BCC RID: 31692
		[global::Cpp2ILInjected.Token(Token = "0x4000FB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public ControlsBanner_Layout.ControlGroupingPosition RB;
	}
}
