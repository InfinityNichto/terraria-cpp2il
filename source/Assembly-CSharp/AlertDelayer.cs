using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200001E RID: 30
[global::Cpp2ILInjected.Token(Token = "0x2000024")]
public class AlertDelayer : MonoBehaviour
{
	// Token: 0x060000A3 RID: 163 RVA: 0x00021D61 File Offset: 0x0001FF61
	[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF46C", Offset = "0x6FF46C", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00021D64 File Offset: 0x0001FF64
	[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FF54C", Offset = "0x6FF54C", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public AlertDelayer()
	{
		throw null;
	}

	// Token: 0x04000068 RID: 104
	[global::Cpp2ILInjected.Token(Token = "0x4000075")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string title;

	// Token: 0x04000069 RID: 105
	[global::Cpp2ILInjected.Token(Token = "0x4000076")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string message;

	// Token: 0x0400006A RID: 106
	[global::Cpp2ILInjected.Token(Token = "0x4000077")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string button1;

	// Token: 0x0400006B RID: 107
	[global::Cpp2ILInjected.Token(Token = "0x4000078")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public string button2;

	// Token: 0x0400006C RID: 108
	[global::Cpp2ILInjected.Token(Token = "0x4000079")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string buttonDefault;

	// Token: 0x0400006D RID: 109
	[global::Cpp2ILInjected.Token(Token = "0x400007A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float delayTime;

	// Token: 0x0400006E RID: 110
	[global::Cpp2ILInjected.Token(Token = "0x400007B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Alert.AlertShownReason reason;

	// Token: 0x0400006F RID: 111
	[global::Cpp2ILInjected.Token(Token = "0x400007C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public string hapticId;
}
