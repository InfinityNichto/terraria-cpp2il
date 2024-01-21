using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AlertDelayer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public string message;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public string button1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public string button2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public string buttonDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float delayTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Alert.AlertShownReason reason;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public string hapticId;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x11FD0B8", Offset = "0x11FD0B8", VA = "0x11FD0B8")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x11FD1DC", Offset = "0x11FD1DC", VA = "0x11FD1DC")]
	public AlertDelayer()
	{
	}
}
