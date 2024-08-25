using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000022")]
public class Alert : Singleton<Alert>
{
	[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBC4", Offset = "0x6FEBC4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Init()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBC8", Offset = "0x6FEBC8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Shutdown()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBCC", Offset = "0x6FEBCC", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void PCDismissCallback(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBE8", Offset = "0x6FEBE8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBF0", Offset = "0x6FEBF0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBF8", Offset = "0x6FEBF8", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "Show", MemberParameters = new object[]
	{
		typeof(Alert.AlertShownReason),
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "Show", MemberParameters = new object[]
	{
		typeof(Alert.AlertShownReason),
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private AlertDelayer GetAlertDelayObject()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FECE8", Offset = "0x6FECE8", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "GetAlertDelayObject", ReturnType = typeof(AlertDelayer))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FED80", Offset = "0x6FED80", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "GetAlertDelayObject", ReturnType = typeof(AlertDelayer))]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x14000001")]
	public event Action<int> DismissedWithButton
	{
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEDDC", Offset = "0x6FEDDC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FEE8C", Offset = "0x6FEE8C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		remove
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEF3C", Offset = "0x6FEF3C", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "AlertCancelled", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	private void AlertButtonClicked(string button)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF3D4", Offset = "0x6FF3D4", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "AlertButtonClicked", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	private void AlertCancelled()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF400", Offset = "0x6FF400", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Alert()
	{
		throw null;
	}

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x400006B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Action<int> DismissedWithButton;

	[global::Cpp2ILInjected.Token(Token = "0x400006C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string[] _buttons;

	[global::Cpp2ILInjected.Token(Token = "0x400006D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private string _defaultButton;

	[global::Cpp2ILInjected.Token(Token = "0x400006E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GameObject _delayObject;

	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	public enum AlertShownReason
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		PlatformError,
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		NetworkingIssue,
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		DebugIAP,
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		ToolsMistake,
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		AppRating
	}
}
