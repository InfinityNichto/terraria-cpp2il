using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200001D RID: 29
[global::Cpp2ILInjected.Token(Token = "0x2000022")]
public class Alert : Singleton<Alert>
{
	// Token: 0x06000096 RID: 150 RVA: 0x00021D3A File Offset: 0x0001FF3A
	[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBC4", Offset = "0x6FEBC4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Init()
	{
		throw null;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00021D3D File Offset: 0x0001FF3D
	[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBC8", Offset = "0x6FEBC8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Shutdown()
	{
		throw null;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00021D40 File Offset: 0x0001FF40
	[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBCC", Offset = "0x6FEBCC", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void PCDismissCallback(int index)
	{
		throw null;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00021D43 File Offset: 0x0001FF43
	[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBE8", Offset = "0x6FEBE8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		throw null;
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00021D46 File Offset: 0x0001FF46
	[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEBF0", Offset = "0x6FEBF0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void InternalShowDelayed(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		throw null;
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00021D49 File Offset: 0x0001FF49
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

	// Token: 0x0600009C RID: 156 RVA: 0x00021D4C File Offset: 0x0001FF4C
	[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FECE8", Offset = "0x6FECE8", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "GetAlertDelayObject", ReturnType = typeof(AlertDelayer))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button, string hapticId = "")
	{
		throw null;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00021D4F File Offset: 0x0001FF4F
	[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FED80", Offset = "0x6FED80", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "GetAlertDelayObject", ReturnType = typeof(AlertDelayer))]
	public void Show(Alert.AlertShownReason reason, string title, string message, string button1, string button2, string buttonDefault, string hapticId = "")
	{
		throw null;
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600009E RID: 158 RVA: 0x00021D52 File Offset: 0x0001FF52
	// (remove) Token: 0x0600009F RID: 159 RVA: 0x00021D55 File Offset: 0x0001FF55
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

	// Token: 0x060000A0 RID: 160 RVA: 0x00021D58 File Offset: 0x0001FF58
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

	// Token: 0x060000A1 RID: 161 RVA: 0x00021D5B File Offset: 0x0001FF5B
	[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF3D4", Offset = "0x6FF3D4", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alert), Member = "AlertButtonClicked", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	private void AlertCancelled()
	{
		throw null;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00021D5E File Offset: 0x0001FF5E
	[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF400", Offset = "0x6FF400", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Alert()
	{
		throw null;
	}

	// Token: 0x04000064 RID: 100
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x400006B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Action<int> DismissedWithButton;

	// Token: 0x04000065 RID: 101
	[global::Cpp2ILInjected.Token(Token = "0x400006C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string[] _buttons;

	// Token: 0x04000066 RID: 102
	[global::Cpp2ILInjected.Token(Token = "0x400006D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private string _defaultButton;

	// Token: 0x04000067 RID: 103
	[global::Cpp2ILInjected.Token(Token = "0x400006E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GameObject _delayObject;

	// Token: 0x0200076F RID: 1903
	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	public enum AlertShownReason
	{
		// Token: 0x040077FF RID: 30719
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		PlatformError,
		// Token: 0x04007800 RID: 30720
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		NetworkingIssue,
		// Token: 0x04007801 RID: 30721
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		DebugIAP,
		// Token: 0x04007802 RID: 30722
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		ToolsMistake,
		// Token: 0x04007803 RID: 30723
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		AppRating
	}
}
