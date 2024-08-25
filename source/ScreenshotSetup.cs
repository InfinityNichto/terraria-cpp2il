using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000306")]
[Serializable]
public class ScreenshotSetup
{
	[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
	public RenderTexture RenderTexture
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA720A4", Offset = "0xA720A4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Destroy", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(RenderTextureFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
	public Texture2D SaveTexture
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA721B8", Offset = "0xA721B8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Destroy", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TextureFormat),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
	public DeviceVPPICalculator.EditorMobileEmuEntry EmulationEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA722CC", Offset = "0xA722CC", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator.EditorMobileEmuEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60011FE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72448", Offset = "0xA72448", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ScreenshotSetup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002179")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private RenderTexture _renderTexture;

	[global::Cpp2ILInjected.Token(Token = "0x400217A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Texture2D _tex;

	[global::Cpp2ILInjected.Token(Token = "0x400217B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _emulationEntry;

	[global::Cpp2ILInjected.Token(Token = "0x400217C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string Id;

	[global::Cpp2ILInjected.Token(Token = "0x400217D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ScreenshotSetup.UIStyle Style;

	[global::Cpp2ILInjected.Token(Token = "0x400217E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public ControllerDevice.ControlScheme ControlScheme;

	[global::Cpp2ILInjected.Token(Token = "0x400217F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int Width;

	[global::Cpp2ILInjected.Token(Token = "0x4002180")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int Height;

	[global::Cpp2ILInjected.Token(Token = "0x4002181")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int DPI;

	[global::Cpp2ILInjected.Token(Token = "0x4002182")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Rect SafeRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4002183")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public string OutputPath;

	[global::Cpp2ILInjected.Token(Token = "0x4002184")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public string OutputFileStart;

	[global::Cpp2ILInjected.Token(Token = "0x2000307")]
	public enum UIStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x4002186")]
		VirtualControls,
		[global::Cpp2ILInjected.Token(Token = "0x4002187")]
		Controller,
		[global::Cpp2ILInjected.Token(Token = "0x4002188")]
		None
	}
}
