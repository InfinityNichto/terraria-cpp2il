using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001D")]
public class Alert : Singleton<Alert>
{
	[Cpp2IlInjected.Token(Token = "0x2000766")]
	public enum AlertShownReason
	{
		[Cpp2IlInjected.Token(Token = "0x40077EE")]
		PlatformError,
		[Cpp2IlInjected.Token(Token = "0x40077EF")]
		NetworkingIssue,
		[Cpp2IlInjected.Token(Token = "0x40077F0")]
		DebugIAP,
		[Cpp2IlInjected.Token(Token = "0x40077F1")]
		ToolsMistake,
		[Cpp2IlInjected.Token(Token = "0x40077F2")]
		AppRating
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string[] _buttons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string _defaultButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private GameObject _delayObject;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<int> DismissedWithButton
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x11FC834", Offset = "0x11FC834", VA = "0x11FC834")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x11FC8E4", Offset = "0x11FC8E4", VA = "0x11FC8E4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x11FC5C0", Offset = "0x11FC5C0", VA = "0x11FC5C0", Slot = "4")]
	public override void Init()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x11FC5C4", Offset = "0x11FC5C4", VA = "0x11FC5C4", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x11FC5C8", Offset = "0x11FC5C8", VA = "0x11FC5C8")]
	private void PCDismissCallback(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x11FC638", Offset = "0x11FC638", VA = "0x11FC638")]
	public void InternalShowDelayed(AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x11FC644", Offset = "0x11FC644", VA = "0x11FC644")]
	public void InternalShowDelayed(AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x11FC650", Offset = "0x11FC650", VA = "0x11FC650")]
	private AlertDelayer GetAlertDelayObject()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x11FC744", Offset = "0x11FC744", VA = "0x11FC744")]
	public void Show(AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x11FC7E8", Offset = "0x11FC7E8", VA = "0x11FC7E8")]
	public void Show(AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x11FC994", Offset = "0x11FC994", VA = "0x11FC994")]
	private void AlertButtonClicked(string button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x11FCF8C", Offset = "0x11FCF8C", VA = "0x11FCF8C")]
	private void AlertCancelled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x11FD01C", Offset = "0x11FD01C", VA = "0x11FD01C")]
	public Alert()
	{
	}
}
