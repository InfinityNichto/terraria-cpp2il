using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Initializers;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007CD")]
	public class PlayerRainbowWingsTextureContent : ARenderTargetContentByRequest
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C08", Offset = "0x772C08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C0C", Offset = "0x772C0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerRainbowWingsTextureContent()
		{
			throw null;
		}
	}
}
