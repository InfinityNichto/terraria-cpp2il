using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001CC")]
public class ControlsTutorial_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000BF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B55CC", Offset = "0x9B55CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000BF6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5618", Offset = "0x9B5618", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControlsTutorial_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000FBC")]
	public static ControlsTutorial_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000FBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float TooltipTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000FBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float TooltipFadeTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000FBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MaximumTooltipWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int InteractPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int AutoSelectPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int AutoFirePriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int QuickHealPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int QuickManaPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int QuickBuffPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int InventoryTogglePriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int ZoomOutPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int MovementAxisPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControlAnchor.ControlId LeftAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public LayoutCalculator.AnchorType LeftAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 LeftLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int FirePriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int TargetLockOnPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int SmartCursorPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int JumpPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int QuickMountPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public int ZoomInPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int FireAxisPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public int GrappleAxisPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public int ProfileSwitchPriority;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public ControlAnchor.ControlId RightAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public LayoutCalculator.AnchorType RightAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public Vector2 RightLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout TutorialButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000FD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout TutorialButtonOpen;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ControlAnchor.ControlId ToggleAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public LayoutCalculator.AnchorType ToggleAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Vector2 ToggleLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout TitleFormat;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ControlAnchor.ControlId MenuAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000FDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public LayoutCalculator.AnchorType MenuAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Vector2 MenuLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Vector2 MenuTopLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000FE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Vector2 MenuBottomLocation;
}
