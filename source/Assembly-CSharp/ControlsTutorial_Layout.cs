using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000147 RID: 327
[global::Cpp2ILInjected.Token(Token = "0x20001CC")]
public class ControlsTutorial_Layout : LayoutDefinition
{
	// Token: 0x06000AE2 RID: 2786 RVA: 0x00023BEB File Offset: 0x00021DEB
	[global::Cpp2ILInjected.Token(Token = "0x6000BF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B55CC", Offset = "0x9B55CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00023BEE File Offset: 0x00021DEE
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

	// Token: 0x04000BB9 RID: 3001
	[global::Cpp2ILInjected.Token(Token = "0x4000FBC")]
	public static ControlsTutorial_Layout Instance;

	// Token: 0x04000BBA RID: 3002
	[global::Cpp2ILInjected.Token(Token = "0x4000FBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float TooltipTime;

	// Token: 0x04000BBB RID: 3003
	[global::Cpp2ILInjected.Token(Token = "0x4000FBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float TooltipFadeTime;

	// Token: 0x04000BBC RID: 3004
	[global::Cpp2ILInjected.Token(Token = "0x4000FBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MaximumTooltipWidth;

	// Token: 0x04000BBD RID: 3005
	[global::Cpp2ILInjected.Token(Token = "0x4000FC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int InteractPriority;

	// Token: 0x04000BBE RID: 3006
	[global::Cpp2ILInjected.Token(Token = "0x4000FC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int AutoSelectPriority;

	// Token: 0x04000BBF RID: 3007
	[global::Cpp2ILInjected.Token(Token = "0x4000FC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int AutoFirePriority;

	// Token: 0x04000BC0 RID: 3008
	[global::Cpp2ILInjected.Token(Token = "0x4000FC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int QuickHealPriority;

	// Token: 0x04000BC1 RID: 3009
	[global::Cpp2ILInjected.Token(Token = "0x4000FC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int QuickManaPriority;

	// Token: 0x04000BC2 RID: 3010
	[global::Cpp2ILInjected.Token(Token = "0x4000FC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int QuickBuffPriority;

	// Token: 0x04000BC3 RID: 3011
	[global::Cpp2ILInjected.Token(Token = "0x4000FC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int InventoryTogglePriority;

	// Token: 0x04000BC4 RID: 3012
	[global::Cpp2ILInjected.Token(Token = "0x4000FC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int ZoomOutPriority;

	// Token: 0x04000BC5 RID: 3013
	[global::Cpp2ILInjected.Token(Token = "0x4000FC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int MovementAxisPriority;

	// Token: 0x04000BC6 RID: 3014
	[global::Cpp2ILInjected.Token(Token = "0x4000FC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControlAnchor.ControlId LeftAnchorControl;

	// Token: 0x04000BC7 RID: 3015
	[global::Cpp2ILInjected.Token(Token = "0x4000FCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public LayoutCalculator.AnchorType LeftAnchor;

	// Token: 0x04000BC8 RID: 3016
	[global::Cpp2ILInjected.Token(Token = "0x4000FCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Vector2 LeftLocation;

	// Token: 0x04000BC9 RID: 3017
	[global::Cpp2ILInjected.Token(Token = "0x4000FCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int FirePriority;

	// Token: 0x04000BCA RID: 3018
	[global::Cpp2ILInjected.Token(Token = "0x4000FCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public int TargetLockOnPriority;

	// Token: 0x04000BCB RID: 3019
	[global::Cpp2ILInjected.Token(Token = "0x4000FCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int SmartCursorPriority;

	// Token: 0x04000BCC RID: 3020
	[global::Cpp2ILInjected.Token(Token = "0x4000FCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int JumpPriority;

	// Token: 0x04000BCD RID: 3021
	[global::Cpp2ILInjected.Token(Token = "0x4000FD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int QuickMountPriority;

	// Token: 0x04000BCE RID: 3022
	[global::Cpp2ILInjected.Token(Token = "0x4000FD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public int ZoomInPriority;

	// Token: 0x04000BCF RID: 3023
	[global::Cpp2ILInjected.Token(Token = "0x4000FD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int FireAxisPriority;

	// Token: 0x04000BD0 RID: 3024
	[global::Cpp2ILInjected.Token(Token = "0x4000FD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public int GrappleAxisPriority;

	// Token: 0x04000BD1 RID: 3025
	[global::Cpp2ILInjected.Token(Token = "0x4000FD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public int ProfileSwitchPriority;

	// Token: 0x04000BD2 RID: 3026
	[global::Cpp2ILInjected.Token(Token = "0x4000FD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public ControlAnchor.ControlId RightAnchorControl;

	// Token: 0x04000BD3 RID: 3027
	[global::Cpp2ILInjected.Token(Token = "0x4000FD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public LayoutCalculator.AnchorType RightAnchor;

	// Token: 0x04000BD4 RID: 3028
	[global::Cpp2ILInjected.Token(Token = "0x4000FD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public Vector2 RightLocation;

	// Token: 0x04000BD5 RID: 3029
	[global::Cpp2ILInjected.Token(Token = "0x4000FD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout TutorialButton;

	// Token: 0x04000BD6 RID: 3030
	[global::Cpp2ILInjected.Token(Token = "0x4000FD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout TutorialButtonOpen;

	// Token: 0x04000BD7 RID: 3031
	[global::Cpp2ILInjected.Token(Token = "0x4000FDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ControlAnchor.ControlId ToggleAnchorControl;

	// Token: 0x04000BD8 RID: 3032
	[global::Cpp2ILInjected.Token(Token = "0x4000FDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public LayoutCalculator.AnchorType ToggleAnchor;

	// Token: 0x04000BD9 RID: 3033
	[global::Cpp2ILInjected.Token(Token = "0x4000FDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Vector2 ToggleLocation;

	// Token: 0x04000BDA RID: 3034
	[global::Cpp2ILInjected.Token(Token = "0x4000FDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout TitleFormat;

	// Token: 0x04000BDB RID: 3035
	[global::Cpp2ILInjected.Token(Token = "0x4000FDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ControlAnchor.ControlId MenuAnchorControl;

	// Token: 0x04000BDC RID: 3036
	[global::Cpp2ILInjected.Token(Token = "0x4000FDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public LayoutCalculator.AnchorType MenuAnchor;

	// Token: 0x04000BDD RID: 3037
	[global::Cpp2ILInjected.Token(Token = "0x4000FE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Vector2 MenuLocation;

	// Token: 0x04000BDE RID: 3038
	[global::Cpp2ILInjected.Token(Token = "0x4000FE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Vector2 MenuTopLocation;

	// Token: 0x04000BDF RID: 3039
	[global::Cpp2ILInjected.Token(Token = "0x4000FE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Vector2 MenuBottomLocation;
}
