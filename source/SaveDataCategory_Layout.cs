using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200023A")]
public class SaveDataCategory_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D11")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D236C", Offset = "0x9D236C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D12")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D23B8", Offset = "0x9D23B8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveDataCategory_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400176D")]
	public static SaveDataCategory_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400176E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400176F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout LocalPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x4001770")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout RemotePlayers;

	[global::Cpp2ILInjected.Token(Token = "0x4001771")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout LocalWorlds;

	[global::Cpp2ILInjected.Token(Token = "0x4001772")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout RemoteWorlds;

	[global::Cpp2ILInjected.Token(Token = "0x4001773")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Upload;

	[global::Cpp2ILInjected.Token(Token = "0x4001774")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Download;

	[global::Cpp2ILInjected.Token(Token = "0x4001775")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout UploadSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4001776")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout DownloadSettings;
}
