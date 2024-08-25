using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.Initializers;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AD6")]
	public class AchievementTagHandler : ITagHandler
	{
		[global::Cpp2ILInjected.Token(Token = "0x600519F")]
		[global::Cpp2ILInjected.Address(RVA = "0x931AE0", Offset = "0x931AE0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "GetAchievement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Achievement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTagHandler.AchievementSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x931C3C", Offset = "0x931C3C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "OnAchievementCompleted", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GenerateTag(Achievement achievement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x931CA8", Offset = "0x931CA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AchievementTagHandler()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000AD7")]
		private class AchievementSnippet : TextSnippet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60051A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x931BAC", Offset = "0x931BAC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Color),
				typeof(string)
			}, ReturnType = typeof(TextSnippet))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public AchievementSnippet(Achievement achievement)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60051A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x931CB0", Offset = "0x931CB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "OpenAchievementsAndGoto", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
			public override void OnClick()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008A31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Achievement _achievement;
		}
	}
}
