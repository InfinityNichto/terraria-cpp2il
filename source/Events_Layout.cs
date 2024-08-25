using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001D4")]
public class Events_Layout : LayoutDefinition
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6700", Offset = "0x9B6700", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Events_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
	public static Events_Layout _instance;

	[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
	public static Events_Layout _instanceMobile;

	[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InvasionTitle;

	[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout InvasionIcon;

	[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout BarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout BarFill;

	[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout InfiniteBarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout InfiniteBarFill;

	[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout Waves;

	[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color MaxWaveColour;

	[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout Progress;
}
