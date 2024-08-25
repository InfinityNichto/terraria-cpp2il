using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x2000845")]
	public interface ISmartInteractBlockReasonProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004317")]
		bool ShouldBlockSmartInteract(SmartInteractScanSettings settings);
	}
}
