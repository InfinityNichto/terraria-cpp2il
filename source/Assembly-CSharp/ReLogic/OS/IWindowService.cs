using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace ReLogic.OS
{
	// Token: 0x02000723 RID: 1827
	[global::Cpp2ILInjected.Token(Token = "0x2000B21")]
	public interface IWindowService
	{
		// Token: 0x06004696 RID: 18070
		[global::Cpp2ILInjected.Token(Token = "0x6005349")]
		void SetUnicodeTitle(GameWindow window, string title);

		// Token: 0x06004697 RID: 18071
		[global::Cpp2ILInjected.Token(Token = "0x600534A")]
		void StartFlashingIcon(GameWindow window);

		// Token: 0x06004698 RID: 18072
		[global::Cpp2ILInjected.Token(Token = "0x600534B")]
		void StopFlashingIcon(GameWindow window);

		// Token: 0x06004699 RID: 18073
		[global::Cpp2ILInjected.Token(Token = "0x600534C")]
		float GetScaling();

		// Token: 0x0600469A RID: 18074
		[global::Cpp2ILInjected.Token(Token = "0x600534D")]
		void SetQuickEditEnabled(bool enabled);
	}
}
