using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001AB RID: 427
[global::Cpp2ILInjected.Token(Token = "0x200023A")]
public class SaveDataCategory_Layout : LayoutDefinition
{
	// Token: 0x06000BF7 RID: 3063 RVA: 0x00023F2A File Offset: 0x0002212A
	[global::Cpp2ILInjected.Token(Token = "0x6000D11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D236C", Offset = "0x9D236C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00023F2D File Offset: 0x0002212D
	[global::Cpp2ILInjected.Token(Token = "0x6000D12")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D23B8", Offset = "0x9D23B8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveDataCategory_Layout()
	{
		throw null;
	}

	// Token: 0x040012B8 RID: 4792
	[global::Cpp2ILInjected.Token(Token = "0x400176D")]
	public static SaveDataCategory_Layout Instance;

	// Token: 0x040012B9 RID: 4793
	[global::Cpp2ILInjected.Token(Token = "0x400176E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040012BA RID: 4794
	[global::Cpp2ILInjected.Token(Token = "0x400176F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout LocalPlayers;

	// Token: 0x040012BB RID: 4795
	[global::Cpp2ILInjected.Token(Token = "0x4001770")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout RemotePlayers;

	// Token: 0x040012BC RID: 4796
	[global::Cpp2ILInjected.Token(Token = "0x4001771")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout LocalWorlds;

	// Token: 0x040012BD RID: 4797
	[global::Cpp2ILInjected.Token(Token = "0x4001772")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RemoteWorlds;

	// Token: 0x040012BE RID: 4798
	[global::Cpp2ILInjected.Token(Token = "0x4001773")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Upload;

	// Token: 0x040012BF RID: 4799
	[global::Cpp2ILInjected.Token(Token = "0x4001774")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Download;

	// Token: 0x040012C0 RID: 4800
	[global::Cpp2ILInjected.Token(Token = "0x4001775")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout UploadSettings;

	// Token: 0x040012C1 RID: 4801
	[global::Cpp2ILInjected.Token(Token = "0x4001776")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout DownloadSettings;
}
