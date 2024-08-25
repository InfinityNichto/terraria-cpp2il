using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine.UI
{
	[Obsolete("Not supported anymore.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public interface IMask
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000184")]
		bool Enabled();

		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			get;
		}
	}
}
