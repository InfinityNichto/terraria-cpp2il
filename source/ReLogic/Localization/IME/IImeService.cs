using System;
using Cpp2ILInjected;

namespace ReLogic.Localization.IME
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B30")]
	public interface IImeService
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000900")]
		string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005386")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000901")]
		bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005387")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000902")]
		uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005388")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000903")]
		uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005389")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000904")]
		bool IsEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600538A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600538B")]
		string GetCandidate(uint index);

		[global::Cpp2ILInjected.Token(Token = "0x600538C")]
		void Enable();

		[global::Cpp2ILInjected.Token(Token = "0x600538D")]
		void Disable();

		[global::Cpp2ILInjected.Token(Token = "0x600538E")]
		void AddKeyListener(Action<char> listener);

		[global::Cpp2ILInjected.Token(Token = "0x600538F")]
		void RemoveKeyListener(Action<char> listener);
	}
}
