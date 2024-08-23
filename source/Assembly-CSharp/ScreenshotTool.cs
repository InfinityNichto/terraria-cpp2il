using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200024D RID: 589
[global::Cpp2ILInjected.Token(Token = "0x2000308")]
public class ScreenshotTool : MonoBehaviour
{
	// Token: 0x17000185 RID: 389
	// (get) Token: 0x060010AE RID: 4270 RVA: 0x00024CEC File Offset: 0x00022EEC
	// (set) Token: 0x060010AF RID: 4271 RVA: 0x00024CEF File Offset: 0x00022EEF
	[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
	public bool UseControllerInput
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72458", Offset = "0xA72458", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001200")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72460", Offset = "0xA72460", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00024CF2 File Offset: 0x00022EF2
	[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
	public bool TakeScreenShotThisFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001201")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7246C", Offset = "0xA7246C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00024CF5 File Offset: 0x00022EF5
	[global::Cpp2ILInjected.Token(Token = "0x6001202")]
	[global::Cpp2ILInjected.Address(RVA = "0xA724EC", Offset = "0xA724EC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00024CF8 File Offset: 0x00022EF8
	// (set) Token: 0x060010B3 RID: 4275 RVA: 0x00024CFB File Offset: 0x00022EFB
	[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
	public ScreenshotSetup ActiveScreenshot
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001203")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72538", Offset = "0xA72538", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001204")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72540", Offset = "0xA72540", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00024CFE File Offset: 0x00022EFE
	[global::Cpp2ILInjected.Token(Token = "0x6001205")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72548", Offset = "0xA72548", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public ScreenshotTool()
	{
		throw null;
	}

	// Token: 0x04001BCB RID: 7115
	[global::Cpp2ILInjected.Token(Token = "0x4002189")]
	public static ScreenshotTool Instance;

	// Token: 0x04001BCC RID: 7116
	[global::Cpp2ILInjected.Token(Token = "0x400218A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool TakeScreenShot;

	// Token: 0x04001BCD RID: 7117
	[global::Cpp2ILInjected.Token(Token = "0x400218B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float InitialDelay;

	// Token: 0x04001BCE RID: 7118
	[global::Cpp2ILInjected.Token(Token = "0x400218C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool LastTakeShot;

	// Token: 0x04001BCF RID: 7119
	[global::Cpp2ILInjected.Token(Token = "0x400218D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float delayRemaining;

	// Token: 0x04001BD0 RID: 7120
	[global::Cpp2ILInjected.Token(Token = "0x400218E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool useControllerInput;

	// Token: 0x04001BD1 RID: 7121
	[global::Cpp2ILInjected.Token(Token = "0x400218F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private ScreenshotSetup _activeScreenshot;

	// Token: 0x04001BD2 RID: 7122
	[global::Cpp2ILInjected.Token(Token = "0x4002190")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ScreenshotSetup[] Definitions;
}
