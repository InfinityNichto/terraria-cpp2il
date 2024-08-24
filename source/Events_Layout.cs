using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200014F RID: 335
[global::Cpp2ILInjected.Token(Token = "0x20001D4")]
public class Events_Layout : LayoutDefinition
{
	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00023C2A File Offset: 0x00021E2A
	[global::Cpp2ILInjected.Token(Token = "0x17000151")]
	public static Events_Layout Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B65FC", Offset = "0x9B65FC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEvents), Member = "DrawInvasionInfo", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(string),
			typeof(string),
			typeof(Texture2D),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEvents), Member = "DrawProgressBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEvents), Member = "DrawInfiniteProgressBar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00023C2D File Offset: 0x00021E2D
	[global::Cpp2ILInjected.Token(Token = "0x6000C0B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B667C", Offset = "0x9B667C", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00023C30 File Offset: 0x00021E30
	[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6700", Offset = "0x9B6700", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Events_Layout()
	{
		throw null;
	}

	// Token: 0x04000CAF RID: 3247
	[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
	public static Events_Layout _instance;

	// Token: 0x04000CB0 RID: 3248
	[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
	public static Events_Layout _instanceMobile;

	// Token: 0x04000CB1 RID: 3249
	[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000CB2 RID: 3250
	[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InvasionTitle;

	// Token: 0x04000CB3 RID: 3251
	[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout InvasionIcon;

	// Token: 0x04000CB4 RID: 3252
	[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout BarBacking;

	// Token: 0x04000CB5 RID: 3253
	[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout BarFill;

	// Token: 0x04000CB6 RID: 3254
	[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout InfiniteBarBacking;

	// Token: 0x04000CB7 RID: 3255
	[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout InfiniteBarFill;

	// Token: 0x04000CB8 RID: 3256
	[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout Waves;

	// Token: 0x04000CB9 RID: 3257
	[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color MaxWaveColour;

	// Token: 0x04000CBA RID: 3258
	[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout Progress;
}
