using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000967")]
	public interface IProvideSearchFilterString
	{
		[global::Cpp2ILInjected.Token(Token = "0x600481B")]
		string GetSearchString(ref BestiaryUICollectionInfo info);
	}
}
