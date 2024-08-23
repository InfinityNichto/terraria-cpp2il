using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017A RID: 378
[global::Cpp2ILInjected.Token(Token = "0x2000204")]
public class MultiplayerJoin_Layout : LayoutDefinition
{
	// Token: 0x06000B92 RID: 2962 RVA: 0x00023DFB File Offset: 0x00021FFB
	[global::Cpp2ILInjected.Token(Token = "0x6000CA7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF4E0", Offset = "0x9CF4E0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x00023DFE File Offset: 0x00021FFE
	[global::Cpp2ILInjected.Token(Token = "0x6000CA8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF52C", Offset = "0x9CF52C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerJoin_Layout()
	{
		throw null;
	}

	// Token: 0x04000E93 RID: 3731
	[global::Cpp2ILInjected.Token(Token = "0x40012E0")]
	public static MultiplayerJoin_Layout Instance;

	// Token: 0x04000E94 RID: 3732
	[global::Cpp2ILInjected.Token(Token = "0x40012E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000E95 RID: 3733
	[global::Cpp2ILInjected.Token(Token = "0x40012E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	// Token: 0x04000E96 RID: 3734
	[global::Cpp2ILInjected.Token(Token = "0x40012E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x04000E97 RID: 3735
	[global::Cpp2ILInjected.Token(Token = "0x40012E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000E98 RID: 3736
	[global::Cpp2ILInjected.Token(Token = "0x40012E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout ServerIPTitle;

	// Token: 0x04000E99 RID: 3737
	[global::Cpp2ILInjected.Token(Token = "0x40012E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout ServerIP;

	// Token: 0x04000E9A RID: 3738
	[global::Cpp2ILInjected.Token(Token = "0x40012E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout ServerIPEdit;

	// Token: 0x04000E9B RID: 3739
	[global::Cpp2ILInjected.Token(Token = "0x40012E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout ServerPortTitle;

	// Token: 0x04000E9C RID: 3740
	[global::Cpp2ILInjected.Token(Token = "0x40012E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout ServerPort;

	// Token: 0x04000E9D RID: 3741
	[global::Cpp2ILInjected.Token(Token = "0x40012EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout ServerPortEdit;

	// Token: 0x04000E9E RID: 3742
	[global::Cpp2ILInjected.Token(Token = "0x40012EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ServerIPButton;

	// Token: 0x04000E9F RID: 3743
	[global::Cpp2ILInjected.Token(Token = "0x40012EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout ServerPortButton;

	// Token: 0x04000EA0 RID: 3744
	[global::Cpp2ILInjected.Token(Token = "0x40012ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Back;

	// Token: 0x04000EA1 RID: 3745
	[global::Cpp2ILInjected.Token(Token = "0x40012EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Join;
}
