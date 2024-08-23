using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006F5 RID: 1781
	[global::Cpp2ILInjected.Token(Token = "0x2000AE2")]
	public class PlainTagHandler : ITagHandler
	{
		// Token: 0x06004578 RID: 17784 RVA: 0x0002E6EB File Offset: 0x0002C8EB
		[global::Cpp2ILInjected.Token(Token = "0x60051E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9363C0", Offset = "0x9363C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw null;
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x0002E6EE File Offset: 0x0002C8EE
		[global::Cpp2ILInjected.Token(Token = "0x60051E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x936424", Offset = "0x936424", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlainTagHandler()
		{
			throw null;
		}

		// Token: 0x02000AC9 RID: 2761
		[global::Cpp2ILInjected.Token(Token = "0x2000AE3")]
		public class PlainSnippet : TextSnippet
		{
			// Token: 0x0600529C RID: 21148 RVA: 0x0003091A File Offset: 0x0002EB1A
			[global::Cpp2ILInjected.Token(Token = "0x60051EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x93641C", Offset = "0x93641C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			public PlainSnippet(string text = "")
			{
				throw null;
			}

			// Token: 0x0600529D RID: 21149 RVA: 0x0003091D File Offset: 0x0002EB1D
			[global::Cpp2ILInjected.Token(Token = "0x60051EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x93642C", Offset = "0x93642C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "ConvertNormalSnippets", MemberParameters = new object[] { typeof(TextSnippet[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(void))]
			public PlainSnippet(string text, Color color, float scale = 1f)
			{
				throw null;
			}

			// Token: 0x0600529E RID: 21150 RVA: 0x00030920 File Offset: 0x0002EB20
			[global::Cpp2ILInjected.Token(Token = "0x60051EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x936438", Offset = "0x936438", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override Color GetVisibleColor()
			{
				throw null;
			}
		}
	}
}
