using System;
using Cpp2ILInjected;

namespace ReLogic.Localization.IME
{
	// Token: 0x02000731 RID: 1841
	[global::Cpp2ILInjected.Token(Token = "0x2000B30")]
	public interface IImeService
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060046D1 RID: 18129
		[global::Cpp2ILInjected.Token(Token = "0x17000900")]
		string CompositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005386")]
			get;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060046D2 RID: 18130
		[global::Cpp2ILInjected.Token(Token = "0x17000901")]
		bool IsCandidateListVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005387")]
			get;
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060046D3 RID: 18131
		[global::Cpp2ILInjected.Token(Token = "0x17000902")]
		uint SelectedCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005388")]
			get;
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060046D4 RID: 18132
		[global::Cpp2ILInjected.Token(Token = "0x17000903")]
		uint CandidateCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005389")]
			get;
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060046D5 RID: 18133
		[global::Cpp2ILInjected.Token(Token = "0x17000904")]
		bool IsEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600538A")]
			get;
		}

		// Token: 0x060046D6 RID: 18134
		[global::Cpp2ILInjected.Token(Token = "0x600538B")]
		string GetCandidate(uint index);

		// Token: 0x060046D7 RID: 18135
		[global::Cpp2ILInjected.Token(Token = "0x600538C")]
		void Enable();

		// Token: 0x060046D8 RID: 18136
		[global::Cpp2ILInjected.Token(Token = "0x600538D")]
		void Disable();

		// Token: 0x060046D9 RID: 18137
		[global::Cpp2ILInjected.Token(Token = "0x600538E")]
		void AddKeyListener(Action<char> listener);

		// Token: 0x060046DA RID: 18138
		[global::Cpp2ILInjected.Token(Token = "0x600538F")]
		void RemoveKeyListener(Action<char> listener);
	}
}
