using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A6 RID: 1446
	[global::Cpp2ILInjected.Token(Token = "0x2000845")]
	public interface ISmartInteractBlockReasonProvider
	{
		// Token: 0x06003BF4 RID: 15348
		[global::Cpp2ILInjected.Token(Token = "0x6004317")]
		bool ShouldBlockSmartInteract(SmartInteractScanSettings settings);
	}
}
