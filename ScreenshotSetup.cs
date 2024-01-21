using System;
using Controller;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200024E")]
public class ScreenshotSetup
{
	[Cpp2IlInjected.Token(Token = "0x2000810")]
	public enum UIStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4007D66")]
		VirtualControls,
		[Cpp2IlInjected.Token(Token = "0x4007D67")]
		Controller,
		[Cpp2IlInjected.Token(Token = "0x4007D68")]
		None
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001BC8")]
	private RenderTexture _renderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BC9")]
	private Texture2D _tex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BCA")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _emulationEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BCB")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001BCC")]
	public UIStyle Style;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001BCD")]
	public ControllerDevice.ControlScheme ControlScheme;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001BCE")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001BCF")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001BD0")]
	public int DPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001BD1")]
	public Rect SafeRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001BD2")]
	public string OutputPath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001BD3")]
	public string OutputFileStart;

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public RenderTexture RenderTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60010C3")]
		[Cpp2IlInjected.Address(RVA = "0xFA5600", Offset = "0xFA5600", VA = "0xFA5600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public Texture2D SaveTexture
	{
		[Cpp2IlInjected.Token(Token = "0x60010C4")]
		[Cpp2IlInjected.Address(RVA = "0xFA5754", Offset = "0xFA5754", VA = "0xFA5754")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public DeviceVPPICalculator.EditorMobileEmuEntry EmulationEntry
	{
		[Cpp2IlInjected.Token(Token = "0x60010C5")]
		[Cpp2IlInjected.Address(RVA = "0xFA58A4", Offset = "0xFA58A4", VA = "0xFA58A4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010C6")]
	[Cpp2IlInjected.Address(RVA = "0xFA5A8C", Offset = "0xFA5A8C", VA = "0xFA5A8C")]
	public ScreenshotSetup()
	{
	}
}
