using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000213")]
[Serializable]
public class SettingsOverlayLink_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CC2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFEC4", Offset = "0x9CFEC4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayLink_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40013CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string WikiLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string ForumLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string DiscordLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public string SupportLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public string YoutubeLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string TwitterLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public string PrivacyLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public string FacebookLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public string BugReportLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public string RedditLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public string CreditsLink;

	[global::Cpp2ILInjected.Token(Token = "0x40013D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout LinkButton;

	[global::Cpp2ILInjected.Token(Token = "0x40013D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Caption;

	[global::Cpp2ILInjected.Token(Token = "0x40013D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float ElementSpacing;
}
