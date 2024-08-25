using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000308")]
public class ScreenshotTool : MonoBehaviour
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6001202")]
	[global::Cpp2ILInjected.Address(RVA = "0xA724EC", Offset = "0xA724EC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6001205")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72548", Offset = "0xA72548", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public ScreenshotTool()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4002189")]
	public static ScreenshotTool Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400218A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool TakeScreenShot;

	[global::Cpp2ILInjected.Token(Token = "0x400218B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float InitialDelay;

	[global::Cpp2ILInjected.Token(Token = "0x400218C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool LastTakeShot;

	[global::Cpp2ILInjected.Token(Token = "0x400218D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float delayRemaining;

	[global::Cpp2ILInjected.Token(Token = "0x400218E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool useControllerInput;

	[global::Cpp2ILInjected.Token(Token = "0x400218F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private ScreenshotSetup _activeScreenshot;

	[global::Cpp2ILInjected.Token(Token = "0x4002190")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ScreenshotSetup[] Definitions;
}
