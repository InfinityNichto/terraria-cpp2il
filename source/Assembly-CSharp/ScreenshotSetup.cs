using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200024C RID: 588
[global::Cpp2ILInjected.Token(Token = "0x2000306")]
[Serializable]
public class ScreenshotSetup
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x060010AA RID: 4266 RVA: 0x00024CE0 File Offset: 0x00022EE0
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

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x060010AB RID: 4267 RVA: 0x00024CE3 File Offset: 0x00022EE3
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

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x060010AC RID: 4268 RVA: 0x00024CE6 File Offset: 0x00022EE6
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

	// Token: 0x060010AD RID: 4269 RVA: 0x00024CE9 File Offset: 0x00022EE9
	[global::Cpp2ILInjected.Token(Token = "0x60011FE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72448", Offset = "0xA72448", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ScreenshotSetup()
	{
		throw null;
	}

	// Token: 0x04001BBF RID: 7103
	[global::Cpp2ILInjected.Token(Token = "0x4002179")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private RenderTexture _renderTexture;

	// Token: 0x04001BC0 RID: 7104
	[global::Cpp2ILInjected.Token(Token = "0x400217A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Texture2D _tex;

	// Token: 0x04001BC1 RID: 7105
	[global::Cpp2ILInjected.Token(Token = "0x400217B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private DeviceVPPICalculator.EditorMobileEmuEntry _emulationEntry;

	// Token: 0x04001BC2 RID: 7106
	[global::Cpp2ILInjected.Token(Token = "0x400217C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string Id;

	// Token: 0x04001BC3 RID: 7107
	[global::Cpp2ILInjected.Token(Token = "0x400217D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ScreenshotSetup.UIStyle Style;

	// Token: 0x04001BC4 RID: 7108
	[global::Cpp2ILInjected.Token(Token = "0x400217E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public ControllerDevice.ControlScheme ControlScheme;

	// Token: 0x04001BC5 RID: 7109
	[global::Cpp2ILInjected.Token(Token = "0x400217F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int Width;

	// Token: 0x04001BC6 RID: 7110
	[global::Cpp2ILInjected.Token(Token = "0x4002180")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int Height;

	// Token: 0x04001BC7 RID: 7111
	[global::Cpp2ILInjected.Token(Token = "0x4002181")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int DPI;

	// Token: 0x04001BC8 RID: 7112
	[global::Cpp2ILInjected.Token(Token = "0x4002182")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Rect SafeRegion;

	// Token: 0x04001BC9 RID: 7113
	[global::Cpp2ILInjected.Token(Token = "0x4002183")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public string OutputPath;

	// Token: 0x04001BCA RID: 7114
	[global::Cpp2ILInjected.Token(Token = "0x4002184")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public string OutputFileStart;

	// Token: 0x02000819 RID: 2073
	[global::Cpp2ILInjected.Token(Token = "0x2000307")]
	public enum UIStyle
	{
		// Token: 0x04007D79 RID: 32121
		[global::Cpp2ILInjected.Token(Token = "0x4002186")]
		VirtualControls,
		// Token: 0x04007D7A RID: 32122
		[global::Cpp2ILInjected.Token(Token = "0x4002187")]
		Controller,
		// Token: 0x04007D7B RID: 32123
		[global::Cpp2ILInjected.Token(Token = "0x4002188")]
		None
	}
}
