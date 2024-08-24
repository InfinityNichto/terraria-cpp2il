using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006F4 RID: 1780
	[global::Cpp2ILInjected.Token(Token = "0x2000AE1")]
	public class NameTagHandler : ITagHandler
	{
		// Token: 0x06004575 RID: 17781 RVA: 0x0002E6E2 File Offset: 0x0002C8E2
		[global::Cpp2ILInjected.Token(Token = "0x60051E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x93619C", Offset = "0x93619C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw null;
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x0002E6E5 File Offset: 0x0002C8E5
		[global::Cpp2ILInjected.Token(Token = "0x60051E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9362E0", Offset = "0x9362E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatHelper), Member = "DisplayCheckedMessage", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ChatHelper.ChatRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string GenerateTag(string name)
		{
			throw null;
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		[global::Cpp2ILInjected.Token(Token = "0x60051E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9363B8", Offset = "0x9363B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NameTagHandler()
		{
			throw null;
		}
	}
}
