using Cpp2IlInjected;

namespace ReLogic.Localization.IME;

[Cpp2IlInjected.Token(Token = "0x2000736")]
public class UnsupportedPlatformIme : PlatformIme
{
	[Cpp2IlInjected.Token(Token = "0x17000808")]
	public override uint CandidateCount
	{
		[Cpp2IlInjected.Token(Token = "0x600472C")]
		[Cpp2IlInjected.Address(RVA = "0xF9157C", Offset = "0xF9157C", VA = "0xF9157C", Slot = "18")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000809")]
	public override string CompositionString
	{
		[Cpp2IlInjected.Token(Token = "0x600472D")]
		[Cpp2IlInjected.Address(RVA = "0xF91584", Offset = "0xF91584", VA = "0xF91584", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700080A")]
	public override bool IsCandidateListVisible
	{
		[Cpp2IlInjected.Token(Token = "0x600472E")]
		[Cpp2IlInjected.Address(RVA = "0xF915DC", Offset = "0xF915DC", VA = "0xF915DC", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700080B")]
	public override uint SelectedCandidate
	{
		[Cpp2IlInjected.Token(Token = "0x600472F")]
		[Cpp2IlInjected.Address(RVA = "0xF915E4", Offset = "0xF915E4", VA = "0xF915E4", Slot = "17")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004730")]
	[Cpp2IlInjected.Address(RVA = "0xF915EC", Offset = "0xF915EC", VA = "0xF915EC", Slot = "19")]
	public override string GetCandidate(uint index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004731")]
	[Cpp2IlInjected.Address(RVA = "0xF91644", Offset = "0xF91644", VA = "0xF91644")]
	public UnsupportedPlatformIme()
	{
	}
}
