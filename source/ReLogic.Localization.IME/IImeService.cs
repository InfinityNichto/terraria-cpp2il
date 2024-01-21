using System;
using Cpp2IlInjected;

namespace ReLogic.Localization.IME;

[Cpp2IlInjected.Token(Token = "0x2000734")]
public interface IImeService
{
	[Cpp2IlInjected.Token(Token = "0x170007FE")]
	string CompositionString
	{
		[Cpp2IlInjected.Token(Token = "0x6004710")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170007FF")]
	bool IsCandidateListVisible
	{
		[Cpp2IlInjected.Token(Token = "0x6004711")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000800")]
	uint SelectedCandidate
	{
		[Cpp2IlInjected.Token(Token = "0x6004712")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000801")]
	uint CandidateCount
	{
		[Cpp2IlInjected.Token(Token = "0x6004713")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000802")]
	bool IsEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6004714")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6004715")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string GetCandidate(uint index);

	[Cpp2IlInjected.Token(Token = "0x6004716")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void Enable();

	[Cpp2IlInjected.Token(Token = "0x6004717")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void Disable();

	[Cpp2IlInjected.Token(Token = "0x6004718")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AddKeyListener(Action<char> listener);

	[Cpp2IlInjected.Token(Token = "0x6004719")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RemoveKeyListener(Action<char> listener);
}
