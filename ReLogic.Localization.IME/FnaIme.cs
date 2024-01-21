using Cpp2IlInjected;

namespace ReLogic.Localization.IME;

[Cpp2IlInjected.Token(Token = "0x2000733")]
internal class FnaIme : PlatformIme
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4007194")]
	private bool _disposedValue;

	[Cpp2IlInjected.Token(Token = "0x170007FA")]
	public override uint CandidateCount
	{
		[Cpp2IlInjected.Token(Token = "0x6004709")]
		[Cpp2IlInjected.Address(RVA = "0xF91190", Offset = "0xF91190", VA = "0xF91190", Slot = "18")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007FB")]
	public override string CompositionString
	{
		[Cpp2IlInjected.Token(Token = "0x600470A")]
		[Cpp2IlInjected.Address(RVA = "0xF91198", Offset = "0xF91198", VA = "0xF91198", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007FC")]
	public override bool IsCandidateListVisible
	{
		[Cpp2IlInjected.Token(Token = "0x600470B")]
		[Cpp2IlInjected.Address(RVA = "0xF911F0", Offset = "0xF911F0", VA = "0xF911F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007FD")]
	public override uint SelectedCandidate
	{
		[Cpp2IlInjected.Token(Token = "0x600470C")]
		[Cpp2IlInjected.Address(RVA = "0xF911F8", Offset = "0xF911F8", VA = "0xF911F8", Slot = "17")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004707")]
	[Cpp2IlInjected.Address(RVA = "0xF90FD4", Offset = "0xF90FD4", VA = "0xF90FD4")]
	public FnaIme()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004708")]
	[Cpp2IlInjected.Address(RVA = "0xF91064", Offset = "0xF91064", VA = "0xF91064")]
	private void OnCharCallback(char key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600470D")]
	[Cpp2IlInjected.Address(RVA = "0xF91200", Offset = "0xF91200", VA = "0xF91200", Slot = "19")]
	public override string GetCandidate(uint index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600470E")]
	[Cpp2IlInjected.Address(RVA = "0xF91258", Offset = "0xF91258", VA = "0xF91258", Slot = "22")]
	protected override void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600470F")]
	[Cpp2IlInjected.Address(RVA = "0xF912DC", Offset = "0xF912DC", VA = "0xF912DC", Slot = "1")]
	~FnaIme()
	{
	}
}
