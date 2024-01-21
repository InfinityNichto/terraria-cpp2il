using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200024F")]
public class ScreenshotTool : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4001BD4")]
	public static ScreenshotTool Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BD5")]
	public bool TakeScreenShot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BD6")]
	public float InitialDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BD7")]
	private bool LastTakeShot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001BD8")]
	private float delayRemaining;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001BD9")]
	private bool useControllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001BDA")]
	private ScreenshotSetup _activeScreenshot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001BDB")]
	public ScreenshotSetup[] Definitions;

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public bool UseControllerInput
	{
		[Cpp2IlInjected.Token(Token = "0x60010C7")]
		[Cpp2IlInjected.Address(RVA = "0xFA5A9C", Offset = "0xFA5A9C", VA = "0xFA5A9C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60010C8")]
		[Cpp2IlInjected.Address(RVA = "0xFA5AA4", Offset = "0xFA5AA4", VA = "0xFA5AA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public bool TakeScreenShotThisFrame
	{
		[Cpp2IlInjected.Token(Token = "0x60010C9")]
		[Cpp2IlInjected.Address(RVA = "0xFA5AAC", Offset = "0xFA5AAC", VA = "0xFA5AAC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public ScreenshotSetup ActiveScreenshot
	{
		[Cpp2IlInjected.Token(Token = "0x60010CB")]
		[Cpp2IlInjected.Address(RVA = "0xFA5BCC", Offset = "0xFA5BCC", VA = "0xFA5BCC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60010CC")]
		[Cpp2IlInjected.Address(RVA = "0xFA5BD4", Offset = "0xFA5BD4", VA = "0xFA5BD4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010CA")]
	[Cpp2IlInjected.Address(RVA = "0xFA5B50", Offset = "0xFA5B50", VA = "0xFA5B50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010CD")]
	[Cpp2IlInjected.Address(RVA = "0xFA5BDC", Offset = "0xFA5BDC", VA = "0xFA5BDC")]
	public ScreenshotTool()
	{
	}
}
