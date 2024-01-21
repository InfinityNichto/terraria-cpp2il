using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002BC")]
internal class PresentationEventArgs : EventArgs
{
	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public PresentationParameters PresentationParameters
	{
		[Cpp2IlInjected.Token(Token = "0x6001693")]
		[Cpp2IlInjected.Address(RVA = "0x1592464", Offset = "0x1592464", VA = "0x1592464")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001694")]
		[Cpp2IlInjected.Address(RVA = "0x159246C", Offset = "0x159246C", VA = "0x159246C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001695")]
	[Cpp2IlInjected.Address(RVA = "0x1592474", Offset = "0x1592474", VA = "0x1592474")]
	public PresentationEventArgs(PresentationParameters presentationParameters)
	{
	}
}
