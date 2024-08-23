using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Initializers;

namespace Terraria.GameContent
{
	// Token: 0x02000552 RID: 1362
	[global::Cpp2ILInjected.Token(Token = "0x20007CE")]
	public class PlayerQueenSlimeMountTextureContent : ARenderTargetContentByRequest
	{
		// Token: 0x060039D9 RID: 14809 RVA: 0x0002C54C File Offset: 0x0002A74C
		[global::Cpp2ILInjected.Token(Token = "0x60040AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C14", Offset = "0x772C14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x0002C54F File Offset: 0x0002A74F
		[global::Cpp2ILInjected.Token(Token = "0x60040B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C18", Offset = "0x772C18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerQueenSlimeMountTextureContent()
		{
			throw null;
		}
	}
}
